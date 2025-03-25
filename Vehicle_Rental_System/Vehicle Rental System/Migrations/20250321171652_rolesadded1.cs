using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Rental_System.Migrations
{
    public partial class rolesadded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6cd6215 - b32b - 4bf4 - 4431 - 9f76e595b36f", "c6632a78-0ff6-43b5-8b23-875991328302", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6cd6215 - b32b - 4bf4 - 8e79 - 9f76e595b36f", "1baac101-e2a2-491c-92ee-6e2006788886", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b6cd6262 - b32b - 4bf4 - 8e79 - 9f76e595b36f", 0, "7823cd2c-1ae2-4ac9-8553-0f860be36913", "User", "adminlogin@gmail.com", false, false, null, null, "ADMINLOGIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGoU5js0nHJQ4QaqpgHe2kWgvZmg6gM3BM+pZz+DhCOfK1wq1+/m8f+Gp+zesI5uGg==", null, false, "4d2828fb-882b-4fcc-a27b-15afe51fc6a9", false, "adminlogin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b6cd6215 - b32b - 4bf4 - 8e79 - 9f76e595b36f", "b6cd6262 - b32b - 4bf4 - 8e79 - 9f76e595b36f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6cd6215 - b32b - 4bf4 - 4431 - 9f76e595b36f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6cd6215 - b32b - 4bf4 - 8e79 - 9f76e595b36f", "b6cd6262 - b32b - 4bf4 - 8e79 - 9f76e595b36f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6cd6215 - b32b - 4bf4 - 8e79 - 9f76e595b36f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6cd6262 - b32b - 4bf4 - 8e79 - 9f76e595b36f");
        }
    }
}
