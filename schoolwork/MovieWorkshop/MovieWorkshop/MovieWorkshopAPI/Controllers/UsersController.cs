using DTOs.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace MovieWorkshopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService service)
        {
            _userService = service;
        }

        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] RegisterUserDto registerUser)
        {
            try
            {
                if (_userService.RegisterUser(registerUser)) 
                    return StatusCode(StatusCodes.Status201Created, "User was successfully created!");

                return BadRequest("Username is already taken!\nPlease try another username.");
            } catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "There was an error during the register process, please try again!");
            }
        }

        [HttpPost("login")]
        public IActionResult LoginUser([FromBody] UserLoginDto user)
        {
            try
            {
                var found = _userService.LoginUser(user.Username, user.Password);

                if(found.FirstName != null) 
                    return Ok(found);

                return BadRequest("Login failed!");
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
