using DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Services.Interfaces;

namespace MovieWorkshopAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService service)
        {
            _movieService = service;
        }
        [HttpGet]
        public ActionResult<IEnumerable<MovieModel>> GetAll() 
        {
            try
            {
                return Ok(_movieService.GetAll());  
            }catch(Exception ex) 
            {
                Log.Error(ex, "Error occured while attempting to fetch all the movies");
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpGet("{id:int}")]
        public ActionResult<MovieModel> GetByIdFromRoute([FromRoute]int id) 
        {
            try
            {
                if (id <= 0)
                    return BadRequest("Movie id must be greater than zero");

                return Ok(_movieService.GetById(id));
            }catch(Exception ex) 
            {
                Log.Error(ex, $"Error occured while attempting to fetch a movie by id: [{id}] from route!");
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpGet("fromQuery")]
        public ActionResult<MovieModel> GetByIdFromQuery([FromQuery]int id) 
        {
            try
            {
                if (id <= 0)
                    return BadRequest("Movie id must be greater than zero");

                return Ok(_movieService.GetById(id));
            }catch(Exception ex)
            {
                Log.Error(ex, $"Error Occured while attempting to fetch a movie by id:[{id}] from a query parameter");
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpGet("byYearAndGenre")]
        public ActionResult<IEnumerable<MovieModel>> GetMoviesByYearAndGenre([FromQuery]int? year,[FromQuery] string? genre)
        {
            try
            {
                if (year == null && string.IsNullOrEmpty(genre))
                    return BadRequest("Please enter at least one parameter when filtering!");

                if (year != null && !string.IsNullOrEmpty(genre))
                    return Ok(_movieService.FilterByGenreAndYear(genre, year));

                if (year != null && string.IsNullOrEmpty(genre))
                    return Ok(_movieService.FilterByYear(year));

                if (year == null && !string.IsNullOrEmpty(genre))
                    return Ok(_movieService.FilterByGenre(genre));

                return StatusCode(StatusCodes.Status200OK, "This is the default case where the list isn't filtered because it didn't fall into any of the cases. Please try again!");
            } catch(Exception ex)
            {
                Log.Error(ex, $"Error while filtering movies using parameters:(year: {year}, genre: {genre})!");
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost("new")]
        public ActionResult Create([FromBody]CreateMovieModel movie)
        {
            try
            {
                if(movie != null)
                {
                    if (_movieService.CreateMovie(movie))
                    {
                        return Ok("Successfully created the movie!");
                    }
                    return StatusCode(StatusCodes.Status500InternalServerError, "The movie wasn't created successfully.");
                }
                return BadRequest("The movie isn't valid! Please check that all properties are entered with the correct values!");
            } catch(Exception ex)
            {
                Log.Error(ex, "Error occured while creating a movie!");
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody]UpdateMovieModel movie, [FromQuery] int id) 
        {
            try
            {
                if ( movie != null )
                {
                    if (_movieService.UpdateMovie(movie, id))
                        return Ok("Update was completed successfully!");

                    return StatusCode(StatusCodes.Status500InternalServerError, "The movie wasn't updated successfully.");
                }
                return BadRequest("The movie isn't valid! Please check that all properties are entered with the correct values!");
            }catch(Exception ex)
            {
                Log.Error(ex, $"Error occured while attempting to update a movie with id: [{id}]!");
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpDelete("fromRoute/{id:int}")]
        public ActionResult DeleteFromRoute([FromRoute]int id)
        {
            try
            {
                if (id > 0)
                    if (_movieService.DeleteMovie(id))
                        return Ok("Movie was deleted successfully!");
                    else return StatusCode(StatusCodes.Status500InternalServerError, "The movie wasn't deleted successfully.");
                
                return BadRequest("Movie id must be greater than zero!");
            }catch(Exception ex)
            {
                Log.Error(ex, $"Error occured while attempting to delete a movie using [{id}]!");
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpDelete("fromBody")]
        public ActionResult DeleteFromBody([FromBody]int id)
        {
            try
            {
                if (id > 0)
                    if (_movieService.DeleteMovie(id))
                        return Ok("Movie was deleted successfully!");
                    else return StatusCode(StatusCodes.Status500InternalServerError, "The movie wasn't deleted successfully.");

                return BadRequest("Movie id must be greater than zero!");
            } catch(Exception ex)
            {
                Log.Error(ex, "Error occured while attempting to delete a movie(fromBody)!");
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
