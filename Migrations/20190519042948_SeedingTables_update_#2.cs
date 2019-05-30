using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeWheelMovieAPI.Migrations
{
    public partial class SeedingTables_update_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movies");

            migrationBuilder.AlterColumn<int>(
                name: "RatingStars",
                table: "UserMovieRatings",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2, 1)");

            migrationBuilder.AddColumn<decimal>(
                name: "AverageRating",
                table: "Movies",
                type: "decimal(2, 1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 15, "Romance" },
                    { 14, "Mystery" },
                    { 13, "Musical" },
                    { 12, "Horror" },
                    { 11, "History" },
                    { 9, "Family" },
                    { 10, "Fantasy" },
                    { 7, "Documentary" },
                    { 6, "Crime" },
                    { 5, "Comedy" },
                    { 4, "Biography" },
                    { 3, "Animation" },
                    { 2, "Adventure" },
                    { 8, "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "AverageRating", "CountryReleased", "DateAdded", "DateModified", "Language", "NumberAvailable", "NumberInStock", "ReleaseYear", "Runningtime", "Title" },
                values: new object[,]
                {
                    { 7, 8.1m, "Germany", new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5542), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5545), "English", (byte)10, (byte)2, 2018, 183, "Spider-Man: Far from Home" },
                    { 10, 4.1m, "USA", new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5556), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5560), "English", (byte)10, (byte)9, 2018, 145, "Top Gun: Maverick" },
                    { 9, 8.7m, "USA", new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5553), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5553), "English", (byte)10, (byte)3, 2018, 198, "Star Wars" },
                    { 8, 3.1m, "USA", new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5545), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5549), "English", (byte)10, (byte)9, 2018, 147, "The New Mutants" },
                    { 6, 4.1m, "USA", new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5534), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5538), "English", (byte)10, (byte)9, 2018, 123, "Dark Phoenix" },
                    { 2, 7.1m, "USA", new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5502), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5509), "English", (byte)10, (byte)7, 2019, 123, "Captain Marvel" },
                    { 4, 5.1m, "USA", new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5523), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5527), "English", (byte)10, (byte)8, 2019, 89, "Toy Story 4" },
                    { 3, 7.5m, "USA", new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5516), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5520), "English", (byte)10, (byte)6, 2019, 132, "Shazam" },
                    { 1, 8.9m, "USA", new DateTime(2019, 5, 18, 23, 29, 47, 796, DateTimeKind.Local).AddTicks(7777), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(4929), "English", (byte)10, (byte)1, 2019, 181, "Avengers: EndGame" },
                    { 5, 7.1m, "United Kingdom", new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5531), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5531), "English", (byte)10, (byte)4, 2019, 131, "Godzilla: King of the Monsters" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthdate", "IsSubscribedToNewsletter", "Name" },
                values: new object[,]
                {
                    { 9, new DateTime(1978, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "John Pickering" },
                    { 3, new DateTime(1970, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Adam Johnson" },
                    { 4, new DateTime(1987, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Emilio Venegas" },
                    { 5, new DateTime(1965, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Lee Yelverton" },
                    { 6, new DateTime(1983, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Alan Appleton" },
                    { 7, new DateTime(1976, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Michael Chang" },
                    { 8, new DateTime(1963, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Anthony Paul" },
                    { 10, new DateTime(1993, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Scott Tiger" }
                });

            migrationBuilder.InsertData(
                table: "MovieGenres",
                columns: new[] { "Id", "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 21, 12, 10 },
                    { 20, 11, 10 },
                    { 19, 15, 9 },
                    { 18, 14, 8 },
                    { 17, 13, 7 },
                    { 16, 15, 6 },
                    { 15, 2, 6 },
                    { 14, 1, 6 },
                    { 13, 10, 5 },
                    { 12, 2, 5 },
                    { 11, 1, 5 },
                    { 9, 3, 4 },
                    { 8, 2, 4 },
                    { 7, 5, 3 },
                    { 6, 2, 3 },
                    { 5, 1, 3 },
                    { 4, 2, 2 },
                    { 3, 1, 2 },
                    { 2, 2, 1 },
                    { 10, 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "UserMovieRatings",
                columns: new[] { "Id", "MovieId", "RatingStars", "UserId" },
                values: new object[,]
                {
                    { 4, 1, 5, 4 },
                    { 2, 2, 4, 2 },
                    { 1, 1, 5, 1 },
                    { 3, 1, 4, 3 },
                    { 5, 1, 4, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "AverageRating",
                table: "Movies");

            migrationBuilder.AlterColumn<decimal>(
                name: "RatingStars",
                table: "UserMovieRatings",
                type: "decimal(2, 1)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ReleaseDate",
                table: "Movies",
                nullable: false,
                defaultValue: 0);
        }
    }
}
