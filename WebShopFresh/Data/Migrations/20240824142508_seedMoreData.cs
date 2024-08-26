using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopFresh.Migrations
{
    /// <inheritdoc />
    public partial class seedMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 8, 24, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 8, 14, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 6, 24, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2024, 7, 24, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2023, 8, 24, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2024, 7, 25, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 8, 19, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 6, 24, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 7, 24, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2023, 8, 24, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2024, 8, 24, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2024, 8, 14, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(657), "/content/laptop.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Created",
                value: new DateTime(2024, 5, 24, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Created",
                value: new DateTime(2024, 6, 24, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2022, 8, 24, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(666), "/content/blender.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2024, 8, 9, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(669), "/content/BuildingBlocks.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 8, 24, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 8, 14, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 6, 24, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2024, 7, 24, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2023, 8, 24, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2024, 7, 25, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 8, 19, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 6, 24, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 7, 24, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2023, 8, 24, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2024, 8, 24, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2024, 8, 14, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6382), "/content/test-sku.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Created",
                value: new DateTime(2024, 5, 24, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Created",
                value: new DateTime(2024, 6, 24, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2022, 8, 24, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6390), "/content/test-sku.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2024, 8, 9, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6393), "/content/test-sku.jpg" });
        }
    }
}
