﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog.Persistance.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductsInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductsInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 908m },
                    { 2, "Description for product 2", "Product 2", 966m },
                    { 3, "Description for product 3", "Product 3", 799m },
                    { 4, "Description for product 4", "Product 4", 305m },
                    { 5, "Description for product 5", "Product 5", 768m },
                    { 6, "Description for product 6", "Product 6", 353m },
                    { 7, "Description for product 7", "Product 7", 254m },
                    { 8, "Description for product 8", "Product 8", 334m },
                    { 9, "Description for product 9", "Product 9", 461m },
                    { 10, "Description for product 10", "Product 10", 133m },
                    { 11, "Description for product 11", "Product 11", 599m },
                    { 12, "Description for product 12", "Product 12", 312m },
                    { 13, "Description for product 13", "Product 13", 736m },
                    { 14, "Description for product 14", "Product 14", 592m },
                    { 15, "Description for product 15", "Product 15", 375m },
                    { 16, "Description for product 16", "Product 16", 219m },
                    { 17, "Description for product 17", "Product 17", 653m },
                    { 18, "Description for product 18", "Product 18", 480m },
                    { 19, "Description for product 19", "Product 19", 552m },
                    { 20, "Description for product 20", "Product 20", 674m },
                    { 21, "Description for product 21", "Product 21", 787m },
                    { 22, "Description for product 22", "Product 22", 423m },
                    { 23, "Description for product 23", "Product 23", 550m },
                    { 24, "Description for product 24", "Product 24", 570m },
                    { 25, "Description for product 25", "Product 25", 782m },
                    { 26, "Description for product 26", "Product 26", 549m },
                    { 27, "Description for product 27", "Product 27", 606m },
                    { 28, "Description for product 28", "Product 28", 152m },
                    { 29, "Description for product 29", "Product 29", 175m },
                    { 30, "Description for product 30", "Product 30", 709m },
                    { 31, "Description for product 31", "Product 31", 296m },
                    { 32, "Description for product 32", "Product 32", 510m },
                    { 33, "Description for product 33", "Product 33", 707m },
                    { 34, "Description for product 34", "Product 34", 416m },
                    { 35, "Description for product 35", "Product 35", 581m },
                    { 36, "Description for product 36", "Product 36", 378m },
                    { 37, "Description for product 37", "Product 37", 683m },
                    { 38, "Description for product 38", "Product 38", 617m },
                    { 39, "Description for product 39", "Product 39", 242m },
                    { 40, "Description for product 40", "Product 40", 414m },
                    { 41, "Description for product 41", "Product 41", 300m },
                    { 42, "Description for product 42", "Product 42", 175m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 43, "Description for product 43", "Product 43", 389m },
                    { 44, "Description for product 44", "Product 44", 106m },
                    { 45, "Description for product 45", "Product 45", 759m },
                    { 46, "Description for product 46", "Product 46", 108m },
                    { 47, "Description for product 47", "Product 47", 475m },
                    { 48, "Description for product 48", "Product 48", 780m },
                    { 49, "Description for product 49", "Product 49", 751m },
                    { 50, "Description for product 50", "Product 50", 428m },
                    { 51, "Description for product 51", "Product 51", 954m },
                    { 52, "Description for product 52", "Product 52", 598m },
                    { 53, "Description for product 53", "Product 53", 639m },
                    { 54, "Description for product 54", "Product 54", 860m },
                    { 55, "Description for product 55", "Product 55", 192m },
                    { 56, "Description for product 56", "Product 56", 635m },
                    { 57, "Description for product 57", "Product 57", 479m },
                    { 58, "Description for product 58", "Product 58", 730m },
                    { 59, "Description for product 59", "Product 59", 419m },
                    { 60, "Description for product 60", "Product 60", 600m },
                    { 61, "Description for product 61", "Product 61", 821m },
                    { 62, "Description for product 62", "Product 62", 913m },
                    { 63, "Description for product 63", "Product 63", 782m },
                    { 64, "Description for product 64", "Product 64", 290m },
                    { 65, "Description for product 65", "Product 65", 433m },
                    { 66, "Description for product 66", "Product 66", 865m },
                    { 67, "Description for product 67", "Product 67", 867m },
                    { 68, "Description for product 68", "Product 68", 352m },
                    { 69, "Description for product 69", "Product 69", 543m },
                    { 70, "Description for product 70", "Product 70", 968m },
                    { 71, "Description for product 71", "Product 71", 396m },
                    { 72, "Description for product 72", "Product 72", 875m },
                    { 73, "Description for product 73", "Product 73", 374m },
                    { 74, "Description for product 74", "Product 74", 693m },
                    { 75, "Description for product 75", "Product 75", 771m },
                    { 76, "Description for product 76", "Product 76", 910m },
                    { 77, "Description for product 77", "Product 77", 729m },
                    { 78, "Description for product 78", "Product 78", 457m },
                    { 79, "Description for product 79", "Product 79", 534m },
                    { 80, "Description for product 80", "Product 80", 560m },
                    { 81, "Description for product 81", "Product 81", 323m },
                    { 82, "Description for product 82", "Product 82", 871m },
                    { 83, "Description for product 83", "Product 83", 870m },
                    { 84, "Description for product 84", "Product 84", 230m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 85, "Description for product 85", "Product 85", 201m },
                    { 86, "Description for product 86", "Product 86", 473m },
                    { 87, "Description for product 87", "Product 87", 331m },
                    { 88, "Description for product 88", "Product 88", 804m },
                    { 89, "Description for product 89", "Product 89", 798m },
                    { 90, "Description for product 90", "Product 90", 862m },
                    { 91, "Description for product 91", "Product 91", 700m },
                    { 92, "Description for product 92", "Product 92", 296m },
                    { 93, "Description for product 93", "Product 93", 167m },
                    { 94, "Description for product 94", "Product 94", 877m },
                    { 95, "Description for product 95", "Product 95", 976m },
                    { 96, "Description for product 96", "Product 96", 308m },
                    { 97, "Description for product 97", "Product 97", 637m },
                    { 98, "Description for product 98", "Product 98", 170m },
                    { 99, "Description for product 99", "Product 99", 861m },
                    { 100, "Description for product 100", "Product 100", 244m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductsInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 9 },
                    { 2, 2, 0 },
                    { 3, 3, 0 },
                    { 4, 4, 18 },
                    { 5, 5, 2 },
                    { 6, 6, 13 },
                    { 7, 7, 14 },
                    { 8, 8, 2 },
                    { 9, 9, 0 },
                    { 10, 10, 11 },
                    { 11, 11, 16 },
                    { 12, 12, 3 },
                    { 13, 13, 16 },
                    { 14, 14, 11 },
                    { 15, 15, 4 },
                    { 16, 16, 17 },
                    { 17, 17, 9 },
                    { 18, 18, 16 },
                    { 19, 19, 19 },
                    { 20, 20, 2 },
                    { 21, 21, 3 },
                    { 22, 22, 4 },
                    { 23, 23, 10 },
                    { 24, 24, 5 },
                    { 25, 25, 11 },
                    { 26, 26, 13 },
                    { 27, 27, 8 },
                    { 28, 28, 7 },
                    { 29, 29, 19 },
                    { 30, 30, 11 },
                    { 31, 31, 10 },
                    { 32, 32, 11 },
                    { 33, 33, 14 },
                    { 34, 34, 17 },
                    { 35, 35, 17 },
                    { 36, 36, 16 },
                    { 37, 37, 16 },
                    { 38, 38, 12 },
                    { 39, 39, 14 },
                    { 40, 40, 4 },
                    { 41, 41, 16 },
                    { 42, 42, 18 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductsInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 43, 43, 16 },
                    { 44, 44, 8 },
                    { 45, 45, 16 },
                    { 46, 46, 10 },
                    { 47, 47, 0 },
                    { 48, 48, 15 },
                    { 49, 49, 11 },
                    { 50, 50, 6 },
                    { 51, 51, 11 },
                    { 52, 52, 11 },
                    { 53, 53, 10 },
                    { 54, 54, 15 },
                    { 55, 55, 10 },
                    { 56, 56, 7 },
                    { 57, 57, 17 },
                    { 58, 58, 17 },
                    { 59, 59, 1 },
                    { 60, 60, 0 },
                    { 61, 61, 13 },
                    { 62, 62, 12 },
                    { 63, 63, 3 },
                    { 64, 64, 7 },
                    { 65, 65, 18 },
                    { 66, 66, 0 },
                    { 67, 67, 0 },
                    { 68, 68, 15 },
                    { 69, 69, 6 },
                    { 70, 70, 14 },
                    { 71, 71, 13 },
                    { 72, 72, 11 },
                    { 73, 73, 16 },
                    { 74, 74, 5 },
                    { 75, 75, 0 },
                    { 76, 76, 13 },
                    { 77, 77, 6 },
                    { 78, 78, 4 },
                    { 79, 79, 13 },
                    { 80, 80, 18 },
                    { 81, 81, 14 },
                    { 82, 82, 9 },
                    { 83, 83, 4 },
                    { 84, 84, 16 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductsInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 85, 85, 2 },
                    { 86, 86, 1 },
                    { 87, 87, 17 },
                    { 88, 88, 10 },
                    { 89, 89, 0 },
                    { 90, 90, 11 },
                    { 91, 91, 12 },
                    { 92, 92, 0 },
                    { 93, 93, 16 },
                    { 94, 94, 19 },
                    { 95, 95, 2 },
                    { 96, 96, 11 },
                    { 97, 97, 11 },
                    { 98, 98, 10 },
                    { 99, 99, 1 },
                    { 100, 100, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
