using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_Web_API_application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "Fellow", "User" };
        }
    }
}
