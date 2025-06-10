using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoListWebApi.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "CreatedDate", "Description", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 27, 14, 35, 24, 183, DateTimeKind.Utc).AddTicks(3064), "Milk, Bread, Eggs", "Buy groceries" },
                    { 2, new DateTime(2025, 5, 27, 14, 35, 24, 183, DateTimeKind.Utc).AddTicks(3436), "Read C# in Depth", "Read book" },
                    { 3, new DateTime(2025, 5, 27, 14, 35, 24, 183, DateTimeKind.Utc).AddTicks(3437), "Cook daal. Make sure I have all ingredients", "Make a meal" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
