using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddCommentToServiceRSVP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "ServiceReservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "68fdbe5f-2e92-4b0a-a5d3-e22c4c798481");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "6bbfc803-d9b6-49fa-8ee0-053b65685c6c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "b3038691-cff9-457a-8bc5-e62100b57a75");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "cd0f4e32-d727-40bb-9c12-30a8b6f069fe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a2fd42a-0e94-4527-8bd5-2b7a0c39eb3f", "AQAAAAEAACcQAAAAEKHA2n5my0XvdIOGs5+MxfJCeDI4Hb3Od6Ec5mEvuO+8DDN8srN2kr3dvz/cG/n12g==", "b799a796-9176-4844-893f-4985fc2734a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9146aae-e73f-4ba8-a82c-11c680f00ab8", "AQAAAAEAACcQAAAAEDZubuvQeT70zUg/1YjuC+vTWxDdamdVjgR2ZLEyo1CpHPwbnXkCdI3I1rjGpjn6Hg==", "e1f20927-c157-4dca-99b8-cfcc85df5d6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a3ab823-2e34-44f9-aeda-56759211745d", "AQAAAAEAACcQAAAAEP9zCxb7etrQB56VrsUvcm5wHwjjfxKQPICqW7IQFRo5Tu7rlTBwoPkMaYsk3knavg==", "ffd556bc-8267-454c-86af-140e610a048c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "ServiceReservations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "45428461-7b8f-4d5c-90ad-89fda122e77a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b2bbcefd-b3dd-42be-b9cf-df75c74bfeb2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "c5d3e11f-88c4-472d-a5d3-8ea4da6ec751");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "7a752714-499a-4b47-a1a0-c22cb9fb7927");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97087462-484b-4af6-8b28-70d471f97803", "AQAAAAEAACcQAAAAEMhxesB6ILM3PMO1VomNbHZcrIallUjj2MTP7LfoiYMThgl7UnTIfe3qSupcPdD3fQ==", "2af37b5a-a607-4101-a06f-eda48c67ef71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7128203-7805-44a9-8506-efc5eb68d352", "AQAAAAEAACcQAAAAEAuN+YRWj2zA7Xa/Z5OunVbSpangk0+vw/dHZZAu8TyN6kyjq6Li6CPESDidKT8WKA==", "8db21426-850e-449e-8863-c3a86432fe09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22fff8e6-337a-4d3f-b594-a56986e967dc", "AQAAAAEAACcQAAAAEGgiDBrNVKgK4IGRAq+qfOkPCZkCw/7C0vF08Evr0vJ+qufzrWGCI1yu/68nCqKDoQ==", "91178d50-47ff-487d-8f7b-6491d3e9cbbc" });
        }
    }
}
