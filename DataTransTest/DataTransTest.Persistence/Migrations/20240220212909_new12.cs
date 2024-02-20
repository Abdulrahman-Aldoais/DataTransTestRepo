using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataTransTest.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class new12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Employees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Employees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(2434), new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(2442), new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(2447), new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(7591), new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(7598), new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(7605), new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(7609), new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(7614), new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(7620), new DateTime(2024, 2, 21, 0, 29, 8, 502, DateTimeKind.Local).AddTicks(7618) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
