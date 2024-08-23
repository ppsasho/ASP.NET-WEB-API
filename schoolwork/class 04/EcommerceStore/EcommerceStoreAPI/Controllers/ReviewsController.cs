using DomainModels;
using DTOs.Category;
using DTOs.Product;
using DTOs.Review;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace EcommerceStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewService _service;
        public ReviewsController(IReviewService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ReviewDto>> GetAll() => Ok(_service.GetAll());

        [HttpGet("{id:int}")]
        public ActionResult<Review> GetById(int id)
        {
            if (id <= 0)
                return BadRequest("Review id must be greater than zero");

            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public ActionResult<ReviewDto> Post([FromBody] CreateReviewDto createReview)
        {
            if (_service.Add(createReview))
                return CreatedAtAction("Successfully created the category!", createReview);

            return StatusCode(StatusCodes.Status500InternalServerError, "Something unexpected happened!");
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var review = _service.GetById(id);

            if (review == null)
                return StatusCode(StatusCodes.Status404NotFound, $"Review with id {id} was not found!");

            if (_service.DeleteById(review.Id))
                return Ok("Review deleted successfully!");

            return StatusCode(StatusCodes.Status500InternalServerError, "Unexpected server error!");
        }

        [HttpPut("{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromBody] CreateReviewDto updatedReview)
        {
            var existingReview = _service.GetById(id);

            if (existingReview == null)
                return NotFound("Not found an existing category with the id");

            if (_service.Update(updatedReview, existingReview))
                return Ok("Successfully updated the category!");

            return StatusCode(StatusCodes.Status500InternalServerError, "The update failed for an unexpected reason!");
        }
    }
}
