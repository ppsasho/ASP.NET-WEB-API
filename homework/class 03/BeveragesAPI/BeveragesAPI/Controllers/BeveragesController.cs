using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeveragesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeveragesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll ()
        {
            return Ok(StaticDb.Beverages);
        }
        [HttpGet("byIndex/{index:int}")]
        public ActionResult Get (int index) 
        {
            if (index <= 0) return BadRequest("Can't find beverages with negative or 0 value index!");
            if (index > StaticDb.Beverages.Count) return StatusCode(StatusCodes.Status500InternalServerError, "Index doesn\'t exist in the list!");
            return Ok(StaticDb.Beverages[index - 1]);
        }

        [HttpGet("filter")]
        public ActionResult FilterByBrandAndType([FromQuery] string? brand, [FromQuery] string? type) 
        {
            try
            {
                if (string.IsNullOrEmpty(brand) && string.IsNullOrEmpty(type)) return BadRequest("Filtering requires at least one parameter!");
                if (!string.IsNullOrEmpty(brand)) return Ok(StaticDb.Beverages.Where(x => x.Brand.ToLower().Equals(brand.ToLower()) ));
                if (!string.IsNullOrEmpty(type)) return Ok(StaticDb.Beverages.Where(x => x.Type.ToLower().Equals(type.ToLower()) ));
                return Ok(StaticDb.Beverages.Where(x => x.Brand.ToLower().Equals(brand.ToLower()) && x.Type.ToLower().Equals(type.ToLower()) ));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error occured, please report this to our support!");
            }
        }

        [HttpPost("postSingle")]
        public ActionResult PostSingle([FromBody] Beverage beverage) 
        {
            if (string.IsNullOrEmpty(beverage.Brand) || string.IsNullOrEmpty(beverage.Type)) return BadRequest("Please make sure the beverage has a brand and type");
            return Ok();
        }
        [HttpPost("postMultiple")]
        public ActionResult PostMultiple([FromBody] List<Beverage> beverages)
        {
            return Ok();
        }
    }
}
