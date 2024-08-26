using DTOs;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace MovieWorkshopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService service)
        {
            _movieService = service;
        }
        [HttpGet("/all")]
        public ActionResult<IEnumerable<MovieModel>> GetAll() 
        {
            return Ok(_movieService.GetAll());
        }
        [HttpGet("{id:int}")]
        public ActionResult<MovieModel> GetByIdFromRoute([FromRoute]int id) 
        {
            if (id <= 0)
                return BadRequest("Movie id must be greater than zero");

            return Ok(_movieService.GetById(id));
        }
        [HttpGet("/fromQuery")]
        public ActionResult<MovieModel> GetByIdFromQuery([FromQuery]int id) 
        {
            if (id <= 0)
                return BadRequest("Movie id must be greater than zero");

            return Ok(_movieService.GetById(id));
        }

        [HttpGet("/byYearAndGenre")]
        public ActionResult<IEnumerable<MovieModel>> GetMoviesByYearAndGenre([FromQuery]int? year,[FromQuery] string? genre)
        {
            if (year == null && string.IsNullOrEmpty(genre))
                return BadRequest("Please enter at least one parameter when filtering!");

            if (year != null && !string.IsNullOrEmpty(genre))
                return Ok(_movieService.FilterByGenreAndYear(genre, year));

            if (year != null && string.IsNullOrEmpty(genre))
                return Ok(_movieService.FilterByYear(year));

            if (year == null && !string.IsNullOrEmpty(genre))
                return Ok(_movieService.FilterByGenre(genre));

            return StatusCode(StatusCodes.Status200OK, "This is the default case where the list isn't filtered because it didn't fall into any of the cases above. Please try again!");
        }
        [HttpPost("/new")]
        public ActionResult Create([FromBody]CreateMovieModel movie)
        {
            if(movie != null)
            {
                if (_movieService.CreateMovie(movie))
                    return CreatedAtAction("Successfully created the movie!", movie);

                return StatusCode(StatusCodes.Status500InternalServerError, "The movie wasn't created successfully.");
            }
            return BadRequest("The movie isn't valid! Please check that all properties are entered with the correct values!");
        }

        [HttpPut]
        public ActionResult Update([FromBody]UpdateMovieModel movie, [FromQuery] int id) 
        {
            if ( movie != null )
            {
                if (_movieService.UpdateMovie(movie, id))
                    return Ok("Update was completed successfully!");

                return StatusCode(StatusCodes.Status500InternalServerError, "The movie wasn't updated successfully.");
            }
            return BadRequest("The movie isn't valid! Please check that all properties are entered with the correct values!");
        }

        [HttpDelete("fromRoute/{id:int}")]
        public ActionResult DeleteFromRoute([FromRoute]int id)
        {
            if (id > 0)
                if (_movieService.DeleteMovie(id))
                    return Ok("Movie was deleted successfully!");
                else return StatusCode(StatusCodes.Status500InternalServerError, "The movie wasn't deleted successfully.");
                
            return BadRequest("Movie id must be greater than zero!");
        }
        [HttpDelete("/fromBody")]
        public ActionResult DeleteFromBody([FromBody]int id)
        {
            if (id > 0)
                if (_movieService.DeleteMovie(id))
                    return Ok("Movie was deleted successfully!");
                else return StatusCode(StatusCodes.Status500InternalServerError, "The movie wasn't deleted successfully.");

            return BadRequest("Movie id must be greater than zero!");
        }
    }
}
