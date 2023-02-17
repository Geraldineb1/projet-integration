using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class testUpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b07a9f16-96dc-4a38-863c-6bfafd6e10de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "38e7d2be-e8c9-4ab9-9cea-ab538b680fba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "1b8063e2-7520-4992-bcf0-fef5c1fa1b79");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2be65a00-1b33-456b-831d-d83ddfa30e86", "AQAAAAEAACcQAAAAEJ5Eo3yFj8TptQEvYOx/yN5v0S7AERBm4/GqCOtZbGZ8FG+HwHZTtaTePR9iyTQp9w==", "42c11ec9-1405-4c55-a2c2-7eb32d323197" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d16c186-f99f-4222-b3a3-b0920644662e", "AQAAAAEAACcQAAAAEMvbQta374GiVm3IsXnH+KeaK2GRFfKd28Su79BqdvxyWZ1wMVgHByIjIsuDegt1wg==", "428bb435-f4de-4e81-8e82-7d17d1d6387b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a49ebe73-5f8f-4be2-83f5-9ab28edde7fa", "AQAAAAEAACcQAAAAEIXMLxliX5FS+JzrEfFF0N33Y3d2y1BAznAUJHFyPwiiZswhAwKFMwNS7xD0upxvow==", "7032dfb7-6f9f-4600-a37c-8d226cd5fbb6" });
        }
    }
}
