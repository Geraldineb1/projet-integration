using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddImageToProvider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Providers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "28a355c4-40c7-463b-96ec-61ee49ddf711");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "939a19a2-b5ff-46ac-b525-ab884320dc85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "b60511aa-4ba7-4f95-ac5f-88265fb29bca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "8296ed59-491b-458a-b539-80fa135285a0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccf371dd-0f1e-4a5c-8d8d-29617bd2b1ac", "AQAAAAEAACcQAAAAEAiwoUrNvPuc+ZvVuUygKOkpqgof0yK3jTJxMwSybSCSuvG6DmON4g8mQeWRtcWxmQ==", "6ae88413-d514-4200-99d4-e5eb1aef054b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19e62abd-bd13-464b-813d-84976499789e", "AQAAAAEAACcQAAAAEMapE7EUYkOJb3XtBl6CGW5yTc/K+ixcO5HWBk6X1PNlinoDl/sbhpKX6fVlKJw25A==", "8ce7727c-9491-4a49-af3d-3cf8abce8afb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59014b91-609a-43df-8c08-72d931ee1c4c", "AQAAAAEAACcQAAAAEE+dOIY00WGqEK4oQq2M1/adZRZqskLwVBoYDAMg5kOPZzYdhuPT538uK+cfGZOpvg==", "1d1f91a7-ace4-47f6-9a63-6d139e85f165" });
        }
    }
}
