using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenFantasiaGifts011.Migrations
{
    /// <inheritdoc />
    public partial class InitialFix011 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsInStock = table.Column<bool>(type: "bit", nullable: false),
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
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Caption", "Category", "CreatedAt", "ImageUrl", "IsInStock", "Name", "Price", "Specification" },
                values: new object[,]
                {
                    { 1, "The ultimate air-purifying indoor palm.", "Indoor Plants", new DateTime(2026, 1, 5, 23, 3, 27, 86, DateTimeKind.Utc).AddTicks(4910), "/images/ArecaPalm.png", true, "Areca Palm", 120.00m, "Thrives in bright, indirect light." },
                    { 2, "A dramatic tropical plant.", "Tropical Plants", new DateTime(2026, 1, 5, 23, 3, 27, 86, DateTimeKind.Utc).AddTicks(5000), "/images/BirdOfParadise.png", true, "Bird of Paradise", 250.00m, "Requires bright light and space to grow." },
                    { 3, "Vertical, sleek, and nearly indestructible.", "Low Light Plants", new DateTime(2026, 1, 5, 23, 3, 27, 86, DateTimeKind.Utc).AddTicks(5002), "/images/SnakePlant.png", true, "Snake Plant", 45.00m, "Perfect for beginners. Low light tolerant." },
                    { 4, "Stunning glossy dark green foliage.", "Indoor Trees", new DateTime(2026, 1, 5, 23, 3, 27, 86, DateTimeKind.Utc).AddTicks(5004), "/images/RubberPlant.png", true, "Rubber Plant", 85.00m, "Ficus elastica. Prefers bright, filtered light." },
                    { 5, "Tough and low maintenance.", "Low Light Plants", new DateTime(2026, 1, 5, 23, 3, 27, 86, DateTimeKind.Utc).AddTicks(5005), "/images/DracaenaTrifasciata.png", true, "Dracaena Trifasciata", 55.00m, "Survives in very low light and needs little water." }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Password", "Role", "Username" },
                values: new object[] { 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NON@greenfantasia.com", "NON6675", "Admin", "AdminGreen" });

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
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
