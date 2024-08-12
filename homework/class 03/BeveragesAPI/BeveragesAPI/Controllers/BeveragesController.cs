using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeveragesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeveragesController : ControllerBase
    {
        #region Test Beverages for PostMultiple
        /*
              [
      {
        "brand": "Crisp Cola",
        "type": "Soda"
      },
      {
        "brand": "Mountain Brew",
        "type": "Energy Drink"
      },
      {
        "brand": "Frosty Lemonade",
        "type": "Soft Drink"
      },
      {
        "brand": "Java Jolt",
        "type": "Coffee"
      },
      {
        "brand": "Berry Burst",
        "type": "Fruit Juice"
      },
      {
        "brand": "Chai Delight",
        "type": "Tea"
      },
      {
        "brand": "Fizz Fizz",
        "type": "Sparkling Water"
      },
      {
        "brand": "Mango Tango",
        "type": "Smoothie"
      },
      {
        "brand": "Rooty Root Beer",
        "type": "Root Beer"
      },
      {
        "brand": "Green Tea Elixir",
        "type": "Matcha"
      },
      {
        "brand": "Pineapple Splash",
        "type": "Fruit Punch"
      },
      {
        "brand": "Espresso Supreme",
        "type": "Espresso"
      },
      {
        "brand": "Ginger Zing",
        "type": "Ginger Ale"
      },
      {
        "brand": "Berry Blast",
        "type": "Smoothie"
      },
      {
        "brand": "Lemon Lime Fizz",
        "type": "Soda"
      },
      {
        "brand": "Choco Mocha",
        "type": "Chocolate Coffee"
      },
      {
        "brand": "Tropical Twist",
        "type": "Fruit Juice"
      },
      {
        "brand": "Herbal Infusion",
        "type": "Herbal Tea"
      },
      {
        "brand": "Creamy Cappuccino",
        "type": "Cappuccino"
      },
      {
        "brand": "Blueberry Breeze",
        "type": "Smoothie"
      }
    ]

         */
        #endregion
        [HttpGet]
        public ActionResult GetAll ()
        {
            return Ok(StaticDb.Beverages);
        }
        [HttpGet("byIndex/{index:int}")]
        public ActionResult Get (int index) 
        {
            if (index <= 0) return BadRequest("Can't find beverages with negative or 0 value index!");
            if (index > StaticDb.Beverages.Count) return StatusCode(StatusCodes.Status500InternalServerError, "Index doesn't exist in the list!");
            return Ok(StaticDb.Beverages[index - 1]);
        }

        [HttpGet("filterFromQuery")]
        public ActionResult FilterByBrandAndType([FromQuery] string? brand, [FromQuery] string? type) 
        {
            try
            {
                if (string.IsNullOrEmpty(brand) && string.IsNullOrEmpty(type)) return BadRequest("Filtering requires at least one parameter!");
                if (!string.IsNullOrEmpty(brand) && !string.IsNullOrEmpty(type)) return Ok(StaticDb.Beverages.Where(x => x.Brand.ToLower().Contains(brand.ToLower()) && x.Type.ToLower().Contains(type.ToLower())));
                if (!string.IsNullOrEmpty(brand)) return Ok(StaticDb.Beverages.Where(x => x.Brand.ToLower().Contains(brand.ToLower())));
                if (!string.IsNullOrEmpty(type)) return Ok(StaticDb.Beverages.Where(x => x.Type.ToLower().Contains(type.ToLower())));
                return Ok(new List<Beverage>());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error occured, please report this to our support!");
            }
        }

        [HttpPost("postSingle")]
        public ActionResult PostSingle([FromBody] Beverage beverage) 
        {
            if (string.IsNullOrEmpty(beverage.Brand) && string.IsNullOrEmpty(beverage.Type)) return BadRequest("Please make sure the beverage has a brand and type");
            StaticDb.Beverages.Add(beverage);
            return Ok("Sucessfully added the beverage!");
        }
        [HttpPost("postMultiple")]
        public ActionResult PostMultiple([FromBody] List<Beverage> beverages)
        {
            foreach (var beverage in beverages)
                if (!string.IsNullOrEmpty(beverage.Brand) && !string.IsNullOrEmpty(beverage.Type))
                    StaticDb.Beverages.Add(beverage);
                else return BadRequest("A beverage was found with a missing property, please make sure to have both properties for all the beverages");

            return Ok("Successfully added all the beverages!");
        }
    }
}
