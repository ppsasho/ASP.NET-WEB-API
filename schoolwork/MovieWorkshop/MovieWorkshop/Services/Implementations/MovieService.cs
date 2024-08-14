using DataAccess;
using DataAccess.Implementations;
using DomainModels;
using DomainModels.Enums;
using DTOs;
using Services.Interfaces;

namespace Services.Implementations
{
    public class MovieService : IMovieService
    {
        private MovieRepository _movieRepository;
        public List<Movie> GetAll()
        {
            _movieRepository.GetAll();
        }
        public Movie GetById(int id)
        {
            return _movieRepository.GetById(id);
        }
        //public List<Movie> FilterByGenreAndYear(string genre, int year)
        //public List<Movie> FilterByYear(int year)
        //public List<Movie> FilterByGenre(string genre)
        public List<Movie> FilterByGenreAndYear(string genre, int year)
        {
            //if (genre == null && year == null) return new List<Movie>(); check for controller
            if (Enum.TryParse(genre, out Genre parsedGenre))
                return StaticDb.Movies.Where(x => x.Genre == parsedGenre && x.Year == year).ToList();
            return new List<Movie>();
        }
        public List<Movie> FilterByYear(int year) => StaticDb.Movies.Where(x => x.Year.Equals(year)).ToList();
        public List<Movie> FilterByGenre(string genre)
        {
           if (Enum.TryParse(genre, out Genre parsedGenre)) return StaticDb.Movies.Where(x => x.Genre.Equals(parsedGenre)).ToList();
           return new List<Movie>();
        }
        public bool CreateMovie (CreateMovieModel movie)
        {
            if(_movieRepository.Create(movie)) return true;
            return false;
        }
        public bool Update(UpdateMovieModel movie) 
        {
            if(_movieRepository.Update(movie)) return true;
            return false;
        }
    }
}
