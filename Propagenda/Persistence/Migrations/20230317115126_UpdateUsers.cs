using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class UpdateUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "d255d21d-e5b8-4052-a43c-a4585f4ae8cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "f069b9c4-3919-4bb1-a40f-b2a588aa5d4f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "0fae4acb-e304-475a-ba49-88a0b1a68e2a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "1088cfc0-2bd0-4555-b6cf-04c9c63c8f91");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0926487-c4ea-4b16-934b-33cb5af18a8c", "AQAAAAEAACcQAAAAENC+HNjW6rroeaAx59aMFDbJgSBiWiL6dv6xSilJWrfjoDZQ4fQZ91Bk8hIsbpMRFw==", "f3592ee2-8270-41c1-a7b3-51041134a9a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "804c31ad-af5d-4555-8db6-bde0423da8b2", "AQAAAAEAACcQAAAAENIiprR7Rt/SrGhQLmymJao9iQAPLBuqVxVPAmVJcbw9aJSjKyGtBTk2HUy+xo9GXg==", "b48d0dd4-b313-4bd1-8c2f-70f7c44db708" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "716e965d-8e59-4afa-9f7f-b73ac9f8a89c", "AQAAAAEAACcQAAAAEOYV8Arm6zHICUp7tilyivcRkjwpFxkbYwT3LaASCDCa5xD8XXBJPnPbAVCP1jl8Bg==", "342c7c28-960d-47d9-a23c-e7559698051d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "5745d67f-2691-44d3-a143-fd4d1de4edad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "e7a95b19-5120-48aa-80a9-b7b3beea469f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "4dd5f711-6459-4221-93bb-596b8f1628d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "d376bc84-94a6-4178-93bf-239e0035546e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "428ccb9d-fada-4537-9297-bd3875b113ab", "AQAAAAEAACcQAAAAEHiegjk2/m/BZ0cv5BwOLb2PiMKig7sc6+SBSEl9/E3GAjJ5kDgmQFkvLe3UMCxXlw==", "537633f8-7161-4a73-8243-4a5cfa95598c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7996eeb6-962b-4b0a-bdc7-940be784939f", "AQAAAAEAACcQAAAAEBFMqvQs10ieiWC+3Kdiu1JDyjAgORQ4bcyRjxHJtbx9LUMAN6E1eM4eUppEvFCfWw==", "19726abe-c24b-4e1c-9884-2d0ff9404f4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9379f69c-d025-4495-8db8-4073ee04befa", "AQAAAAEAACcQAAAAEGIZ2hfAZ6BEvQyGTtddj3l3j6g0wdYb9uayquUbDzScVxhAhMRokrgYyPBzmbEDCA==", "a0b2c447-bc93-4732-b0f1-7264b6b5fb40" });
        }
    }
}
