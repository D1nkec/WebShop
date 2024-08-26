using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopFresh.Migrations
{
    /// <inheritdoc />
    public partial class newUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BuyerId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

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
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2024, 8, 14, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6379), "/content/action-figure-496wpt-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Created",
                value: new DateTime(2024, 8, 4, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6382));

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
                column: "Created",
                value: new DateTime(2022, 8, 24, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Created",
                value: new DateTime(2024, 8, 9, 16, 20, 5, 913, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BuyerId",
                table: "Orders",
                column: "BuyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_BuyerId",
                table: "Orders",
                column: "BuyerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_BuyerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_BuyerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BuyerId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 8, 21, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 8, 11, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 6, 21, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2024, 7, 21, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2023, 8, 21, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2024, 7, 22, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 8, 16, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 6, 21, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 7, 21, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2023, 8, 21, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2024, 8, 21, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "ImageUrl" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6325), "/content/test-sku.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Created",
                value: new DateTime(2024, 8, 1, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Created",
                value: new DateTime(2024, 5, 21, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Created",
                value: new DateTime(2024, 6, 21, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Created",
                value: new DateTime(2022, 8, 21, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Created",
                value: new DateTime(2024, 8, 6, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6344));
        }
    }
}
