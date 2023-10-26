using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmlakOfisiWebUI.Migrations
{
    /// <inheritdoc />
    public partial class adminpassword2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f33905e-a5b4-45bd-8d1a-e526dfd2d269", null, "Admin", "ADMIN" },
                    { "7a1e883f-bbc9-4935-9967-28b50bf832bd", null, "Kullanıcı", "KULLANICI" },
                    { "e16886cc-4b5c-486e-a35c-4f277955af82", null, "Emlakçı", "EMLAKÇI" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f33905e-a5b4-45bd-8d1a-e526dfd2d269");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a1e883f-bbc9-4935-9967-28b50bf832bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e16886cc-4b5c-486e-a35c-4f277955af82");

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
    }
}
