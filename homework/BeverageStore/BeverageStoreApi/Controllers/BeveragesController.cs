using Domain_Models.Enums;
using DTOs.Beverage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace BeverageStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeveragesController : ControllerBase
    {
        private readonly IBeverageService _service; 
        public BeveragesController(IBeverageService service) 
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAll () 
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById ([FromRoute]int id) 
        {
            if (id < 1)
                return BadRequest("Please make sure the id is greater than zero!");

            var found = _service.GetById(id);
            if (found.Name is null)
                return NotFound("No beverage was found with the specified id!");

            return Ok(found);
        }
        [Authorize]

        [HttpPost("create")]
        public IActionResult CreateBeverage([FromBody] BeverageCreateDto model) 
        {
            if (_service.Add(model))
                return CreatedAtAction("Successfully created the beverage!", model);

            return BadRequest("The beverage wasn't created successfully!");
        }
        [Authorize]
        [HttpPut("update")]
        public IActionResult UpdateBeverage([FromBody] BeverageCreateDto toUpdate, [FromRoute] int id)
        {
            var found = GetById(id);
            if (found == null)
                return NotFound("Beverage wasn't found with the specified id!");

            if (_service.Update(toUpdate, id)) 
                return Ok("Successfully updated the beverage!");

            return BadRequest("The beverage wasn't successfully updated!");
        }
        [Authorize]
        [HttpDelete("delete")]
        public IActionResult DeleteBeverage([FromRoute] int id)
        {
            var found = GetById(id);
            if (found == null)
                return NotFound("Beverage wasn't found with the specified id!");

            if (_service.Delete(id))
                return Ok("Beverage deleted successfully!");

            return BadRequest("Beverage wasn't deleted successfully!");
        }

        [HttpGet("filterByNameAndType")]
        public IActionResult FilterByNameAndType([FromQuery]string ?name, [FromQuery]BeverageType ?type)
        {
            var state = (Name: name != null, Type: type != null);

            return state switch
            {
                (false, false) => BadRequest("Please enter at least one filter parameter!"),

                (true, true) => Ok(_service.FilterByNameAndType(name, (BeverageType)type)),

                (true, false) => Ok(_service.FilterByName(name)),

                (false, true) => Ok(_service.FilterByType((BeverageType)type))
            };
        }
        
    }
}
