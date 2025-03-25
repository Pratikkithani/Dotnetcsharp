using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Rental_System.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9887f139-88a5-433d-a7b4-173b349760ad", "AQAAAAEAACcQAAAAELRfuvqOGbEC/lm7OhzaVxpbEvQtZQg0BMJeCxkocqzy7V1/7C4ycI7kmJb3o4N30g==", "19721997-f0fc-4389-b6d6-fbb8264a4f18" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6cd6215 - b32b - 4bf4 - 4431 - 9f76e595b36f",
                column: "ConcurrencyStamp",
                value: "c81f29e4-d080-464e-9631-c5179124fada");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6cd6215 - b32b - 4bf4 - 8e79 - 9f76e595b36f",
                column: "ConcurrencyStamp",
                value: "7547051d-a144-48ee-95ee-6bffc46b4df4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6cd6262 - b32b - 4bf4 - 8e79 - 9f76e595b36f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "177ec94a-dc88-477d-bcdc-f6aca903dba3", "AQAAAAEAACcQAAAAEJdbER/UgkJtD6utT/gdf6FG25nDJXACY4TsQkibBSgRaJm2/5W0e+P+dLC9ErXOjA==", "35cf0a2d-3f8a-4828-8b34-4428cfbc9297" });
        }
    }
}
