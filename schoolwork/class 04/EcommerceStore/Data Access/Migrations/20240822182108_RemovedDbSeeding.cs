using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access.Migrations
{
    public partial class RemovedDbSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
