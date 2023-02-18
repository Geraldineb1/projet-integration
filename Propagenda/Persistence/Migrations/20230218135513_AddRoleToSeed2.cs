using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddRoleToSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "dd6d3850-8eaa-4ca9-aab7-c33ec247c829");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "d1ca3fac-3f39-47c6-8182-b112432936b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "1ee4d756-c921-4cf7-80d0-8b6227d6b580");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "94fb4df0-8a5f-4a44-a456-66d248c0b230");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cee00c7-8bfb-4352-99e3-d8d8e95ef57f", "AQAAAAEAACcQAAAAELEoOWTv+KSIhPv+o1IUJVxNW2Gk6DZ8b8H/b26iVb24cSVqLD9yeZGh9GMbLs6sWA==", "c81c7d30-3a64-4acb-b66a-d8ce6c2c359c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "356e1133-e173-40de-89e9-a5640c6f205e", "AQAAAAEAACcQAAAAEIORg2uUqy4KGiRGlgKmzi8l+aT2MVxvfP33kczIyYyAYFXiRz3DBCyt2yWACevXYw==", "0b51d13e-bb5b-40e9-92b9-a09cb2820d11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "870fd79d-78b8-48cc-a08e-f31ad39f7c9b", "AQAAAAEAACcQAAAAENUNoN9Msyboc8Zuu4o3ymffhNBmcvn39K3pY/GWsMnyYTiy/HB5rF+o4Z8kmdBrcQ==", "5d103888-5dca-4278-a54d-fe3b91cbddb5" });
        }
    }
}
