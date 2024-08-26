using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopFresh.Migrations
{
    /// <inheritdoc />
    public partial class identitySetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                column: "Created",
                value: new DateTime(2024, 8, 11, 15, 16, 41, 58, DateTimeKind.Local).AddTicks(6325));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 8, 21, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 8, 11, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 6, 21, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2024, 7, 21, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2023, 8, 21, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2024, 7, 22, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2024, 8, 16, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2024, 6, 21, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2024, 7, 21, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2023, 8, 21, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2024, 8, 21, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2024, 8, 11, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Created",
                value: new DateTime(2024, 8, 1, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Created",
                value: new DateTime(2024, 5, 21, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Created",
                value: new DateTime(2024, 6, 21, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Created",
                value: new DateTime(2022, 8, 21, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Created",
                value: new DateTime(2024, 8, 6, 15, 12, 19, 252, DateTimeKind.Local).AddTicks(5219));
        }
    }
}
