using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access.Migrations
{
    public partial class addmigrationAddedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModiefiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9284), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9287), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9291), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9294), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9299), "A portable solId-state drive offering fast data transfer speeds and robust storage for files, games, and media.", new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9302), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9305), "A wireless speaker that connects to devices via Bluetooth, provIding portable, high-quality sound for music and calls.", new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9308), "An unmanned aerial vehicle equipped with a high-resolution camera for capturing aerial photos and vIdeos.", new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9312), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9315), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9319), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9322), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9325), "A surveillance camera system that provIdes real-time monitoring and alerts to enhance home security.", new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9328), "Headphones that reduce ambient noise, provIding an immersive audio experience for music and calls.", new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9332), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9335), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9342), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9345), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9409), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9412), 73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9425), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9429), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9431), 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9433), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9434), 63 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9437), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9438), 64 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9441), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9443), 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9445), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9446), 62 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9448), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9450), 51 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9453), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9454), 62 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9457), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9459), 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9461), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9462), 71 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9464), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9466), 72 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9468), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9469), 42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9472), "A wire-free security camera with 2K vIdeo resolution and color night vision.", new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9473), 73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9475), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9477), 68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9479), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9480), 94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9482), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9484), 92 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9487), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9488), 77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9491), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9492), 88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn", "Name", "StockQuantity" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9495), "A vIdeo doorbell with 3D motion detection and enhanced vIdeo quality.", new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9496), "Ring VIdeo Doorbell Pro 2", 43 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9556), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9562), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9564), 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9566), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9568), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9570), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9574), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9576), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9579), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9580), 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9583), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9584), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9586), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9588), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9590), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9591), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9594), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9596), 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating", "ReviewerName" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9598), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9600), 5, "DavId Jackson" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9602), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9603), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9606), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9607), 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9609), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9613), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9615), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9617), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9618), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9620), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9622), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9625), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9626), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9629), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9630), 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Comment", "CreatedOn", "ModifiedOn" },
                values: new object[] { "The Ring VIdeo Doorbell Pro 2 offers clear vIdeo and great motion detection. A must-have for home security.", new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9632), new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "FirstName", "LastName", "ModiefiedBy", "ModifiedOn", "Password", "Username" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9657), "John", "Doe", 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9659), "Passw0rd!", "jdoe123" },
                    { 2, 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9663), "Jane", "Smith", 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9664), "Qwerty1!", "jsmith456" },
                    { 3, 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9666), "Michael", "Johnson", 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9667), "Password123!", "mjohnson789" },
                    { 4, 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9669), "Emily", "Davis", 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9671), "Passw0rd!2", "edavis101" },
                    { 5, 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9673), "David", "Williams", 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9674), "Password2023!", "dwilliams202" },
                    { 6, 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9677), "Sarah", "Brown", 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9678), "SecurePass1!", "sbrown303" },
                    { 7, 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9703), "James", "Jones", 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9705), "J@mes2024", "jjones404" },
                    { 8, 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9707), "Laura", "Garcia", 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9708), "P@ssw0rd!", "lgarcia505" },
                    { 9, 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9710), "Daniel", "Martinez", 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9712), "MyP@ssw0rd", "dmartinez606" },
                    { 10, 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9715), "Jessica", "Hernandez", 1, new DateTime(2024, 9, 2, 18, 35, 7, 152, DateTimeKind.Local).AddTicks(9716), "1234Password!", "jhernandez707" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3472), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3510), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3514), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3518), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3523), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3529), "A portable solid-state drive offering fast data transfer speeds and robust storage for files, games, and media.", new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3532), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3536), "A wireless speaker that connects to devices via Bluetooth, providing portable, high-quality sound for music and calls.", new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3540), "An unmanned aerial vehicle equipped with a high-resolution camera for capturing aerial photos and videos.", new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3544), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3548), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3552), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3555), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3559), "A surveillance camera system that provides real-time monitoring and alerts to enhance home security.", new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3563), "Headphones that reduce ambient noise, providing an immersive audio experience for music and calls.", new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3566), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3570), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3575), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3578), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3582), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3613), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3615), 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3630), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3634), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3636), 23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3639), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3640), 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3643), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3645), 94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3649), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3650), 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3653), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3655), 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3658), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3659), 95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3662), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3664), 95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3668), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3669), 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3672), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3674), 27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3677), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3678), 85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3681), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3683), 28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3686), "A wire-free security camera with 2K video resolution and color night vision.", new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3687), 94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3690), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3692), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3695), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3696), 23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3699), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3700), 98 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3704), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3706), 90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3709), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3711), 79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn", "Name", "StockQuantity" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3714), "A video doorbell with 3D motion detection and enhanced video quality.", new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3715), "Ring Video Doorbell Pro 2", 62 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3752), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3754), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3757), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3758), 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3761), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3765), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3767), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3770), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3772), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3775), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3776), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3867), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3871), 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3876), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3878), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3883), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3885), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating", "ReviewerName" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3888), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3889), 2, "David Jackson" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3892), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3893), 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3896), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3898), 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3900), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3905), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3907), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3909), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3911), 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3914), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3915), 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3919), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3920), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn", "Rating" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3923), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3925), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Comment", "CreatedOn", "ModifiedOn" },
                values: new object[] { "The Ring Video Doorbell Pro 2 offers clear video and great motion detection. A must-have for home security.", new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3927), new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3929) });
        }
    }
}
