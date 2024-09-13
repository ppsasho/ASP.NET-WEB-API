using Domain_Models;
using Domain_Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace Data_Access
{
    public static class PopulateDb
    {
        public static void Populate(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Beverage>()
                .HasData(new List<Beverage>() 
                {
                    new Beverage { Id = 1, Name = "Whiskey", Type = BeverageType.Alcohol, Quantity = 10, Price = 29.99m },
                    new Beverage { Id = 2, Name = "Vodka", Type = BeverageType.Alcohol, Quantity = 15, Price = 19.99m },
                    new Beverage { Id = 3, Name = "Rum", Type = BeverageType.Alcohol, Quantity = 20, Price = 24.99m },
                    new Beverage { Id = 4, Name = "Cola", Type = BeverageType.Soft_Drink, Quantity = 50, Price = 1.99m },
                    new Beverage { Id = 5, Name = "Lemonade", Type = BeverageType.Soft_Drink, Quantity = 30, Price = 2.49m },
                    new Beverage { Id = 6, Name = "Orange Juice", Type = BeverageType.Soft_Drink, Quantity = 25, Price = 3.29m },
                    new Beverage { Id = 7, Name = "Craft Beer", Type = BeverageType.Beer, Quantity = 12, Price = 5.99m },
                    new Beverage { Id = 8, Name = "Lager", Type = BeverageType.Beer, Quantity = 18, Price = 4.49m },
                    new Beverage { Id = 9, Name = "Ale", Type = BeverageType.Beer, Quantity = 22, Price = 6.49m },
                    new Beverage { Id = 10, Name = "Gin", Type = BeverageType.Alcohol, Quantity = 14, Price = 21.99m },
                    new Beverage { Id = 11, Name = "Tequila", Type = BeverageType.Alcohol, Quantity = 16, Price = 34.99m },
                    new Beverage { Id = 12, Name = "Cider", Type = BeverageType.Beer, Quantity = 20, Price = 4.99m },
                    new Beverage { Id = 13, Name = "Root Beer", Type = BeverageType.Soft_Drink, Quantity = 40, Price = 2.19m },
                    new Beverage { Id = 14, Name = "Ginger Ale", Type = BeverageType.Soft_Drink, Quantity = 35, Price = 2.39m },
                    new Beverage { Id = 15, Name = "Club Soda", Type = BeverageType.Soft_Drink, Quantity = 45, Price = 1.89m },
                    new Beverage { Id = 16, Name = "Porter", Type = BeverageType.Beer, Quantity = 10, Price = 5.49m },
                    new Beverage { Id = 17, Name = "Stout", Type = BeverageType.Beer, Quantity = 11, Price = 5.79m },
                    new Beverage { Id = 18, Name = "Pale Ale", Type = BeverageType.Beer, Quantity = 17, Price = 6.19m },
                    new Beverage { Id = 19, Name = "Sparkling Water", Type = BeverageType.Soft_Drink, Quantity = 50, Price = 1.59m },
                    new Beverage { Id = 20, Name = "Iced Tea", Type = BeverageType.Soft_Drink, Quantity = 30, Price = 2.29m },
                    new Beverage { Id = 21, Name = "Champagne", Type = BeverageType.Alcohol, Quantity = 8, Price = 49.99m },
                    new Beverage { Id = 22, Name = "Brandy", Type = BeverageType.Alcohol, Quantity = 9, Price = 39.99m },
                    new Beverage { Id = 23, Name = "Martini", Type = BeverageType.Alcohol, Quantity = 11, Price = 25.99m },
                    new Beverage { Id = 24, Name = "Seltzer", Type = BeverageType.Soft_Drink, Quantity = 55, Price = 1.79m },
                    new Beverage { Id = 25, Name = "Apple Juice", Type = BeverageType.Soft_Drink, Quantity = 28, Price = 2.89m }
                }
                );
        }
    }
}
