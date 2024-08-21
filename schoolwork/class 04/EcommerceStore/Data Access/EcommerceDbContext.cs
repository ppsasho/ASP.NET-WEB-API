using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Data_Access
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext(DbContextOptions options)
            : base(options) 
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(x => x.Products)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

            modelBuilder.Entity<Product>()
                .HasMany(x => x.Reviews)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

            PopulateDb.Populate(modelBuilder);
        }

    }
}
