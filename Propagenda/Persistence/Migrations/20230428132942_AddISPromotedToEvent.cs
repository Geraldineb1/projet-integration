using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddISPromotedToEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPromoted",
                table: "Events",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "3a075c5d-6485-441f-9138-5006591da44f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "f01158b9-1bda-403c-a220-59c76f5b3236");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "c353ec09-3708-4851-82c9-2cbe51d6d7f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "75dac6d2-c0e4-42e2-bc61-de04e3cdbbc3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b15153ea-e172-432d-b4b4-5d9d94af8483", "AQAAAAEAACcQAAAAEGOVJZzImIbJ+zZhrJ9HLZxR9q6RLj6xAVXk2F7NWE6T1JhAbOWWW6LhWyhI+B8wvg==", "13e69016-7842-4a93-9bdf-df699349b442" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ba7cba7-98c4-42e9-9a95-552cd6cccd65", "AQAAAAEAACcQAAAAECYRBSgMWCjLAsQvmumf/rk1VP4YSUVfVDFP+d5LDzcSfL1JxudVKDWF4tkwXTMhYA==", "a328a22e-d6db-48f6-95f8-590ae6025abe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bf57ccf-5181-4f29-bd9c-73ce0223392b", "AQAAAAEAACcQAAAAEHHimk9f8RMYLAuYEJKeXgtlBWGxAtafq9LyOK+kWzmyGpkpZuTUKq/DKrR6G+Ly1A==", "876ea0f8-404f-441f-a335-bbc4b9834c59" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPromoted",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "ed7744d2-df0a-4cc6-a1be-1d28bbaec20e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "69e8d077-f0c4-4753-8591-508b536866de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "0f5941bb-5bb0-470e-8b04-b9c4ec49fe30");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "f9063aff-a2e7-498e-ba2c-e3b85598b648");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2837243-dd2c-412b-92fe-669d7659a1fc", "AQAAAAEAACcQAAAAEA+k3MbfVKln/Au5wavpMbPM6zMx9G6pastBS+nGEcGLUC62MdxlNvHhCN9DXGbNng==", "28eb778b-9a24-486d-8d44-9a7408f4e010" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec0e4b9f-0150-4093-9187-7900e833006e", "AQAAAAEAACcQAAAAEKl8LvtZh4Oc6xm2ozJfUhQcJr7i75aIrpu9gyW4Y0UmMgRyDBHRMBgxVwQPa3ROdQ==", "fd35c32f-73c0-464b-8a76-b815a4a34c8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8770a55-7072-4a02-b94a-e350d8b550f9", "AQAAAAEAACcQAAAAEJW13Bm32dXjU03VyDr8Bn33EQr39k0LtxG7zGHnjVjvXzuKM9Xy6vl9PgOj8lJadQ==", "0fee04b6-9991-47a6-86dd-8367ad80864e" });
        }
    }
}
