using EcommerceStoreAPI.Data;
using EcommerceStoreAPI.DTOs;
using EcommerceStoreAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]//api/products
        public ActionResult<IEnumerable<ProductDto>> GetAll()
        {
            var products = StaticDb.Products.Select(x => new ProductDto
            {
                Name = x.Name,
                Description = x.Description,
                Price = x.Price,
                ImageUrl = x.ImageUrl,
            }).ToList();
            return Ok(products);
        }

        [HttpGet("{id:int}")] //api/products/id
        public ActionResult<ProductDto> GetById(int id)
        {
            if (id <= 0) return BadRequest("Product id must be greater than zero");
            if (id > StaticDb.Products.Count) return NotFound("Nonexistent Id");
            var productDto = StaticDb.Products.Where(x => x.Id.Equals(id))
                                              .Select(x => new ProductDto
                                              {
                                                  Name = x.Name,
                                                  Description = x.Description,
                                                  Price = x.Price,
                                                  ImageUrl = x.ImageUrl,
                                              })
                                              .SingleOrDefault();
            return productDto;
        }

        [HttpPost]
        public ActionResult<ProductDto> Post([FromBody] CreateProductDto createProductDto)
        {
            if(createProductDto == null) return BadRequest("Please fill all properties!");
            int maxId = StaticDb.Products.Max(x => x.Id + 1);
            var category = StaticDb.Categories.SingleOrDefault(x => x.Id.Equals(createProductDto.CategoryId));
            if (category == null) return BadRequest("Category not found!");
            var product = new Product
            {
                Id = maxId,
                Name = createProductDto.Name,
                Description = createProductDto.Description,
                Price = createProductDto.Price,
                ImageUrl = createProductDto.ImageUrl,
                StockQuantity = createProductDto.StockQuantity,
                CategoryId = createProductDto.CategoryId,
                Category = category
            };

            StaticDb.Products.Add(product);

            return CreatedAtAction(nameof(GetById), new { id = product.Id }, createProductDto);
        }

        [HttpDelete("{id:int}")] //api/products/id
        public IActionResult Delete(int id)
        {
            var product = StaticDb.Products.SingleOrDefault(x => x.Id == id);
            if (product == null) return StatusCode(StatusCodes.Status404NotFound, $"Product with id{id} was not found!");
            StaticDb.Products.Remove(product);
            return Ok("Product deleted successfully!");
        }

        [HttpPut("id:int")]
        public IActionResult Put(int id, [FromBody] CreateProductDto updatedProduct)
        {

            var existingProduct = StaticDb.Products.SingleOrDefault(x => x.Id.Equals(id));
            var category = StaticDb.Categories.SingleOrDefault(x => x.Id.Equals(updatedProduct.CategoryId));

            if (existingProduct == null) return NotFound("Not found an existing product with the id");
            existingProduct.Name = updatedProduct.Name;
            existingProduct.Description = updatedProduct.Description;
            existingProduct.Price = updatedProduct.Price;
            existingProduct.StockQuantity = updatedProduct.StockQuantity;
            existingProduct.ImageUrl = updatedProduct.ImageUrl;

            StaticDb.Products.Add(existingProduct);


        }
    }
}
