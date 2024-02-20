using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataTransTest.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class new1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 56, 27, 9, DateTimeKind.Local).AddTicks(7904), new DateTime(2024, 2, 20, 23, 56, 27, 9, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 56, 27, 9, DateTimeKind.Local).AddTicks(7907), new DateTime(2024, 2, 20, 23, 56, 27, 9, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 56, 27, 9, DateTimeKind.Local).AddTicks(7976), new DateTime(2024, 2, 20, 23, 56, 27, 9, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 56, 27, 10, DateTimeKind.Local).AddTicks(977), new DateTime(2024, 2, 20, 23, 56, 27, 10, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 56, 27, 10, DateTimeKind.Local).AddTicks(981), new DateTime(2024, 2, 20, 23, 56, 27, 10, DateTimeKind.Local).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 56, 27, 10, DateTimeKind.Local).AddTicks(985), new DateTime(2024, 2, 20, 23, 56, 27, 10, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 56, 27, 10, DateTimeKind.Local).AddTicks(988), new DateTime(2024, 2, 20, 23, 56, 27, 10, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 56, 27, 10, DateTimeKind.Local).AddTicks(991), new DateTime(2024, 2, 20, 23, 56, 27, 10, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 56, 27, 10, DateTimeKind.Local).AddTicks(994), new DateTime(2024, 2, 20, 23, 56, 27, 10, DateTimeKind.Local).AddTicks(992) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(5142), new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(5146), new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(5149), new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9889), new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9895), new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9898), new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9901), new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9904), new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 2, 20, 23, 49, 16, 50, DateTimeKind.Local).AddTicks(9906) });
        }
    }
}
