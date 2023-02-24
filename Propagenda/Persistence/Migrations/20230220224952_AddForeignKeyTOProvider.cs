using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddForeignKeyTOProvider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Providers_AspNetUsers_UserId",
                table: "Providers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Providers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "27c34a66-ca14-4302-84c5-38d0649eee6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "aa676f0d-d7e0-4d96-9a53-8e4d7cf1e61d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "46c2245e-6b43-4537-a0bd-1679ae3948bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "a5d74ca1-2d52-4b8b-af36-15e07327a227");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62f77a9f-3fef-473d-bd55-f9d6ded16c9c", "AQAAAAEAACcQAAAAEB9rc1acB+Cor5dlQk3D+1Cfdy0j1C4dkFyIxqwTBB+6Uk3FBeXy+mA8C/G6iDPqKg==", "9ed442e0-2806-4b2e-a360-c7e7c52cef1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b7c001d-c18e-44d8-84f0-32c8c8db6fb2", "AQAAAAEAACcQAAAAEPSv3n2g1oDQojjAmbQuT68vDetT7juoyJ8V+4OjQKUyU8phrzs9FmQ9thvwqCruBg==", "65600320-da22-43b1-bd61-27b06e5223a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fed8a968-5d5a-4dd4-9aaf-f639bff6b030", "AQAAAAEAACcQAAAAEGLI96w5atZXmoLIeaQMMHfgJ6sVXLArxLQutqi7iA7RyflPLFaNqmH8uEpqcxa6bw==", "52a11a53-5f9f-47b3-9a96-5ab8b4b35b04" });

            migrationBuilder.AddForeignKey(
                name: "FK_Providers_AspNetUsers_UserId",
                table: "Providers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Providers_AspNetUsers_UserId",
                table: "Providers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Providers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "b3bfb1a8-5920-41dc-9067-dcac347d6f34");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "097c1147-0a78-4d20-9960-33eb046a6962");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "81cae8a5-a04c-4393-bd2d-b4ce2977e8bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "61f9fe4e-7291-45da-8c09-6f9c126e93cb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba7c5492-0a72-4f35-a7f7-5befba341b90", "AQAAAAEAACcQAAAAEK7F1dNKMNI2sOec5rElQJWkDLx/EzMEMbD8A+6chf5Q5A0fyXrkIOpZDpeUVDruQw==", "f9d1b441-96ba-4d25-980c-868bd035c76e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f2b328e-2fad-484e-8df8-41b06ad774a8", "AQAAAAEAACcQAAAAEGk0K8tfoEMf2Jrg1B7NcBtN7/rtXx3mJx10AS9yoAUGfQUcw837k3478bV8Mt4P3g==", "eefd69ce-74d9-4d0a-9790-e54ac4dd2049" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b997590a-43ac-4e98-bbec-e088a37d5466", "AQAAAAEAACcQAAAAEAuxR3ADfw9cE6V5M5hPVYQ/CV771rhXmWyf8xGTLeJ1nRR5WQlMcsKICImtHAkndg==", "e7a29fcf-b209-49f8-adf7-dc9da3dd88c4" });

            migrationBuilder.AddForeignKey(
                name: "FK_Providers_AspNetUsers_UserId",
                table: "Providers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
