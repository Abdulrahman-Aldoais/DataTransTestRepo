using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataTransTest.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "FirstName", "LastName", "Phone", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "sanaa", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(5142), "adffaf@gmail.com", "ahmeed", "ali", "454646464", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(5138) },
                    { 2, "sanaa", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(5146), "ssd2af@gmail.com", "salah", "ali", "454646464", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(5144) },
                    { 3, "sanaa", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(5149), "example1@gmail.com", "hany", "abdu", "123456789", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(5148) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "FirstName", "LastName", "Phone", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "sanaa", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9889), "adffaf@gmail.com", "علي", "الدعيس", "454646464", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9886) },
                    { 2, "sanaa", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9895), "ssd2af@gmail.com", "سعيد", "صالح", "454646464", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9893) },
                    { 3, "sanaa", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9898), "example1@gmail.com", "محمد", "خالد", "123456789", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9897) },
                    { 4, "sanaa", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9901), "example2@gmail.com", "فاطمة", "علي", "987654321", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9900) },
                    { 5, "sanaa", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9904), "example3@gmail.com", "أحمد", "عبدالله", "555555555", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9903) },
                    { 6, "sanaa", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9907), "example4@gmail.com", "ريم", "محمد", "666666666", new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9906) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
