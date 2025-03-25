using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Rental_System.Migrations
{
    public partial class rolesadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41776008 - 6086 - 1fbf - 4432 - 2879a6680b9a", "25797090-f4d2-4262-ab4c-bf8e61dc57cd", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a", "673486ce-fab3-4714-8725-f2582c74dffe", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a", 0, "8a880f40-6e17-47ed-9a8c-19fd29e0cdae", "User", "adminlogin@gmail.com", false, false, null, null, "ADMINLOGIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPM67OfyPgletfSj7Ks9lA7t/ZD6JbkKK8/5AmMsz5Sxfy3IkAE9yCjeQvNqF3pivw==", null, false, "8df61e65-29b8-453b-b400-4b5c96133f34", false, "adminlogin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a", "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a" });
        }
    }
}
