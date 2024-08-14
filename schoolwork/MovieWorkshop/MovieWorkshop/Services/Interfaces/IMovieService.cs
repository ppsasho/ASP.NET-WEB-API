using DomainModels;
using DTOs;

namespace Services.Interfaces
{
    public interface IMovieService
    {
        public List<Movie> GetAll();
        public Movie GetById(int id);
        public List<Movie> FilterByGenreAndYear(string genre, int year);
        public bool CreateMovie(CreateMovieModel movie);
        public List<Movie> FilterByYear(int year);
        public List<Movie> FilterByGenre(string genre);
    }
}
