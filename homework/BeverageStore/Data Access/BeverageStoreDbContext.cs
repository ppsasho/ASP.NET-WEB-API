using Domain_Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Data_Access
{
    public class BeverageStoreDbContext : DbContext
    {
        public BeverageStoreDbContext(DbContextOptions options)
            : base(options) { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<CustomAttributeData>();

            modelBuilder.Entity<User>()
                .Property(x => x.LastName)
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .Property(x => x.FirstName)
                .HasMaxLength(50);
            
            PopulateDb.Populate(modelBuilder);
        }
    }
}
