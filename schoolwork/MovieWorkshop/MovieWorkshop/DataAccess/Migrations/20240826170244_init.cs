using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedOn", "Description", "Genre", "ReleaseDate", "Title", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8617), "An epic story of bravery and courage.", 2, new DateTime(2007, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mystery Unveiled", 2007 },
                    { 2, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8620), "A mysterious journey into the unknown.", 7, new DateTime(2015, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Journey Beyond", 2015 },
                    { 3, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8624), "A tale of love and loss.", 5, new DateTime(2018, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love's Echo", 2018 },
                    { 4, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8626), "A gripping narrative that will keep you on the edge of your seat.", 6, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Time Chronicles", 2020 },
                    { 5, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8630), "An epic tale of myth and legend.", 9, new DateTime(2013, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fallen Legends", 2013 },
                    { 6, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8632), "A journey to the edge of the world.", 7, new DateTime(2010, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last Frontier", 2010 },
                    { 7, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8633), "A spine-chilling tale of suspense.", 11, new DateTime(2019, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haunting Shadows", 2019 },
                    { 8, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8636), "A story of dreams and aspirations.", 12, new DateTime(2016, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rising Stars", 2016 },
                    { 9, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8639), "An adventure into an ancient world.", 4, new DateTime(2011, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Forgotten Realm", 2011 },
                    { 10, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8641), "A dark thriller that will keep you guessing.", 2, new DateTime(2014, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eternal Night", 2014 },
                    { 11, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8643), "A story of wild adventures and untamed spirits.", 3, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wild Hearts", 2021 },
                    { 12, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8645), "A touching tale of romance and heartache.", 5, new DateTime(2008, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love's Journey", 2008 },
                    { 13, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8647), "A futuristic vision of technology and society.", 6, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Techno Dreams", 2022 },
                    { 14, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8649), "A story about love and friendship.", 3, new DateTime(2017, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Broken Hearts Club", 2017 },
                    { 15, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8652), "A high-octane action film.", 9, new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Action Heroes", 2019 },
                    { 16, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8655), "A drama set against the backdrop of a bustling city.", 1, new DateTime(2018, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "City Lights", 2018 },
                    { 17, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8659), "A tale of ancient prophecies and forgotten lands.", 4, new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ancient Prophecies", 2010 },
                    { 18, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8661), "An exploration of mystical lands and hidden secrets.", 7, new DateTime(2016, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mystic Lands", 2016 },
                    { 19, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8663), "A magical tale of dreamers and their dreams.", 4, new DateTime(2014, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dreamweavers", 2014 },
                    { 20, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8665), "A chilling horror story with unexpected twists.", 11, new DateTime(2011, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Haunting", 2011 },
                    { 21, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8667), "An adventurous journey through uncharted territories.", 7, new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uncharted Paths", 2022 },
                    { 22, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8670), "A drama about the pursuit of dreams in a vibrant city.", 1, new DateTime(2017, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "City of Dreams", 2017 },
                    { 23, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8672), "A sci-fi epic exploring the final frontiers of space.", 6, new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Final Frontier", 2015 },
                    { 24, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8674), "A historical drama that uncovers echoes of the past.", 1, new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Echoes of the Past", 2021 },
                    { 25, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8676), "A comedic drama filled with laughter and tears.", 3, new DateTime(2013, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laughs and Tears", 2013 },
                    { 26, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8678), "A horror film that brings nightmares to life.", 11, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horror Unleashed", 2020 },
                    { 27, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8680), "A science fiction saga set among the stars.", 6, new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Voyagers", 2019 },
                    { 28, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8682), "An adventurous quest in a lost world.", 7, new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lost World", 2023 },
                    { 29, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8684), "A classic tale of a hero's journey and personal growth.", 9, new DateTime(2018, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hero's Journey", 2018 },
                    { 30, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8686), "A romantic musical that captures the dance of love.", 12, new DateTime(2012, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dance of Hearts", 2012 },
                    { 31, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8688), "A fantasy film based on old legends and tales.", 4, new DateTime(2015, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tales of Old", 2015 },
                    { 32, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8690), "A high-stakes action thriller.", 9, new DateTime(2014, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Great Escape", 2014 },
                    { 33, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8692), "A touching drama about love and relationships.", 1, new DateTime(2017, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heartstrings", 2017 },
                    { 34, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8694), "A thrilling science fiction adventure.", 6, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alien Invasion", 2021 },
                    { 35, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8696), "An adventurous journey into the wilderness.", 7, new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilderness Quest", 2020 },
                    { 36, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8698), "A dramatic tale set in the dawn of a new era.", 1, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rising Sun", 2023 },
                    { 37, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8700), "A hilarious comedy about misunderstandings and mishaps.", 3, new DateTime(2018, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comedy of Errors", 2018 },
                    { 90, new DateTime(2024, 8, 26, 19, 2, 44, 486, DateTimeKind.Local).AddTicks(8569), "A thrilling adventure into the unknown.", 4, new DateTime(2012, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Echo of Dreams", 2012 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
