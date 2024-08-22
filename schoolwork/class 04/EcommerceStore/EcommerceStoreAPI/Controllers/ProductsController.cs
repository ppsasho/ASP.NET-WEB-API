using DomainModels;
using DTOs.Product;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Mappers;

namespace EcommerceStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductsController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]//api/products
        public ActionResult<IEnumerable<ProductDto>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id:int}")] //api/products/id
        public ActionResult<Product> GetById(int id)
        {
            if (id <= 0) return BadRequest("Product id must be greater than zero");
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public ActionResult<ProductDto> Post([FromBody] CreateProductDto createProductDto)
        {
            if (createProductDto.CategoryId < 1) return BadRequest("Please make sure the id isn't a negative or zero-value entry!");
            if(_service.Add(createProductDto)) return CreatedAtAction("Successfully created the product!", createProductDto);
            return StatusCode(StatusCodes.Status500InternalServerError, "Something unexpected happened!");
        }

        [HttpDelete("{id:int}")] //api/products/id
        public IActionResult Delete(int id)
        {
            var product = _service.GetById(id);
            if (product == null) return StatusCode(StatusCodes.Status404NotFound, $"Product with id{id} was not found!");
            _service.DeleteById(product.Id);
            return Ok("Product deleted successfully!");
        }

        [HttpPut("{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromBody] CreateProductDto updatedProduct)
        {
            var existingProduct = _service.GetById(id);

            if (existingProduct == null) return NotFound("Not found an existing product with the id");
            if (_service.Update(updatedProduct)) return Ok("Successfully updated the product!");
            return StatusCode(StatusCodes.Status500InternalServerError, "The update failed for an unexpected reason!");

        }
    }
}
