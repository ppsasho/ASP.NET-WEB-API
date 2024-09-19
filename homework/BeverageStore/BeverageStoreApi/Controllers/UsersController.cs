using DTOs.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Expressions;
using Serilog;
using Services.Interfaces;
using BeverageStore.Shared.Exceptions.UserExceptions;
using DTOs.Response;

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
            try
            {
                if (id < 1)
                    return BadRequest("Please make sure the id is greater than zero!");

                var found = _userService.GetById(id);

                if (found.Fullname == null)
                    throw new UserNotFoundException("User wasn't found with the specified Id!");

                return Ok(found);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"An error occured while attempting to retrieve user with id: [{id}]");
                return (IActionResult)new ExceptionResultDto(){ ErrorMessage = ex.Message };
            }
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody]UserCreateDto model)
        {
            try
            {
                if (model.Password != model.ConfirmPassword)
                    return BadRequest("Please make sure the passwords are matching!");

                if (_userService.Register(model))
                    return CreatedAtAction("Register", model);

                throw new UserNotCreatedException("The user wasn't registered successfully!");
            }catch(Exception ex) 
            {
                Log.Error(ex, $"There was an error while attempting to register a user!\n" +
                    $"FirstName[{model.FirstName}]\tLastName[{model.LastName}]\tEmail[{model.Email}]");
                return (IActionResult)new ExceptionResultDto() { ErrorMessage = ex.Message }; ;
            }
        }

        [HttpPost("login")]
        public IActionResult Login(UserLoginDto model)
        {
            try
            {
                if (model.Password != model.ConfirmPassword)
                    return BadRequest("Please make sure the passwords are matching!");

                var response = _userService.Login(model);

                if (response.Email == null)
                    return NotFound("The user wasn't found with the entered credentials");

                return Ok(response);
            }catch(Exception ex)
            {
                Log.Error(ex, "An error occured while attempting to log in a user!");
                return (IActionResult)new ExceptionResultDto(){ ErrorMessage = ex.Message };
            }
        }
        
    }
}
