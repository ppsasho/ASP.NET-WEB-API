using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Data_Access
{
    public static class PopulateDb
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(new List<Category>()
                {
                    new()
                    {
                        Id = 1,
                        Name = "Smartphone",
                        Description = "Phone"
                    },
                    new()
                    {
                        Id = 2,
                        Name = "Tablet",
                        Description = "Phone"
                    },
                    new()
                    {
                        Id = 3,
                        Name = "PC and Hardware",
                        Description = "Different brands of computers and computer parts"
                    }
                });
            modelBuilder.Entity<Product>()
                .HasData(new List<Product>()
                {
                    new(){Id = 1, Name = "Samsung Galaxy 23", Description = "7'2 10GB RAM 256GB storage", Price = 1000, StockQuantity = 20, ImageUrl = "samsung-galaxy.png", CategoryId = 1 },
                    new(){ Id = 2, Name = "Poco X3 Pro", Description = "6'8 8GB RAM 256GB storage", Price = 1100, StockQuantity = 35, ImageUrl = "pocox3pro.png", CategoryId = 1 },
                    new(){ Id = 3, Name = "Cooler Master", Description = "16GB RAM GREAT GPU GREAT CPU", Price = 2000, StockQuantity = 15, ImageUrl = "pocox3pro.png", CategoryId = 3 }
                });
            modelBuilder.Entity<Review>()
                .HasData(new List<Review>()
                {
                    new()
                    {
                        Id= 1,
                        ReviewerName = "Sasho",
                        Comment = "Very noice",
                        Rating = 5,
                        ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fblog.hubspot.com%2Fmarketing%2Fwrite-itunes-review&psig=AOvVaw1vSOy7VyhSVJRPBEpPddjG&ust=1724350044829000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCOirp9fWhogDFQAAAAAdAAAAABAE",
                        ProductId = 1,
                    }
                });
        }
    }
}
