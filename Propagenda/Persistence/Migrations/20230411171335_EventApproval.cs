using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class EventApproval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Events",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Events",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "51ab9e6e-9483-4f71-9a2d-b06b9137fa22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "51a05aa9-7e87-4a4d-81de-764ec4a9791c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "b7b2103b-3542-4c67-9ed7-2cfcfdf8f258");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "99705cb6-9bea-41f0-97d2-ffbe3541646f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "832ef92d-80e2-43cb-ace0-21dc7b8aa27f", "AQAAAAEAACcQAAAAELvS8pH9mPiJGdxAvWWWMsAUKaskDLZm8g/cYWJXXhLDetmXGXX7446Y2Gu9GWJ1nw==", "f120d7e1-be3a-4084-be68-aa0d55fc3176" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46e9e91c-6b43-47ee-8fb6-25849bb5b282", "AQAAAAEAACcQAAAAEDDFcCmDKUFsC3OUsf+5iQ1svf9+NsWd9qCR9wNAqeBpQe23ib5I9OfGfyBW9ypOxw==", "29f5fee2-a2b7-40f0-b6b1-34fb493a6f20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48a15404-9175-487e-b31a-536846813117", "AQAAAAEAACcQAAAAEKjkOKYlN920VYd+oNIdqaatsC0BBN0wQjB4npcLgQu0cpFwQaOfioFx571xt398WA==", "01945aff-1a78-4122-9f04-c64dc63e1b2c" });
        }
    }
}
