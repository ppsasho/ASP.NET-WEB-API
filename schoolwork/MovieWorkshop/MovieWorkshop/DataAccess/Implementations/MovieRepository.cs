using DataAccess.Interfaces;
using DomainModels;
using DomainModels.Enums;
using DTOs;

namespace DataAccess.Implementations
{
    public class MovieRepository : IMovieRepository<Movie>
    {
        public bool Create(Movie entity)
        {
            throw new NotImplementedException();
        }
        public bool Create(CreateMovieModel entity)
        {
            Genre parsedGenre;
            if (entity != null && Enum.TryParse(entity.Genre, out parsedGenre))
            {
                int newId;
                if (StaticDb.Movies.Count < 1) newId = 1;
                    else newId = StaticDb.Movies.Max(x => x.Id) + 1;
                
                Movie newMovie = new()
                {
                    Id = newId,
                    Title = entity.Title,
                    Year = entity.Year,
                    Description = entity.Description,
                    Genre = parsedGenre,
                };

                StaticDb.Movies.Add(newMovie);
                return true;
            }
            return false;
        }

        public bool DeleteById(int id)
        {
            var movie = GetById(id);
            if (movie != null) if(StaticDb.Movies.Remove(movie)) return true;
            return false;
        }
        public List<Movie> GetAll()
        {
            return StaticDb.Movies;
        }

        public Movie GetById(int id)
        {
            if (!StaticDb.Movies.Any(x => x.Id == id)) return new Movie();
            return StaticDb.Movies.FirstOrDefault(x => x.Id == id);
        }
        public bool Update(UpdateMovieModel movie)
        {
            if(Enum.TryParse(movie.Genre, out Genre parsedGenre))
            {
                var foundMovie = StaticDb.Movies.FirstOrDefault(x => x.Id.Equals(movie.Id));
                if (foundMovie != null)
                {
                    foundMovie.Title = movie.Title;
                    foundMovie.Year = movie.Year;
                    foundMovie.Description = movie.Description;
                    foundMovie.Genre = parsedGenre;

                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
