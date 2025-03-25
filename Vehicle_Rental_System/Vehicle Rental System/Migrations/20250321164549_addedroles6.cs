using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Rental_System.Migrations
{
    public partial class addedroles6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - 4432 - 2879a6680b9a",
                column: "ConcurrencyStamp",
                value: "25797090-f4d2-4262-ab4c-bf8e61dc57cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a",
                column: "ConcurrencyStamp",
                value: "673486ce-fab3-4714-8725-f2582c74dffe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a880f40-6e17-47ed-9a8c-19fd29e0cdae", "AQAAAAEAACcQAAAAEPM67OfyPgletfSj7Ks9lA7t/ZD6JbkKK8/5AmMsz5Sxfy3IkAE9yCjeQvNqF3pivw==", "8df61e65-29b8-453b-b400-4b5c96133f34" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - 4432 - 2879a6680b9a",
                column: "ConcurrencyStamp",
                value: "547be951-22d1-493e-afc9-ef4461a0b896");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a",
                column: "ConcurrencyStamp",
                value: "dd253557-a483-4167-857c-110331979292");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dbd8f2a-2460-497c-8ef1-a02c27cd40c4", "AQAAAAEAACcQAAAAEOoXAlI7e3Nxje93TfpRjz8uJQxOLwgkt3mCLSLHF0yJpFzx6xw/XcDD3rh+W4gsEQ==", "7614db35-0ad8-4921-8849-70a208bd3758" });
        }
    }
}
