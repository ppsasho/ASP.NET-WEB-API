using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotesApp_Tags.Db;
using NotesApp_Tags.Models;

namespace NotesApp_Tags.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> GetAll() 
        {
            return Ok(StaticDb.Users);
        }
        #region Path Variables

        [HttpGet("byId/{id:int}")]
        public ActionResult GetById(int id) 
        {
            if (id <= 0) return BadRequest("id mustn't be a negative or equal to zero!");
            if (id > StaticDb.Users.Count) return StatusCode(StatusCodes.Status404NotFound, "Nonexistent id!");
            return Ok(StaticDb.Users[id - 1]);
        }

        [HttpGet("byName/{name:alpha}")]
        public ActionResult GetByName(string name) 
        {
            return Ok(StaticDb.Users.FirstOrDefault(x => x.ToLower().Equals(name.ToLower())));
        }

        #endregion
        #region Query string parameters
        [HttpGet("queryString")]
        public ActionResult<string> GetByIdFromQuery(int id) 
        {
            if (id <= 0) return BadRequest("Can't request with a negative value or a value equal to zero!");
            if (id > StaticDb.Users.Count) return StatusCode(StatusCodes.Status404NotFound, "Nonexistent Id!");
            return Ok(StaticDb.Users[id-1]);
        }
        #endregion

        #region Handling body parameters
        [HttpPost("fromBody")]
        public IActionResult AddUserFromBody([FromBody]User user)
        {
            return Ok();
        }
        [HttpPost("fromQuery")]
        public IActionResult AddUserFromQueryString([FromQuery]User user)
        {
            return Ok();
        }

        [HttpPost("headerInfo")]
        public IActionResult HeaderInfo([FromHeader(Name = "Accept-Language")] 
                    string language, [FromHeader(Name = "Custom-Name")] string name)
        {
            return Ok(language);
        }
        #endregion
    }
}
