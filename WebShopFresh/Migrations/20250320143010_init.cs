using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebShopFresh.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valid = table.Column<bool>(type: "bit", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valid = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<long>(type: "bigint", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<long>(type: "bigint", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valid = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(9,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valid = table.Column<bool>(type: "bit", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderAddressId = table.Column<long>(type: "bigint", nullable: true),
                    BuyerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_OrderAddressId",
                        column: x => x.OrderAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SessionItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valid = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valid = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "Created", "Number", "Street", "Updated", "Valid" },
                values: new object[] { 1L, "Zagreb", "Hrvatska", new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "100", "Maksimirska", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "Description", "Name", "Updated", "Valid" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6052), "Test description", "Test kategorija", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2L, new DateTime(2025, 3, 10, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6098), "Electronic devices and accessories", "Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3L, new DateTime(2025, 1, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6102), "Books of various genres", "Books", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 4L, new DateTime(2025, 2, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6106), "Men's, Women's, and Children's clothing", "Clothing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5L, new DateTime(2024, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6108), "Appliances and gadgets for home use", "Home Appliances", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 6L, new DateTime(2025, 2, 18, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6111), "Toys for children of all ages", "Toys", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Description", "ImageUrl", "Name", "Price", "Quantity", "Updated", "Valid" },
                values: new object[,]
                {
                    { 1L, 2L, new DateTime(2025, 3, 15, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6142), "Latest model smartphone with high-end features", "/content/test-sku.jpg", "Smartphone", 999m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2L, 3L, new DateTime(2025, 1, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6149), "A captivating science fiction novel", "/content/test-sku.jpg", "Science Fiction Novel", 15m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3L, 4L, new DateTime(2025, 2, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6152), "Comfortable cotton t-shirt", "/content/test-sku.jpg", "Men's T-Shirt", 25m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 4L, 5L, new DateTime(2024, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6155), "High-efficiency vacuum cleaner", "/content/test-sku.jpg", "Vacuum Cleaner", 150m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6158), "neki description", "/content/test-sku.jpg", "TEST", 1525m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 6L, 6L, new DateTime(2025, 3, 10, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6161), "Popular action figure toy", "/content/action-figure-496wpt-1.jpg", "Action Figure", 30m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 7L, 2L, new DateTime(2025, 2, 28, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6163), "High-performance laptop for work and play", "/content/laptop.jpg", "Laptop", 1200m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 8L, 3L, new DateTime(2024, 12, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6166), "An intriguing mystery thriller novel", "/content/test-sku.jpg", "Mystery Thriller", 20m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 9L, 4L, new DateTime(2025, 1, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6170), "Stylish and comfortable women's jeans", "/content/test-sku.jpg", "Women's Jeans", 50m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 10L, 5L, new DateTime(2023, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6173), "Multi-functional kitchen blender", "/content/blender.jpg", "Blender", 80m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 11L, 6L, new DateTime(2025, 3, 5, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6176), "Creative building blocks for children", "/content/BuildingBlocks.jpg", "Building Blocks", 40m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6179), "neki description", "/content/test-sku.jpg", "TEST", 1525m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 13L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6181), "neki description", "/content/test-sku.jpg", "TEST", 525m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 14L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6184), "neki description", "/content/test-sku.jpg", "TEST", 1315m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 15L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6187), "neki description", "/content/test-sku.jpg", "TEST", 1525m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 16L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6190), "neki description", "/content/test-sku.jpg", "TEST", 1525m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 17L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6192), "neki description", "/content/test-sku.jpg", "TEST", 1525m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 18L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6195), "neki description", "/content/test-sku.jpg", "TEST", 1525m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 19L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6198), "neki description", "/content/test-sku.jpg", "TEST", 1525m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 20L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6201), "neki description", "/content/test-sku.jpg", "TEST", 1525m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 21L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6203), "neki description", "/content/test-sku.jpg", "TEST", 1525m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 22L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6206), "neki description", "/content/test-sku.jpg", "TEST", 1525m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 23L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6209), "neki description", "/content/test-sku.jpg", "TEST", 1525m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 24L, 1L, new DateTime(2025, 3, 20, 15, 30, 9, 505, DateTimeKind.Local).AddTicks(6212), "neki description", "/content/test-sku.jpg", "TEST", 1525m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BuyerId",
                table: "Orders",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderAddressId",
                table: "Orders",
                column: "OrderAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionItems_UserId",
                table: "SessionItems",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "SessionItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
