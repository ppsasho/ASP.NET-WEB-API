using DomainModels;

namespace DataAccess
{
    public static class StaticDb
    {
        public static List<Movie> Movies = new(); 
        public static int Id = Movies.Count < 1 ? 1 : Movies.Count + 1;
        public static int MaxId = Movies.Count;
    }
}
