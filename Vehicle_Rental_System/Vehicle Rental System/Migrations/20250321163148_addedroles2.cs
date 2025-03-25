using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Rental_System.Migrations
{
    public partial class addedroles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - 4432 - 2879a6680b9a",
                column: "ConcurrencyStamp",
                value: "b1383e9d-0ede-455f-b392-c1abe208b520");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a",
                column: "ConcurrencyStamp",
                value: "59ecba4e-b124-457f-a571-c0f1da802d3f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a", 0, "5dbadf30-56d1-4a14-b489-170d11bb7814", "User", "admin@gmail.com", false, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEHcXuoJxEWC47yeWmEtz3hhb36kpUx789C6Yd+s4wGuR6bCPxhpNEsO7QAbNP1c4sw==", null, false, "3f613b2b-9bf2-4699-ac02-2e6ccfd23870", false, "admin@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - 4432 - 2879a6680b9a",
                column: "ConcurrencyStamp",
                value: "13002e7b-462c-4a26-a9bf-1927d93b2bfd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a",
                column: "ConcurrencyStamp",
                value: "4d22bd87-4bcf-4af4-ba29-b7f416e16f61");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a", 0, "cb4dcb83-8dc4-4fb4-b121-3321c41766cb", "IdentityUser", "admin@gmail.com", false, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEO64FdKwNngCeAJWVr09vty5Dca2SqsryvUg3A1pbQBYx8HwXxSBrg4YaET2+KlZVw==", null, false, "59d47adb-b78d-45a1-bb0e-aebcef91d09f", false, "admin@gmail.com" });
        }
    }
}
