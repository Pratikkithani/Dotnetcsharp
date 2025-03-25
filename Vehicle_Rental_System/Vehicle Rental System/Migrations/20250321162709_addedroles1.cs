using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Rental_System.Migrations
{
    public partial class addedroles1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb4dcb83-8dc4-4fb4-b121-3321c41766cb", "AQAAAAEAACcQAAAAEO64FdKwNngCeAJWVr09vty5Dca2SqsryvUg3A1pbQBYx8HwXxSBrg4YaET2+KlZVw==", "59d47adb-b78d-45a1-bb0e-aebcef91d09f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - 4432 - 2879a6680b9a",
                column: "ConcurrencyStamp",
                value: "68b3cb85-9ccf-4e29-a9cd-45f55d69f4f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a",
                column: "ConcurrencyStamp",
                value: "d9b4a497-e77d-41eb-a80f-14d7b53c2465");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e4ef2a3-a8c2-40d3-b6c2-c08428044959", "AQAAAAEAACcQAAAAENSAmq9+Rrq/Fj4FXoU6zc+rWeVe9qTaA1v6AbIOrXzyXUANnG4VB/YaXpQrg1LriA==", "55af99d0-c86c-4e19-913e-b4b09ad683a3" });
        }
    }
}
