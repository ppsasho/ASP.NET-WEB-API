using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotesApp_Tags.Db;
using NotesApp_Tags.Models;

namespace NotesApp_Tags.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Note>> Get()
        {
            return Ok(StaticDb.Notes);
        }

        [HttpGet("{index:int}")]
        public ActionResult<Note> GetByIndex(int index) 
        {
            if (index <= 0) return BadRequest("Please don't request using a negative or zero value index!");
            if (index > StaticDb.Notes.Count) return StatusCode(StatusCodes.Status404NotFound, "Nonexistent index!");
            return Ok(StaticDb.Notes[index-1]);
        }

        [HttpGet]
        public ActionResult<Note> GetFromQueryString(string index) 
        {
            return Ok();
        }


    }
}
