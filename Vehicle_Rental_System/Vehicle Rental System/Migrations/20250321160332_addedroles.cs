using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Rental_System.Migrations
{
    public partial class addedroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41776008 - 6086 - 1fbf - 4432 - 2879a6680b9a", "68b3cb85-9ccf-4e29-a9cd-45f55d69f4f7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a", "d9b4a497-e77d-41eb-a80f-14d7b53c2465", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a", 0, "5e4ef2a3-a8c2-40d3-b6c2-c08428044959", "IdentityUser", "admin@gmail.com", false, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENSAmq9+Rrq/Fj4FXoU6zc+rWeVe9qTaA1v6AbIOrXzyXUANnG4VB/YaXpQrg1LriA==", null, false, "55af99d0-c86c-4e19-913e-b4b09ad683a3", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a", "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - 4432 - 2879a6680b9a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a", "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a");
        }
    }
}
