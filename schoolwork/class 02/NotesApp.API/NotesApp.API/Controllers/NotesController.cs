using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace NotesApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        [HttpGet]
        [Route("all-notes")] // if this is removed this action can be routed with just api/controllerName
                             // (as long as all the other actions have route names)
        public List<String> Notes()
        {
            return new List<string> { "wakeUp", "doYourChores", "study", "haveSomeFun" };
        }

        [HttpGet]
        [Route("info")]
        public string GetInfo()
        {
            return "Don't be lazy!";
        }

        [HttpGet("note/{id:int}")]
        public ActionResult<string> GetById(int id)
        {
            try
            {
                if (id < 0) return StatusCode(StatusCodes.Status400BadRequest, "The id can't be a negative value!");
                if (id > StaticDb.Notes.Count) return StatusCode(StatusCodes.Status404NotFound, "The id doesn't exist!");
                return StaticDb.Notes[id - 1];
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "You screwed up.");
            }
            
        }

        [HttpGet]
        [Route("static-notes")]
        public List<string> GetStaticNotes()
        {
            return StaticDb.Notes;
        }

        [HttpGet("{noteId}/user/{userId}")]
        public ActionResult<string> GetNoteByNoteIdAndUserId(int noteId, int userId)
        {
            if (noteId < 0 || userId < 0) return BadRequest("The id's can't be negative!");
            return Ok($"Returning the note with id [{noteId}] for the user with id [{userId}]"); // same as StatusCode(StatusCodes.Status200OK);
        }

        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Request.Body))
                {
                    string newNote = sr.ReadToEnd();
                    if (string.IsNullOrEmpty(newNote)) return BadRequest("The request can't be empty!");

                    StaticDb.Notes.Add(newNote);
                    return Ok("The note was added successfully!");

                }
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured!");
            }
        }

        
    }
}
