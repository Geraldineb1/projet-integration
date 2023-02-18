using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddApprovalColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isApproved",
                table: "Services",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Providers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b597bae0-4378-4016-8eee-25e3b126e570");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "80626b82-1c33-41af-81d2-c628b9fa6e82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "4e2c8294-32d2-4d8c-b116-83af37c2f6eb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89166fab-7567-4d1d-a188-1984020ab6b0", "AQAAAAEAACcQAAAAEMkyu+XQbCbbc7S/kc8aiHQNVy9VNJT5nH++/CeZBiOIKdXEpecJlVgjHaUTfCC2XQ==", "c9e8bc20-efa9-45bb-a21e-28b1e588a794" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "878e258d-9ed8-4738-8d3c-2c705b3d3f57", "AQAAAAEAACcQAAAAEELXJZVKPPCtapDBEa5i+Ndk+xzE7LCJbkHaXJ1aHJFERTCCEmzb1Br6IqfqxJcKEQ==", "f5c23ac7-7f24-4c6c-90e4-af0909e5b686" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "899682dd-0f26-46bc-915b-df34479f2424", "AQAAAAEAACcQAAAAECX6LCwNqH1n1hNyzwXuEA2mwvTXSvCrIUYpeHuyXV9LcIGJXHpIbTMrS7Dnc0QHpw==", "b8cc10c1-e32a-4db5-84cf-5f53a8187609" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isApproved",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Providers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "ccd76647-6e22-4fa8-ad15-c83ea03b5524");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "abfacbc3-da2d-431f-b036-f879385766c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "75af033a-67b0-4fab-86a0-221c07edd9c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4428d67-ad41-46e3-9e76-2d4e461259bb", "AQAAAAEAACcQAAAAEPi53yScnnSZPO9bp09YKu/thgIqOpthjy+tT+ikmV7u/oPaf4cHowNtErolzu0n4A==", "67079f75-d103-41c7-bb5e-a43d5c7586ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "856c0f62-6714-4bf2-8558-12c9e5813c6f", "AQAAAAEAACcQAAAAEFY5fNBTn2sQJ/ChSXKYZ+dAgc71BdkJR0syAwgWT8KNpySQhqjEAgwLAa/TWBsW1w==", "77f7a8b4-5060-4cc7-a5fa-74e71927a632" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1604da22-2f11-4094-a352-663de37feb53", "AQAAAAEAACcQAAAAEHWyX7FyU9s5qnLt40u5CtrxQfgxxEQW9NWtnIxTaSHJdgwfsDXeGY6ogZO8mJ5kNg==", "5a5caa9b-149d-4e45-a5da-be5e89fb1c83" });
        }
    }
}
