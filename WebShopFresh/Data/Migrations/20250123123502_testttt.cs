using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopFresh.Migrations
{
    /// <inheritdoc />
    public partial class testttt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2025, 1, 23, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2025, 1, 13, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 11, 23, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2024, 12, 23, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2024, 1, 23, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2024, 12, 24, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2025, 1, 18, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 11, 23, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 12, 23, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2024, 1, 23, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2025, 1, 23, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2025, 1, 13, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Created",
                value: new DateTime(2025, 1, 3, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Created",
                value: new DateTime(2024, 10, 23, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Created",
                value: new DateTime(2024, 11, 23, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Created",
                value: new DateTime(2023, 1, 23, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Created",
                value: new DateTime(2025, 1, 8, 13, 35, 2, 228, DateTimeKind.Local).AddTicks(912));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2025, 1, 23, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2025, 1, 13, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 11, 23, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2024, 12, 23, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2024, 1, 23, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2024, 12, 24, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2025, 1, 18, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 11, 23, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 12, 23, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2024, 1, 23, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2025, 1, 23, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2025, 1, 13, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Created",
                value: new DateTime(2025, 1, 3, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Created",
                value: new DateTime(2024, 10, 23, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Created",
                value: new DateTime(2024, 11, 23, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Created",
                value: new DateTime(2023, 1, 23, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Created",
                value: new DateTime(2025, 1, 8, 13, 15, 24, 218, DateTimeKind.Local).AddTicks(3733));
        }
    }
}
