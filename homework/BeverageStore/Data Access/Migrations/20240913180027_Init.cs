using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Beverages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beverages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beverages_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Beverages",
                columns: new[] { "Id", "Name", "OrderId", "Price", "Quantity", "Type" },
                values: new object[,]
                {
                    { 1, "Whiskey", null, 29.99m, 10, 1 },
                    { 2, "Vodka", null, 19.99m, 15, 1 },
                    { 3, "Rum", null, 24.99m, 20, 1 },
                    { 4, "Cola", null, 1.99m, 50, 2 },
                    { 5, "Lemonade", null, 2.49m, 30, 2 },
                    { 6, "Orange Juice", null, 3.29m, 25, 2 },
                    { 7, "Craft Beer", null, 5.99m, 12, 3 },
                    { 8, "Lager", null, 4.49m, 18, 3 },
                    { 9, "Ale", null, 6.49m, 22, 3 },
                    { 10, "Gin", null, 21.99m, 14, 1 },
                    { 11, "Tequila", null, 34.99m, 16, 1 },
                    { 12, "Cider", null, 4.99m, 20, 3 },
                    { 13, "Root Beer", null, 2.19m, 40, 2 },
                    { 14, "Ginger Ale", null, 2.39m, 35, 2 },
                    { 15, "Club Soda", null, 1.89m, 45, 2 },
                    { 16, "Porter", null, 5.49m, 10, 3 },
                    { 17, "Stout", null, 5.79m, 11, 3 },
                    { 18, "Pale Ale", null, 6.19m, 17, 3 },
                    { 19, "Sparkling Water", null, 1.59m, 50, 2 },
                    { 20, "Iced Tea", null, 2.29m, 30, 2 },
                    { 21, "Champagne", null, 49.99m, 8, 1 },
                    { 22, "Brandy", null, 39.99m, 9, 1 },
                    { 23, "Martini", null, 25.99m, 11, 1 },
                    { 24, "Seltzer", null, 1.79m, 55, 2 },
                    { 25, "Apple Juice", null, 2.89m, 28, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beverages_OrderId",
                table: "Beverages",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beverages");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
