﻿// <auto-generated />
using Data_Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data_Access.Migrations
{
    [DbContext(typeof(BeverageStoreDbContext))]
    partial class BeverageStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain_Models.Beverage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Beverages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Whiskey",
                            Price = 29.99m,
                            Quantity = 10,
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Vodka",
                            Price = 19.99m,
                            Quantity = 15,
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rum",
                            Price = 24.99m,
                            Quantity = 20,
                            Type = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cola",
                            Price = 1.99m,
                            Quantity = 50,
                            Type = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "Lemonade",
                            Price = 2.49m,
                            Quantity = 30,
                            Type = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Orange Juice",
                            Price = 3.29m,
                            Quantity = 25,
                            Type = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Craft Beer",
                            Price = 5.99m,
                            Quantity = 12,
                            Type = 3
                        },
                        new
                        {
                            Id = 8,
                            Name = "Lager",
                            Price = 4.49m,
                            Quantity = 18,
                            Type = 3
                        },
                        new
                        {
                            Id = 9,
                            Name = "Ale",
                            Price = 6.49m,
                            Quantity = 22,
                            Type = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "Gin",
                            Price = 21.99m,
                            Quantity = 14,
                            Type = 1
                        },
                        new
                        {
                            Id = 11,
                            Name = "Tequila",
                            Price = 34.99m,
                            Quantity = 16,
                            Type = 1
                        },
                        new
                        {
                            Id = 12,
                            Name = "Cider",
                            Price = 4.99m,
                            Quantity = 20,
                            Type = 3
                        },
                        new
                        {
                            Id = 13,
                            Name = "Root Beer",
                            Price = 2.19m,
                            Quantity = 40,
                            Type = 2
                        },
                        new
                        {
                            Id = 14,
                            Name = "Ginger Ale",
                            Price = 2.39m,
                            Quantity = 35,
                            Type = 2
                        },
                        new
                        {
                            Id = 15,
                            Name = "Club Soda",
                            Price = 1.89m,
                            Quantity = 45,
                            Type = 2
                        },
                        new
                        {
                            Id = 16,
                            Name = "Porter",
                            Price = 5.49m,
                            Quantity = 10,
                            Type = 3
                        },
                        new
                        {
                            Id = 17,
                            Name = "Stout",
                            Price = 5.79m,
                            Quantity = 11,
                            Type = 3
                        },
                        new
                        {
                            Id = 18,
                            Name = "Pale Ale",
                            Price = 6.19m,
                            Quantity = 17,
                            Type = 3
                        },
                        new
                        {
                            Id = 19,
                            Name = "Sparkling Water",
                            Price = 1.59m,
                            Quantity = 50,
                            Type = 2
                        },
                        new
                        {
                            Id = 20,
                            Name = "Iced Tea",
                            Price = 2.29m,
                            Quantity = 30,
                            Type = 2
                        },
                        new
                        {
                            Id = 21,
                            Name = "Champagne",
                            Price = 49.99m,
                            Quantity = 8,
                            Type = 1
                        },
                        new
                        {
                            Id = 22,
                            Name = "Brandy",
                            Price = 39.99m,
                            Quantity = 9,
                            Type = 1
                        },
                        new
                        {
                            Id = 23,
                            Name = "Martini",
                            Price = 25.99m,
                            Quantity = 11,
                            Type = 1
                        },
                        new
                        {
                            Id = 24,
                            Name = "Seltzer",
                            Price = 1.79m,
                            Quantity = 55,
                            Type = 2
                        },
                        new
                        {
                            Id = 25,
                            Name = "Apple Juice",
                            Price = 2.89m,
                            Quantity = 28,
                            Type = 2
                        });
                });

            modelBuilder.Entity("Domain_Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Domain_Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BeverageId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BeverageId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Domain_Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain_Models.Order", b =>
                {
                    b.HasOne("Domain_Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain_Models.OrderItem", b =>
                {
                    b.HasOne("Domain_Models.Beverage", "Beverage")
                        .WithMany()
                        .HasForeignKey("BeverageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain_Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beverage");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Domain_Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Domain_Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
