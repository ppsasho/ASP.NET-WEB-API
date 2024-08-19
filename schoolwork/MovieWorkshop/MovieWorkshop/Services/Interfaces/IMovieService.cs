using DTOs;

namespace Services.Interfaces
{
    public interface IMovieService
    {
        public List<MovieModel> GetAll();
        public MovieModel GetById(int id);
        public bool CreateMovie(CreateMovieModel movie);
        public bool UpdateMovie(UpdateMovieModel movie, int id);
        public bool DeleteMovie(int id);
        public List<MovieModel> FilterByGenreAndYear(string genre, int year);
        public List<MovieModel> FilterByYear(int year);
        public List<MovieModel> FilterByGenre(string genre);
    }
}
