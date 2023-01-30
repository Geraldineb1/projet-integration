using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class FeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Image", "Label" },
                values: new object[] { 1, "urlpardefaut", "Concert" });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Image", "Label" },
                values: new object[] { 2, "urlpardefaut", "Securité" });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Image", "Label" },
                values: new object[] { 3, "urlpardefaut", "Technique" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
