using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_EF_SQLite.Migrations
{
    /// <inheritdoc />
    public partial class populandotabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CashFlow",
                columns: new[] { "Id", "Date", "Type", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1000m },
                    { 2, new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1000m },
                    { 3, new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 900m },
                    { 4, new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1000m },
                    { 5, new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2000m },
                    { 6, new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100m },
                    { 7, new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 90m },
                    { 8, new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CashFlow",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CashFlow",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CashFlow",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CashFlow",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CashFlow",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CashFlow",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CashFlow",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CashFlow",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
