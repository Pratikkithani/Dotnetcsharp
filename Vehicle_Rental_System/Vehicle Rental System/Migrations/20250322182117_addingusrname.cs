using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Rental_System.Migrations
{
    public partial class addingusrname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6cd6215 - b32b - 4bf4 - 4431 - 9f76e595b36f",
                column: "ConcurrencyStamp",
                value: "612e20c8-c98f-4ebb-b49d-55f50608463d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6cd6215 - b32b - 4bf4 - 8e79 - 9f76e595b36f",
                column: "ConcurrencyStamp",
                value: "e938f444-d1a5-400a-ba1b-1b1581ba6c40");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6cd6262 - b32b - 4bf4 - 8e79 - 9f76e595b36f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "366bebdb-d0c6-4c64-afca-aec27acab7dc", "AQAAAAEAACcQAAAAEHeYeNXLEV1h4tJFD6KESwx7vKx7jlkbjIHFcOJ3P7XqzaH3bgwJPh2dYkfXcxj1nQ==", "02c9a0b4-7c25-49d7-bd0a-97bf41017f97", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6cd6215 - b32b - 4bf4 - 4431 - 9f76e595b36f",
                column: "ConcurrencyStamp",
                value: "8f9bfb96-32db-4b6f-95c6-36f0146f0527");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6cd6215 - b32b - 4bf4 - 8e79 - 9f76e595b36f",
                column: "ConcurrencyStamp",
                value: "50919175-8ec3-41b3-b1d3-74d141973b01");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6cd6262 - b32b - 4bf4 - 8e79 - 9f76e595b36f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9887f139-88a5-433d-a7b4-173b349760ad", "AQAAAAEAACcQAAAAELRfuvqOGbEC/lm7OhzaVxpbEvQtZQg0BMJeCxkocqzy7V1/7C4ycI7kmJb3o4N30g==", "19721997-f0fc-4389-b6d6-fbb8264a4f18", "adminlogin@gmail.com" });
        }
    }
}
