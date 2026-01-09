using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenFantasiaGifts011.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 1, 6, 11, 6, 24, 221, DateTimeKind.Utc).AddTicks(6572), 20.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 1, 6, 11, 6, 24, 221, DateTimeKind.Utc).AddTicks(6656), 10.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 1, 6, 11, 6, 24, 221, DateTimeKind.Utc).AddTicks(6659), 5.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 1, 6, 11, 6, 24, 221, DateTimeKind.Utc).AddTicks(6662), 13.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 1, 6, 11, 6, 24, 221, DateTimeKind.Utc).AddTicks(6664), 9.00m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 1, 5, 23, 3, 27, 86, DateTimeKind.Utc).AddTicks(4910), 120.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 1, 5, 23, 3, 27, 86, DateTimeKind.Utc).AddTicks(5000), 250.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 1, 5, 23, 3, 27, 86, DateTimeKind.Utc).AddTicks(5002), 45.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 1, 5, 23, 3, 27, 86, DateTimeKind.Utc).AddTicks(5004), 85.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 1, 5, 23, 3, 27, 86, DateTimeKind.Utc).AddTicks(5005), 55.00m });
        }
    }
}
