using DataAccess;
using DomainModels;
using DomainModels.Enums;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Id = StaticDb.Id,
                    Title = movieModel.Title,
                    Description = movieModel.Description,
                    ReleaseDate = movieModel.ReleaseDate,
                    Genre = parsedGenre
                };
                return movie;
            }
            return new Movie();
        }
    }
}
