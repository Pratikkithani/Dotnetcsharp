using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Rental_System.Migrations
{
    public partial class addedroles5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0dbd8f2a-2460-497c-8ef1-a02c27cd40c4", "adminlogin@gmail.com", "ADMINLOGIN@GMAIL.COM", "AQAAAAEAACcQAAAAEOoXAlI7e3Nxje93TfpRjz8uJQxOLwgkt3mCLSLHF0yJpFzx6xw/XcDD3rh+W4gsEQ==", "7614db35-0ad8-4921-8849-70a208bd3758", "adminlogin@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5dbadf30-56d1-4a14-b489-170d11bb7814", "admin@gmail.com", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEHcXuoJxEWC47yeWmEtz3hhb36kpUx789C6Yd+s4wGuR6bCPxhpNEsO7QAbNP1c4sw==", "3f613b2b-9bf2-4699-ac02-2e6ccfd23870", "admin@gmail.com" });
        }
    }
}
