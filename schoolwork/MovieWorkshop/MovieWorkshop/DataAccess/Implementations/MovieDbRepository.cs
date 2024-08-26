using DataAccess.Interfaces;
using DomainModels;

namespace DataAccess.Implementations
{
    public class MovieDbRepository : DbRepository<Movie>, IMovieDbRepository
    {
        public MovieDbRepository(MovieWorskshopDbContext context) : base(context)
        {
        }
    }
}
