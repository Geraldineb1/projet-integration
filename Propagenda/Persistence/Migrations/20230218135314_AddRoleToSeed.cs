using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddRoleToSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d012e04-e5c3-4ee0-baed-53d4778470a6", "dd6d3850-8eaa-4ca9-aab7-c33ec247c829", "Provider", "PROVIDER" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6");

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
    }
}
