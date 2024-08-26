using DataAccess.Interfaces;
using DomainModels.Enums;
using DTOs;
using Mappers;
using Services.Interfaces;
using static Mappers.MovieMapper;

namespace Services.Implementations
{
    public class MovieService : IMovieService
    {
        private readonly IMovieDbRepository _movieRepository;
        public MovieService(IMovieDbRepository movieRepository) 
        {
            _movieRepository = movieRepository;
        }
        public List<MovieModel> GetAll() => _movieRepository.GetAll().Select(x => x.ToModel()).ToList();
        public MovieModel GetById(int id) => _movieRepository.GetById(id).ToModel();
       
        public List<MovieModel> FilterByGenreAndYear(string? genre, int? year)
        {
            if (Enum.TryParse(genre, out Genre parsedGenre))
                return _movieRepository.GetAll()
                                       .Where(x => x.Genre == parsedGenre && x.Year == year)
                                       .Select(x => x.ToModel()).ToList();

            return new List<MovieModel>();
        }
        public List<MovieModel> FilterByYear(int? year) => _movieRepository.GetAll()
                                                                          .Where(x => x.Year.Equals(year))
                                                                          .Select(x => x.ToModel()).ToList();
        public List<MovieModel> FilterByGenre(string? genre)
        {
           if (Enum.TryParse(genre, out Genre parsedGenre)) return _movieRepository.GetAll()
                                                                                   .Where(x => x.Genre.Equals(parsedGenre))
                                                                                   .Select(x => x.ToModel()).ToList();
            return new List<MovieModel>();
        }
        public bool CreateMovie (CreateMovieModel movie)
        {
            var newMovie = movie.ToModel();
            return _movieRepository.Add(newMovie);
        }
        public bool UpdateMovie(UpdateMovieModel movie, int id)
        {
            if(Enum.TryParse(movie.Genre, out Genre parsedGenre) && movie != null)
            {
                var foundMovie = _movieRepository.GetById(id);
                if(foundMovie != null)
                {
                    foundMovie.Title = movie.Title;
                    foundMovie.Year = movie.Year;
                    foundMovie.Description = movie.Description;
                    foundMovie.Genre = parsedGenre;
                }
                return true;
            }
            return false;
        }

        public bool DeleteMovie(int id)
        {
            return _movieRepository.DeleteById(id);
        }
    }
}
