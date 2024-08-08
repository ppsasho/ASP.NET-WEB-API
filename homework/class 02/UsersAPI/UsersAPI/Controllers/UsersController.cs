using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UsersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("all")]
        public ActionResult<List<User>> GetAll() 
        {
            return UserDb.Users.ToList();
        }

        [HttpGet("{id:int}")]
        public ActionResult<User> GetById(int id) 
        {
            try
            {
                if (id <= 0) return StatusCode(StatusCodes.Status400BadRequest, "The id can't be negative or equal to zero!");
                if (id > UserDb.Users.Count) return StatusCode(StatusCodes.Status404NotFound, "No user exists with the requested Id!");
                return UserDb.Users.First(x => x.Id == id);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "A server error occured, please try again later!");
            }
        }

        [HttpPost]
        public ActionResult NewUser([FromBody] User user) 
        {
            try
            {
                if (UserDb.Users.Any(x => x.Username == user.Username)) return StatusCode(StatusCodes.Status400BadRequest, "Username already exists!");

                user.Id = UserDb.Users.Max(x => x.Id) + 1;
                UserDb.Users.Add(user);
                return StatusCode(StatusCodes.Status201Created, "User created successfully!");
            }
            catch 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "A server error occured, please try again later!");
            }
            
        }

    }
}
