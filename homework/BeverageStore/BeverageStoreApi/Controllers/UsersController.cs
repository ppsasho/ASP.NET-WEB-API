using DTOs.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace BeverageStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService service)
        {
            _userService = service;
        }
        [HttpGet]
        [Authorize]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }
        [Authorize]
        [HttpGet("{id:int}")]
        public IActionResult GetById (int id) 
        {
            var found = _userService.GetById(id);

            if(found == null)
                return NotFound("User wasn't found with the specified Id!");

            return Ok(found);
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody]UserCreateDto model)
        {
                if (model.Password != model.ConfirmPassword)
                    return BadRequest("Please make sure the passwords are matching!");

                if (_userService.Register(model))
                    return CreatedAtAction("Successfully registered!", model);

                return BadRequest("User wasn't successfully registered!");
        }

        [HttpPost("login")]
        public IActionResult Login(UserLoginDto model)
        {
            if (model.Password != model.ConfirmPassword)
                return BadRequest("Please make sure the passwords are matching!");

            var response = _userService.Login(model);

            if (response.Email == null)
                return NotFound("The user wasn't found with the entered credentials");

            return Ok(response);
        }
        
    }
}
