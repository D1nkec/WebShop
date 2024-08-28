using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopFresh.Migrations
{
    /// <inheritdoc />
    public partial class newprops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "Created",
                value: new DateTime(2024, 8, 4, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(657));

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
                column: "Created",
                value: new DateTime(2022, 8, 24, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Created",
                value: new DateTime(2024, 8, 9, 16, 25, 8, 5, DateTimeKind.Local).AddTicks(669));
        }
    }
}
