using EcommerceStoreAPI.Models;
using System.Xml.Linq;

namespace EcommerceStoreAPI.Data
{
    public static class StaticDb
    {
        public static List<Category> Categories = new()
        {
            new()
            {
                Id= 1,
                Name = "Smartphone"

            },
            new()
            {
                Id = 2,
                Name = "Tablet"
            },
            new()
            {
                Id = 3,
                Name = "PC and Hardware",
                Description = "Different brands of computers and computer parts"
            }
        };
        public static List<Product> Products = new()
        {
            new(){ Id = 1, Name = "Samsung Galaxy 23", Description = "7'2 10GB RAM 256GB storage", Price = 1000, StockQuantity = 20, ImageUrl = "samsung-galaxy.png", CategoryId = 1, Category = Categories.Where(x=>x.Id.Equals(1)).SingleOrDefault() },
            new(){ Id = 2, Name = "Poco X3 Pro", Description = "6'8 8GB RAM 256GB storage", Price = 1100, StockQuantity = 35, ImageUrl = "pocox3pro.png", CategoryId = 1, Category = Categories.Where(x=>x.Id.Equals(1)).SingleOrDefault() },
            new(){ Id = 2, Name = "Cooler Master", Description = "16GB RAM GREAT GPU GREAT CPU", Price = 2000, StockQuantity = 15, ImageUrl = "pocox3pro.png", CategoryId = 3, Category = Categories.Where(x=>x.Id.Equals(3)).SingleOrDefault() }
        };

    }
}
