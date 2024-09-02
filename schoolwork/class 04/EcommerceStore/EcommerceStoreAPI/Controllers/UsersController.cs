using DTOs.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace EcommerceStoreAPI.Controllers
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
        [HttpPost("register")]
        [AllowAnonymous]
        public IActionResult RegisterUser([FromBody] RegisterUserDto user) 
        {
            if (_userService.Register(user)) 
                return Ok($"User registered successfully! {user}");

            return BadRequest("User credentials are invalid!");
        }
        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult LoginUser([FromBody] UserDto user)
        {
            try
            {
                string token = _userService.LoginUser(user.Username, user.Password);
                return Ok(token);
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{ex.Message}");
            }
        }
    }
}
