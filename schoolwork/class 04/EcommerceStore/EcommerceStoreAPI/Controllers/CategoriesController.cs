using DomainModels;
using DTOs.Category;
using DTOs.Product;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace EcommerceStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CategoryDto>> GetAll() => Ok(_service.GetAll());

        [HttpGet("{id:int}")]
        public ActionResult<Category> GetById(int id)
        {
            if (id <= 0)
                return BadRequest("Category id must be greater than zero");

            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public ActionResult<CategoryDto> Post([FromBody] CreateCategoryDto createCategory)
        {
            if (_service.Add(createCategory))
                return CreatedAtAction("Successfully created the category!", createCategory);

            return StatusCode(StatusCodes.Status500InternalServerError, "Something unexpected happened!");
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var category = _service.GetById(id);

            if (category == null)
                return StatusCode(StatusCodes.Status404NotFound, $"Category with id{id} was not found!");

            if (_service.DeleteById(category.Id))
                return Ok("Category deleted successfully!");

            return StatusCode(StatusCodes.Status500InternalServerError, "Unexpected server error!");
        }

        [HttpPut("{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromBody] CreateCategoryDto updatedProduct)
        {
            var existingProduct = _service.GetById(id);

            if (existingProduct == null)
                return NotFound("Not found an existing category with the id");

            if (_service.Update(updatedProduct, existingProduct))
                return Ok("Successfully updated the category!");

            return StatusCode(StatusCodes.Status500InternalServerError, "The update failed for an unexpected reason!");
        }

    }
}
