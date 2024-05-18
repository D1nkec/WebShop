using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebShopFresh.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 5, 19, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "Description", "Name", "Updated", "Valid" },
                values: new object[,]
                {
                    { 2L, new DateTime(2024, 5, 9, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9397), "Electronic devices and accessories", "Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3L, new DateTime(2024, 3, 19, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9400), "Books of various genres", "Books", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 4L, new DateTime(2024, 4, 19, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9404), "Men's, Women's, and Children's clothing", "Clothing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5L, new DateTime(2023, 5, 19, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9407), "Appliances and gadgets for home use", "Home Appliances", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 6L, new DateTime(2024, 4, 19, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9410), "Toys for children of all ages", "Toys", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CategoryId", "Created", "Description", "Name", "Price" },
                values: new object[] { 2L, new DateTime(2024, 5, 14, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9523), "Latest model smartphone with high-end features", "Smartphone", 999m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CategoryId", "Created", "Description", "Name", "Price" },
                values: new object[] { 3L, new DateTime(2024, 3, 19, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9529), "A captivating science fiction novel", "Science Fiction Novel", 15m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CategoryId", "Created", "Description", "Name" },
                values: new object[] { 4L, new DateTime(2024, 4, 19, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9532), "Comfortable cotton t-shirt", "Men's T-Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CategoryId", "Created", "Description", "Name", "Price" },
                values: new object[] { 5L, new DateTime(2023, 5, 19, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9535), "High-efficiency vacuum cleaner", "Vacuum Cleaner", 150m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2024, 5, 19, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Description", "ImageUrl", "Name", "Price", "Quantity", "Updated", "Valid" },
                values: new object[,]
                {
                    { 6L, 6L, new DateTime(2024, 5, 9, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9541), "Popular action figure toy", "/content/test-sku.jpg", "Action Figure", 30m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 7L, 2L, new DateTime(2024, 4, 29, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9544), "High-performance laptop for work and play", "/content/test-sku.jpg", "Laptop", 1200m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 8L, 3L, new DateTime(2024, 2, 19, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9547), "An intriguing mystery thriller novel", "/content/test-sku.jpg", "Mystery Thriller", 20m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 9L, 4L, new DateTime(2024, 3, 19, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9550), "Stylish and comfortable women's jeans", "/content/test-sku.jpg", "Women's Jeans", 50m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 10L, 5L, new DateTime(2022, 5, 19, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9554), "Multi-functional kitchen blender", "/content/test-sku.jpg", "Blender", 80m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 11L, 6L, new DateTime(2024, 5, 4, 0, 37, 14, 130, DateTimeKind.Local).AddTicks(9557), "Creative building blocks for children", "/content/test-sku.jpg", "Building Blocks", 40m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 5, 18, 22, 29, 29, 351, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CategoryId", "Created", "Description", "Name", "Price" },
                values: new object[] { 1L, new DateTime(2024, 5, 18, 22, 29, 29, 351, DateTimeKind.Local).AddTicks(4385), "Test description", "Test product", 125m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CategoryId", "Created", "Description", "Name", "Price" },
                values: new object[] { 1L, new DateTime(2024, 5, 18, 22, 29, 29, 351, DateTimeKind.Local).AddTicks(4392), "neki description", "TEST", 125m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CategoryId", "Created", "Description", "Name" },
                values: new object[] { 1L, new DateTime(2024, 5, 18, 22, 29, 29, 351, DateTimeKind.Local).AddTicks(4395), "Test description", "test" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CategoryId", "Created", "Description", "Name", "Price" },
                values: new object[] { 1L, new DateTime(2024, 5, 18, 22, 29, 29, 351, DateTimeKind.Local).AddTicks(4398), "neki description", "TEST", 1125m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2024, 5, 18, 22, 29, 29, 351, DateTimeKind.Local).AddTicks(4431));
        }
    }
}
