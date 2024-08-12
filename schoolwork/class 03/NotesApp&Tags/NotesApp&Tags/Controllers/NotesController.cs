using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NotesApp_Tags.Db;
using NotesApp_Tags.Models;
using NotesApp_Tags.Models.Enums;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

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

        [HttpGet("getFromQueryString")]
        public ActionResult<Note> GetFromQueryString([FromQuery] int index)
        {
            try
            {
                if (index <= 0) return BadRequest("Please don't request using a negative or zero value index!");
                if (index > StaticDb.Notes.Count) return StatusCode(StatusCodes.Status404NotFound, "Nonexistent index!");

                return Ok(StaticDb.Notes[index - 1]);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Please notify us about this error through our support page");
            }
        }
        [HttpGet("({text}/priority/{priority}")]
        public ActionResult<List<Note>> FilterNotes(string? text, int? priority)
        {
            try
            {
                if(string.IsNullOrEmpty(text) || (priority == null || priority < 0 || priority > 3)) 
                {
                    return Ok(StaticDb.Notes);
                }
                if (string.IsNullOrEmpty(text)) return Ok(StaticDb.Notes.Where(x => priority == (int)x.Priority));
                return Ok(StaticDb.Notes.Where(x => x.Text.ToLower().Contains(text.ToLower()) && priority == (int)x.Priority));
            } catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Please notify us about this error through our support page");
            }
        }

    }
}
