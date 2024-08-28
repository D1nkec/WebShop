using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopFresh.Migrations
{
    /// <inheritdoc />
    public partial class newupdates1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 8, 28, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 8, 18, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 6, 28, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2024, 7, 28, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2023, 8, 28, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2024, 7, 29, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 8, 23, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 6, 28, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 7, 28, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2023, 8, 28, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2024, 8, 28, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2024, 8, 18, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Created",
                value: new DateTime(2024, 8, 8, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Created",
                value: new DateTime(2024, 5, 28, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Created",
                value: new DateTime(2024, 6, 28, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Created",
                value: new DateTime(2022, 8, 28, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Created",
                value: new DateTime(2024, 8, 13, 14, 2, 40, 624, DateTimeKind.Local).AddTicks(9168));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 8, 27, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 8, 17, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 6, 27, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2024, 7, 27, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2023, 8, 27, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2024, 7, 28, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 8, 22, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 6, 27, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 7, 27, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2023, 8, 27, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2024, 8, 27, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2024, 8, 17, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Created",
                value: new DateTime(2024, 8, 7, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Created",
                value: new DateTime(2024, 5, 27, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Created",
                value: new DateTime(2024, 6, 27, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Created",
                value: new DateTime(2022, 8, 27, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Created",
                value: new DateTime(2024, 8, 12, 13, 11, 20, 233, DateTimeKind.Local).AddTicks(1559));
        }
    }
}
