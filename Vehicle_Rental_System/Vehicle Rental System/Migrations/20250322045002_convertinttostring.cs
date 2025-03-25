using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Rental_System.Migrations
{
    public partial class convertinttostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId1",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_UserId1",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Bookings");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Bookings",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6cd6215 - b32b - 4bf4 - 4431 - 9f76e595b36f",
                column: "ConcurrencyStamp",
                value: "c6632a78-0ff6-43b5-8b23-875991328302");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6cd6215 - b32b - 4bf4 - 8e79 - 9f76e595b36f",
                column: "ConcurrencyStamp",
                value: "1baac101-e2a2-491c-92ee-6e2006788886");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6cd6262 - b32b - 4bf4 - 8e79 - 9f76e595b36f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7823cd2c-1ae2-4ac9-8553-0f860be36913", "AQAAAAEAACcQAAAAEGoU5js0nHJQ4QaqpgHe2kWgvZmg6gM3BM+pZz+DhCOfK1wq1+/m8f+Gp+zesI5uGg==", "4d2828fb-882b-4fcc-a27b-15afe51fc6a9" });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId1",
                table: "Bookings",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId1",
                table: "Bookings",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
