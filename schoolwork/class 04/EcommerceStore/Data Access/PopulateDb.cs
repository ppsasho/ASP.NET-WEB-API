using DomainModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data_Access
{
    public static class PopulateDb
    {
        private readonly static Random random = new Random();
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(new List<Category>
                        {
                            new Category { Id = 1, Name = "Smartwatch", Description = "A wearable device that combines fitness tracking, smartphone notifications, and various apps in a compact form." },
                            new Category { Id = 2, Name = "Wireless Earbuds", Description = "Compact, wireless in-ear headphones offering high-quality audio and noise cancellation features." },
                            new Category { Id = 3, Name = "Gaming Laptop", Description = "High-performance portable computer optimized for gaming, featuring powerful processors, GPUs, and high refresh rate displays." },
                            new Category { Id = 4, Name = "4K Monitor", Description = "A display screen offering ultra-high-definition resolution for sharper, more detailed visuals in gaming, work, or media." },
                            new Category { Id = 5, Name = "Virtual Reality Headset", Description = "A head-mounted device that immerses users in a 3D virtual environment for gaming, simulations, and entertainment." },
                            new Category { Id = 6, Name = "External SSD", Description = "A portable solid-state drive offering fast data transfer speeds and robust storage for files, games, and media." },
                            new Category { Id = 7, Name = "Smart Home Hub", Description = "A central device that connects and controls various smart home products like lights, thermostats, and security systems." },
                            new Category { Id = 8, Name = "Bluetooth Speaker", Description = "A wireless speaker that connects to devices via Bluetooth, providing portable, high-quality sound for music and calls." },
                            new Category { Id = 9, Name = "Drone with Camera", Description = "An unmanned aerial vehicle equipped with a high-resolution camera for capturing aerial photos and videos." },
                            new Category { Id = 10, Name = "Smart Thermostat", Description = "A programmable thermostat that adjusts heating and cooling based on user preferences and can be controlled remotely." },
                            new Category { Id = 11, Name = "E-Reader", Description = "A portable device designed for reading digital books and magazines, featuring a paper-like display and long battery life." },
                            new Category { Id = 12, Name = "Wireless Charging Pad", Description = "A device that charges smartphones and other gadgets wirelessly through inductive charging technology." },
                            new Category { Id = 13, Name = "Fitness Tracker", Description = "A wearable device that monitors physical activity, heart rate, sleep patterns, and other health metrics." },
                            new Category { Id = 14, Name = "Home Security Camera", Description = "A surveillance camera system that provides real-time monitoring and alerts to enhance home security." },
                            new Category { Id = 15, Name = "Noise-Cancelling Headphones", Description = "Headphones that reduce ambient noise, providing an immersive audio experience for music and calls." },
                            new Category { Id = 16, Name = "Smart Light Bulb", Description = "An energy-efficient light bulb that can be controlled remotely, with options for color and brightness adjustments." },
                            new Category { Id = 17, Name = "Portable Power Bank", Description = "A compact, rechargeable battery pack used to charge smartphones, tablets, and other devices on the go." },
                            new Category { Id = 18, Name = "Robot Vacuum Cleaner", Description = "An autonomous vacuum cleaner that navigates and cleans floors with minimal user input." },
                            new Category { Id = 19, Name = "3D Printer", Description = "A machine that creates three-dimensional objects by layering material based on digital models." },
                            new Category { Id = 20, Name = "Smart Doorbell", Description = "A doorbell with an integrated camera that allows users to see and communicate with visitors remotely." }
                        }
                );
            modelBuilder.Entity<Product>()
                .HasData(new List<Product>
                                {
                    new Product { Id = 1, Name = "Apple Watch Series 7", Description = "The latest smartwatch with advanced fitness tracking and seamless iPhone integration.", Price = 399.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 1 },
                    new Product { Id = 2, Name = "Sony WF-1000XM4", Description = "Premium wireless earbuds with industry-leading noise cancellation.", Price = 279.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 2 },
                    new Product { Id = 3, Name = "ASUS ROG Zephyrus G14", Description = "A powerful gaming laptop with AMD Ryzen 9 processor and RTX 3060 graphics.", Price = 1499.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 3 },
                    new Product { Id = 4, Name = "Dell UltraSharp 27 4K Monitor", Description = "A 27-inch monitor with stunning 4K resolution and ultra-thin bezels.", Price = 699.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 4 },
                    new Product { Id = 5, Name = "Oculus Quest 2", Description = "A standalone VR headset offering an immersive gaming experience without needing a PC.", Price = 299.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 5 },
                    new Product { Id = 6, Name = "Samsung T7 Portable SSD", Description = "A fast and durable external SSD with up to 1TB of storage.", Price = 169.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 6 },
                    new Product { Id = 7, Name = "Amazon Echo Show 10", Description = "A smart display that connects and controls your smart home devices with a rotating screen.", Price = 249.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 7 },
                    new Product { Id = 8, Name = "JBL Flip 5", Description = "A waterproof Bluetooth speaker offering powerful sound in a portable form.", Price = 119.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 8 },
                    new Product { Id = 9, Name = "DJI Mavic Air 2", Description = "A compact drone with a 4K camera and intelligent flight modes.", Price = 799.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 9 },
                    new Product { Id = 10, Name = "Nest Learning Thermostat", Description = "A smart thermostat that learns your schedule and programs itself to save energy.", Price = 249.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 10 },
                    new Product { Id = 11, Name = "Kindle Paperwhite", Description = "An e-reader with a high-resolution display and built-in adjustable light.", Price = 129.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 11 },
                    new Product { Id = 12, Name = "Anker Wireless Charging Pad", Description = "A sleek and efficient wireless charger compatible with Qi-enabled devices.", Price = 29.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 12 },
                    new Product { Id = 13, Name = "Fitbit Charge 5", Description = "An advanced fitness tracker with built-in GPS, heart rate monitoring, and stress management tools.", Price = 179.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 13 },
                    new Product { Id = 14, Name = "Arlo Pro 4 Security Camera", Description = "A wire-free security camera with 2K video resolution and color night vision.", Price = 199.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 14 },
                    new Product { Id = 15, Name = "Bose QuietComfort 45", Description = "Over-ear headphones with exceptional noise cancellation and premium sound quality.", Price = 329.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 15 },
                    new Product { Id = 16, Name = "Philips Hue Smart Bulb", Description = "A color-changing smart light bulb that can be controlled via app or voice commands.", Price = 49.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 16 },
                    new Product { Id = 17, Name = "Anker PowerCore 10000", Description = "A compact and powerful power bank capable of charging your devices multiple times.", Price = 39.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 17 },
                    new Product { Id = 18, Name = "iRobot Roomba i7+", Description = "A smart vacuum cleaner that empties itself and can be scheduled for automatic cleaning.", Price = 599.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 18 },
                    new Product { Id = 19, Name = "Creality Ender 3 V2", Description = "An affordable and reliable 3D printer for beginners and hobbyists.", Price = 259.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 19 },
                    new Product { Id = 20, Name = "Ring Video Doorbell Pro 2", Description = "A video doorbell with 3D motion detection and enhanced video quality.", Price = 249.99M, StockQuantity = random.Next(1, 101), ImageUrl = "", CategoryId = 20 }
                });
            modelBuilder.Entity<Review>()
                .HasData(new List<Review>
                        {
                            new Review { Id = 1, ReviewerName = "John Doe", Comment = "The Apple Watch Series 7 has been a game-changer for tracking my workouts.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 1 },
                            new Review { Id = 2, ReviewerName = "Jane Smith", Comment = "The noise cancellation on the Sony WF-1000XM4 is amazing. Perfect for commuting!", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 2 },
                            new Review { Id = 3, ReviewerName = "Alex Johnson", Comment = "The ASUS ROG Zephyrus G14 runs all my games smoothly. Best gaming laptop I've owned!", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 3 },
                            new Review { Id = 4, ReviewerName = "Emily Brown", Comment = "The Dell UltraSharp 27 4K Monitor has stunning visuals, perfect for my design work.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 4 },
                            new Review { Id = 5, ReviewerName = "Michael Davis", Comment = "The Oculus Quest 2 is incredibly immersive. My favorite VR headset so far.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 5 },
                            new Review { Id = 6, ReviewerName = "Sarah Wilson", Comment = "The Samsung T7 Portable SSD is super fast. Makes transferring files a breeze.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 6 },
                            new Review { Id = 7, ReviewerName = "Chris Martinez", Comment = "The Echo Show 10 is a great smart home hub. The rotating screen is very handy.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 7 },
                            new Review { Id = 8, ReviewerName = "Jessica Taylor", Comment = "The JBL Flip 5 delivers excellent sound quality, especially for its size.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 8 },
                            new Review { Id = 9, ReviewerName = "Daniel Anderson", Comment = "The DJI Mavic Air 2 captures stunning aerial footage. Easy to fly as well.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 9 },
                            new Review { Id = 10, ReviewerName = "Sophia Thomas", Comment = "The Nest Learning Thermostat saved me on energy bills. Love the automation features.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 10 },
                            new Review { Id = 11, ReviewerName = "David Jackson", Comment = "The Kindle Paperwhite is perfect for reading on the go. The screen is very clear.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 11 },
                            new Review { Id = 12, ReviewerName = "Olivia Moore", Comment = "The Anker Wireless Charging Pad is a convenient way to charge my phone. Works great.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 12 },
                            new Review { Id = 13, ReviewerName = "Liam Harris", Comment = "The Fitbit Charge 5 has helped me stay on top of my fitness goals. Love the new features.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 13 },
                            new Review { Id = 14, ReviewerName = "Ava Martinez", Comment = "The Arlo Pro 4 Security Camera gives me peace of mind. Easy to set up and use.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 14 },
                            new Review { Id = 15, ReviewerName = "Noah Robinson", Comment = "The Bose QuietComfort 45 are the best noise-cancelling headphones I've tried.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 15 },
                            new Review { Id = 16, ReviewerName = "Isabella Clark", Comment = "The Philips Hue Smart Bulb adds a lot of ambiance to my room. The color options are great.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 16 },
                            new Review { Id = 17, ReviewerName = "Mason Rodriguez", Comment = "The Anker PowerCore 10000 is a lifesaver on long trips. Charges my devices multiple times.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 17 },
                            new Review { Id = 18, ReviewerName = "Mia Lewis", Comment = "The iRobot Roomba i7+ keeps my floors clean without any effort. I love the self-emptying feature.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 18 },
                            new Review { Id = 19, ReviewerName = "Ethan Walker", Comment = "The Creality Ender 3 V2 is perfect for my 3D printing projects. Easy to assemble and use.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 19 },
                            new Review { Id = 20, ReviewerName = "Charlotte Hill", Comment = "The Ring Video Doorbell Pro 2 offers clear video and great motion detection. A must-have for home security.", Rating = random.Next(1, 6), ImageUrl = "", ProductId = 20 }
                        });
        }
    }
}
