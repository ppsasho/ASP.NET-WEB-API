using DataAccess.Interfaces;
using DomainModels;
using DomainModels.Enums;
using DTOs;

namespace DataAccess.Implementations
{
    public class MovieRepository : IRepository<Movie>
    {
        public bool Add(Movie entity)
        {
            throw new NotImplementedException();
        }

        public bool Create(Movie movie)
        {
            StaticDb.Movies.Add(movie);
            return true;
        }

        public bool DeleteById(int id)
        {
            return StaticDb.Movies.Remove(GetById(id));
        }

        public List<Movie> GetAll()
        {
            return StaticDb.Movies;
        }

        public Movie GetById(int id)
        {
            return StaticDb.Movies.FirstOrDefault(x => x.Id.Equals(id));
        }

        public bool Update(Movie movie)
        {
            var foundIndex = StaticDb.Movies.FindIndex(x => x.Id.Equals(movie.Id));
            if (foundIndex >= 0)
            {
                StaticDb.Movies[foundIndex] = movie;
                return true;
            }
            return false;
        }

        IEnumerable<Movie> IRepository<Movie>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
