using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeWheelMovieAPI.Migrations
{
    public partial class SeedingTables_update_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthdate", "IsSubscribedToNewsletter", "Name" },
                values: new object[] { 1, new DateTime(1979, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Birendra Mohanraj" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthdate", "IsSubscribedToNewsletter", "Name" },
                values: new object[] { 2, new DateTime(1973, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "John Smith" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
