using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeWheelMovieAPI.Migrations
{
    public partial class SeedingTables_update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 22, 2, 31, 27, 100, DateTimeKind.Local).AddTicks(4071), new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7779), new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7797), new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7804), new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7808), new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7815), new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7819), new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7826), new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7830), new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7837), new DateTime(2019, 5, 22, 2, 31, 27, 102, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.InsertData(
                table: "UserMovieRatings",
                columns: new[] { "Id", "MovieId", "RatingStars", "UserId" },
                values: new object[,]
                {
                    { 15, 8, 5, 1 },
                    { 14, 9, 3, 1 },
                    { 13, 10, 2, 10 },
                    { 12, 10, 3, 1 },
                    { 11, 6, 5, 2 },
                    { 6, 2, 1, 1 },
                    { 9, 1, 3, 2 },
                    { 8, 4, 4, 1 },
                    { 7, 3, 2, 1 },
                    { 16, 6, 3, 7 },
                    { 10, 5, 3, 2 },
                    { 17, 4, 5, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserMovieRatings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 18, 23, 29, 47, 796, DateTimeKind.Local).AddTicks(7777), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5502), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5516), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5523), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5531), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5534), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5542), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5545), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5553), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5556), new DateTime(2019, 5, 18, 23, 29, 47, 800, DateTimeKind.Local).AddTicks(5560) });
        }
    }
}
