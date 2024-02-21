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
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    UpdatedById = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublish = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "FirstName", "LastName", "Phone", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "sanaa", new DateTime(2024, 2, 21, 9, 50, 9, 278, DateTimeKind.Local).AddTicks(3772), "adffaf@gmail.com", "ahmeed", "ali", "454646464", new DateTime(2024, 2, 21, 9, 50, 9, 278, DateTimeKind.Local).AddTicks(3768) },
                    { 2, "sanaa", new DateTime(2024, 2, 21, 9, 50, 9, 278, DateTimeKind.Local).AddTicks(3781), "ssd2af@gmail.com", "salah", "ali", "454646464", new DateTime(2024, 2, 21, 9, 50, 9, 278, DateTimeKind.Local).AddTicks(3778) },
                    { 3, "sanaa", new DateTime(2024, 2, 21, 9, 50, 9, 278, DateTimeKind.Local).AddTicks(3785), "example1@gmail.com", "hany", "abdu", "123456789", new DateTime(2024, 2, 21, 9, 50, 9, 278, DateTimeKind.Local).AddTicks(3783) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "FirstName", "LastName", "Phone", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "sanaa", new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4716), "adffaf@gmail.com", "علي", "الدعيس", "454646464", new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4711) },
                    { 2, "sanaa", new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4722), "ssd2af@gmail.com", "سعيد", "صالح", "454646464", new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4720) },
                    { 3, "sanaa", new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4729), "example1@gmail.com", "محمد", "خالد", "123456789", new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4727) },
                    { 4, "sanaa", new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4732), "example2@gmail.com", "فاطمة", "علي", "987654321", new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4730) },
                    { 5, "sanaa", new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4739), "example3@gmail.com", "أحمد", "عبدالله", "555555555", new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4734) },
                    { 6, "sanaa", new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4743), "example4@gmail.com", "ريم", "محمد", "666666666", new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4741) }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedById", "CreationDate", "IsPublished", "Title", "UpdatedById", "UserId" },
                values: new object[] { 1, "منشور تجريبي", 1, new DateTime(2024, 2, 21, 6, 50, 9, 279, DateTimeKind.Utc).AddTicks(7249), true, "داتا ترانس", null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
