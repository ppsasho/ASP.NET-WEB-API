using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddedUsers : Migration
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 18, 34, 52, 363, DateTimeKind.Local).AddTicks(8487));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8569));
        }
    }
}
