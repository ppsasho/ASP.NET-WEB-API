using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModiefiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModiefiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModiefiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "ModiefiedBy", "ModifiedOn", "Name" },
                values: new object[] { 1, 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6082), "Phone", 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6109), "Smartphone" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "ModiefiedBy", "ModifiedOn", "Name" },
                values: new object[] { 2, 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6114), "Phone", 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6116), "Tablet" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "ModiefiedBy", "ModifiedOn", "Name" },
                values: new object[] { 3, 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6118), "Different brands of computers and computer parts", 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6119), "PC and Hardware" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "ImageUrl", "ModiefiedBy", "ModifiedOn", "Name", "Price", "StockQuantity" },
                values: new object[] { 1, 1, 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6142), "7'2 10GB RAM 256GB storage", "samsung-galaxy.png", 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6143), "Samsung Galaxy 23", 1000m, 20 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "ImageUrl", "ModiefiedBy", "ModifiedOn", "Name", "Price", "StockQuantity" },
                values: new object[] { 2, 1, 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6148), "6'8 8GB RAM 256GB storage", "pocox3pro.png", 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6150), "Poco X3 Pro", 1100m, 35 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "ImageUrl", "ModiefiedBy", "ModifiedOn", "Name", "Price", "StockQuantity" },
                values: new object[] { 3, 3, 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6152), "16GB RAM GREAT GPU GREAT CPU", "pocox3pro.png", 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6154), "Cooler Master", 2000m, 15 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedBy", "CreatedOn", "ImageUrl", "ModiefiedBy", "ModifiedOn", "ProductId", "Rating", "ReviewerName" },
                values: new object[] { 1, "Very noice", 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6172), "https://www.google.com/url?sa=i&url=https%3A%2F%2Fblog.hubspot.com%2Fmarketing%2Fwrite-itunes-review&psig=AOvVaw1vSOy7VyhSVJRPBEpPddjG&ust=1724350044829000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCOirp9fWhogDFQAAAAAdAAAAABAE", 1, new DateTime(2024, 8, 21, 20, 37, 27, 555, DateTimeKind.Local).AddTicks(6174), 1, 5, "Sasho" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
