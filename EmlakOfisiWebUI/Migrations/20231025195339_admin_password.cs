using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmlakOfisiWebUI.Migrations
{
    /// <inheritdoc />
    public partial class adminpassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteListLine");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2400992d-b6e6-46f9-8bd9-1115f233b904");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80491fda-f6d3-4f82-b984-077fc011400c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdbda4e9-70e3-4aba-9967-d90eab5c48d4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ada67f37-c4e2-4de2-8ea5-91440648c9e7", null, "Emlakçı", "EMLAKÇI" },
                    { "e4c22659-0161-4398-aab3-f183a50872dd", null, "Admin", "ADMIN" },
                    { "ef14e0d6-4b88-4fc2-815c-6cbda660fef2", null, "Kullanıcı", "KULLANICI" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ada67f37-c4e2-4de2-8ea5-91440648c9e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4c22659-0161-4398-aab3-f183a50872dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef14e0d6-4b88-4fc2-815c-6cbda660fef2");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiftWrap = table.Column<bool>(type: "bit", nullable: false),
                    Line1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Line2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Line3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Shipped = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteListLine",
                columns: table => new
                {
                    FavoriteListLineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstateId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteListLine", x => x.FavoriteListLineId);
                    table.ForeignKey(
                        name: "FK_FavoriteListLine_Estates_EstateId",
                        column: x => x.EstateId,
                        principalTable: "Estates",
                        principalColumn: "EstateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteListLine_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2400992d-b6e6-46f9-8bd9-1115f233b904", null, "Emlakçı", "EMLAKÇI" },
                    { "80491fda-f6d3-4f82-b984-077fc011400c", null, "Kullanıcı", "KULLANICI" },
                    { "bdbda4e9-70e3-4aba-9967-d90eab5c48d4", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteListLine_EstateId",
                table: "FavoriteListLine",
                column: "EstateId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteListLine_OrderId",
                table: "FavoriteListLine",
                column: "OrderId");
        }
    }
}
