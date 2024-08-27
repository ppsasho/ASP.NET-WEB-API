using DataAccess;
using DomainModels;
using DomainModels.Enums;
using DTOs;

namespace Mappers
{
    public static class CreateMovieMapper
    {
        public static Movie ToModel(this CreateMovieModel movieModel)
        {
            if (Enum.TryParse(movieModel.Genre, out Genre parsedGenre)) 
            {
                Movie movie = new()
                {
                    Title = movieModel.Title,
                    Year = movieModel.Year,
                    Description = movieModel.Description,
                    Genre = parsedGenre
                };
                return movie;
            }
            return new Movie();
        }
    }
}
