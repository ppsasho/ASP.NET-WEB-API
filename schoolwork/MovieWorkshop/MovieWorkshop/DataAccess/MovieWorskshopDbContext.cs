using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class MovieWorskshopDbContext : DbContext
    {
        public MovieWorskshopDbContext(DbContextOptions options)
            : base(options){}

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            PopulateDb.Populate(modelBuilder);
        }
    }
}
