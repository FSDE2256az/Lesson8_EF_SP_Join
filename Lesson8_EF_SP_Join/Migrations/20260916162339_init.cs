using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lesson8_EF_SP_Join.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifierDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifierDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitInStock = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifierDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "ModifierDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop computers", null, "Laptops" },
                    { 2, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mobile smartphones", null, "Smartphones" },
                    { 3, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tablet computers", null, "Tablets" },
                    { 4, new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer monitors", null, "Monitors" },
                    { 5, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer keyboards", null, "Keyboards" },
                    { 6, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer mice", null, "Mice" },
                    { 7, new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Audio headphones", null, "Headphones" },
                    { 8, new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Digital cameras", null, "Cameras" },
                    { 9, new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Office printers", null, "Printers" },
                    { 10, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer accessories", null, "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "CompanyName", "CreatedDate", "ModifierDate", "Phone" },
                values: new object[,]
                {
                    { 1, "Baku, Nizami Street 10", "TechWorld LLC", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "+994501112233" },
                    { 2, "Baku, Tbilisi Avenue 25", "Global Electronics", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "+994502223344" },
                    { 3, "Baku, Yasamal District 15", "Smart Solutions", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "+994503334455" },
                    { 4, "Baku, Narimanov 30", "Digital Store", new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "+994504445566" },
                    { 5, "Baku, Khatai 12", "Future Tech", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "+994505556677" },
                    { 6, "Baku, Genclik 18", "Electro Market", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "+994506667788" },
                    { 7, "Baku, Sahil 22", "Max Electronics", new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "+994507778899" },
                    { 8, "Baku, 28 May 14", "Azerbaijan Tech", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "+994508889900" },
                    { 9, "Baku, Ahmadli 40", "Next Generation", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "+994509990011" },
                    { 10, "Baku, Badamdar 8", "Prime Suppliers", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "+994510001122" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "ModifierDate", "Name", "Price", "SupplierId", "UnitInStock" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dell Inspiron 15", 1450.00m, 1, 15 },
                    { 2, 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HP Pavilion 15", 1350.00m, 2, 12 },
                    { 3, 2, new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Samsung Galaxy S24", 1850.00m, 3, 20 },
                    { 4, 2, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "iPhone 15", 2100.00m, 4, 18 },
                    { 5, 3, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "iPad Air", 1650.00m, 5, 10 },
                    { 6, 3, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Samsung Galaxy Tab S9", 1450.00m, 6, 14 },
                    { 7, 4, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LG UltraGear 27", 850.00m, 7, 9 },
                    { 8, 4, new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Samsung Odyssey G5", 920.00m, 8, 11 },
                    { 9, 5, new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Logitech K380", 75.00m, 9, 30 },
                    { 10, 5, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Redragon K552", 95.00m, 10, 25 },
                    { 11, 6, new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Logitech MX Master 3S", 180.00m, 1, 17 },
                    { 12, 6, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Razer DeathAdder V2", 120.00m, 2, 22 },
                    { 13, 7, new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sony WH-1000XM5", 650.00m, 3, 13 },
                    { 14, 7, new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "JBL Tune 770NC", 220.00m, 4, 27 },
                    { 15, 8, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Canon EOS 250D", 1750.00m, 5, 7 },
                    { 16, 8, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nikon D7500", 2300.00m, 6, 6 },
                    { 17, 9, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HP LaserJet Pro", 480.00m, 7, 8 },
                    { 18, 9, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Canon Pixma G3410", 390.00m, 8, 10 },
                    { 19, 10, new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Anker USB-C Hub", 85.00m, 9, 35 },
                    { 20, 10, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Baseus Laptop Stand", 65.00m, 10, 40 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
