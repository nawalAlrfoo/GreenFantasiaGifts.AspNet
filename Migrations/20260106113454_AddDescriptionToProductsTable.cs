using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenFantasiaGifts011.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionToProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Caption", "CreatedAt", "Description", "Specification" },
                values: new object[] { "", new DateTime(2026, 1, 6, 11, 34, 54, 201, DateTimeKind.Utc).AddTicks(3458), "The ultimate air-purifying indoor palm. This elegant plant features feathery fronds that add a tropical feel to any room. It thrives in bright, indirect light and is safe for pets.", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Caption", "CreatedAt", "Description", "Specification" },
                values: new object[] { "", new DateTime(2026, 1, 6, 11, 34, 54, 201, DateTimeKind.Utc).AddTicks(3595), "A dramatic tropical plant known for its large, banana-like leaves and stunning flowers. It requires bright light and space to grow, making it a perfect statement piece for large living areas.", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Caption", "CreatedAt", "Description", "Specification" },
                values: new object[] { "", new DateTime(2026, 1, 6, 11, 34, 54, 201, DateTimeKind.Utc).AddTicks(3597), "Vertical, sleek, and nearly indestructible. Perfect for beginners, the Snake Plant can survive in low light conditions and needs very little water. It's also famous for converting CO2 into oxygen at night.", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Caption", "CreatedAt", "Description", "Specification" },
                values: new object[] { "", new DateTime(2026, 1, 6, 11, 34, 54, 201, DateTimeKind.Utc).AddTicks(3598), "Stunning glossy dark green foliage. The Ficus elastica prefers bright, filtered light. Its broad leaves act as natural dust magnets, helping to clean the air while adding a sophisticated look to your office.", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Caption", "CreatedAt", "Description", "Specification" },
                values: new object[] { "", new DateTime(2026, 1, 6, 11, 34, 54, 201, DateTimeKind.Utc).AddTicks(3600), "Tough and low maintenance. This variety survives in very low light and needs little water. Its unique variegated patterns make it a visually striking addition to any dark corner.", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Caption", "CreatedAt", "Specification" },
                values: new object[] { "The ultimate air-purifying indoor palm.", new DateTime(2026, 1, 6, 11, 6, 24, 221, DateTimeKind.Utc).AddTicks(6572), "Thrives in bright, indirect light." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Caption", "CreatedAt", "Specification" },
                values: new object[] { "A dramatic tropical plant.", new DateTime(2026, 1, 6, 11, 6, 24, 221, DateTimeKind.Utc).AddTicks(6656), "Requires bright light and space to grow." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Caption", "CreatedAt", "Specification" },
                values: new object[] { "Vertical, sleek, and nearly indestructible.", new DateTime(2026, 1, 6, 11, 6, 24, 221, DateTimeKind.Utc).AddTicks(6659), "Perfect for beginners. Low light tolerant." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Caption", "CreatedAt", "Specification" },
                values: new object[] { "Stunning glossy dark green foliage.", new DateTime(2026, 1, 6, 11, 6, 24, 221, DateTimeKind.Utc).AddTicks(6662), "Ficus elastica. Prefers bright, filtered light." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Caption", "CreatedAt", "Specification" },
                values: new object[] { "Tough and low maintenance.", new DateTime(2026, 1, 6, 11, 6, 24, 221, DateTimeKind.Utc).AddTicks(6664), "Survives in very low light and needs little water." });
        }
    }
}
