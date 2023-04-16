using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddImageToEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "7a1da270-c5e0-4dc1-834f-501ee0ca9627");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "98ff6879-9aa9-4dda-b1f8-926636bd8309");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "9126d9dd-9ae2-4f91-8253-43c7c6a9d054");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "0b83477e-bb6c-4472-933a-0bd271e92ec0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "833532ad-fa40-4cbc-b404-d67bd5b3f626", "AQAAAAEAACcQAAAAEEG+fJexADtwuAizxBw+FrH4DWJzlKrF+nok7RYkvwtZSMJIYV1+D1tSgS8CT7dc0g==", "f33d7b1a-adde-4200-bc0a-6951ad463b95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e011735-cfaa-4411-b662-4c7f9e39d379", "AQAAAAEAACcQAAAAEGPfc1SH6pEQarVcloU2AJOKSSaJjEvmo3VT1wNk7NItsF8WdITC4oXeqLd1BHspSw==", "759ec654-42a8-426f-b1d9-955e5beb4353" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5d31fa2-e8f3-4a90-be4e-327d22528efe", "AQAAAAEAACcQAAAAEAALImovOVVV7dg4MjmgdneBINmgGQh5dTJC8CcxkV9OrWwvKjIaycXENqioN1+2zw==", "be3bcaf3-0dd8-4c92-8aa3-9d0bfb7bd86d" });
        }
    }
}
