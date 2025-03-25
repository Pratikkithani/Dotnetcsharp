using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Rental_System.Migrations
{
    public partial class removing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6cd6215 - b32b - 4bf4 - 4431 - 9f76e595b36f",
                column: "ConcurrencyStamp",
                value: "d4be5ce4-8e4f-4f64-8da9-b045abfba2d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6cd6215 - b32b - 4bf4 - 8e79 - 9f76e595b36f",
                column: "ConcurrencyStamp",
                value: "a72a09c5-c7e0-4154-be2b-08b9f9dcae60");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6cd6262 - b32b - 4bf4 - 8e79 - 9f76e595b36f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1ee0bd92-eb17-437d-a377-54d955462edf", "AQAAAAEAACcQAAAAEA2FTIC5MG5qcC+WeJIMiY1jGrjwW7Ma5fM/aRG61en4T0fLWNsOmPCsXrGriZH//A==", "71fedfa9-8ab6-4323-8c03-57785fe62753", "adminlogin@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
