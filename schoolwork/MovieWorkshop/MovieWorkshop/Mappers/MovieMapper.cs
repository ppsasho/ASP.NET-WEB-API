using DomainModels;
using DTOs;

namespace Mappers
{
    public static class MovieMapper
    {
        public static MovieModel ToModel(this Movie movie)
        {
            var movieModel = new MovieModel()
            {
                Title = movie.Title,
                Description = movie.Description,
                Genre = movie.Genre.ToString(),
                Year = movie.Year,
            };
            return movieModel;
        }
    }
}
