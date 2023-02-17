using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Identity.Migrations
{
    public partial class TestFirstMigrationidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_AspNetUsers_UserId1",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Provider_AspNetUsers_UserId1",
                table: "Provider");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceReservation_AspNetUsers_UserId1",
                table: "ServiceReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketReservation_AspNetUsers_UserId1",
                table: "TicketReservation");

            migrationBuilder.DropIndex(
                name: "IX_TicketReservation_UserId1",
                table: "TicketReservation");

            migrationBuilder.DropIndex(
                name: "IX_ServiceReservation_UserId1",
                table: "ServiceReservation");

            migrationBuilder.DropIndex(
                name: "IX_Provider_UserId1",
                table: "Provider");

            migrationBuilder.DropIndex(
                name: "IX_Event_UserId1",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "TicketReservation");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "ServiceReservation");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Provider");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Event");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TicketReservation",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ServiceReservation",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Provider",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "7c448f78-da10-430a-b1ea-fdf93602e9da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "f264f939-ff24-4880-8d08-8d4d5e200b3f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "70ad98cd-7685-46e1-b5e2-7ef6d34e2dbb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6987522e-758b-403b-88b7-0c362a353ba7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd4043d1-85f3-4f9f-b355-d9968d167efe", "AQAAAAEAACcQAAAAEAb6d/7NhzowDOQfJyDeKwUvQpNdsw7Y26SKZe0VVWQzsJUaUkP/EcPTAlwIXoap3Q==", "e6cabf4b-022c-420c-936a-34386713b8d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8baaf0ce-bcf9-46b9-ac86-a16040b6c487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daec9519-e850-450f-899e-4a3b61d90204", "AQAAAAEAACcQAAAAEG8OsokhxbRQvRKxuJQJCdszGM2xyaeoLx6q33LGtRiRl8ZBLbRDVpl2agUkwiW83w==", "d4454968-500b-4e0a-82c5-1d95cc1f6462" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e9a3463-baa8-4852-85ce-97b1226afee1", "AQAAAAEAACcQAAAAEM6iOCaZILCavx3s7MkBTNuDfqDYUe/vw6cdW+CekTe4ST6h4NeH3Tf50/t6s7roMA==", "0adcd582-f573-4e38-8c78-6614be8b015c" });

            migrationBuilder.CreateIndex(
                name: "IX_TicketReservation_UserId",
                table: "TicketReservation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReservation_UserId",
                table: "ServiceReservation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_UserId",
                table: "Provider",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_UserId",
                table: "Event",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_AspNetUsers_UserId",
                table: "Event",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provider_AspNetUsers_UserId",
                table: "Provider",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceReservation_AspNetUsers_UserId",
                table: "ServiceReservation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketReservation_AspNetUsers_UserId",
                table: "TicketReservation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_AspNetUsers_UserId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Provider_AspNetUsers_UserId",
                table: "Provider");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceReservation_AspNetUsers_UserId",
                table: "ServiceReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketReservation_AspNetUsers_UserId",
                table: "TicketReservation");

            migrationBuilder.DropIndex(
                name: "IX_TicketReservation_UserId",
                table: "TicketReservation");

            migrationBuilder.DropIndex(
                name: "IX_ServiceReservation_UserId",
                table: "ServiceReservation");

            migrationBuilder.DropIndex(
                name: "IX_Provider_UserId",
                table: "Provider");

            migrationBuilder.DropIndex(
                name: "IX_Event_UserId",
                table: "Event");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "TicketReservation",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "TicketReservation",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ServiceReservation",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "ServiceReservation",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Provider",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Provider",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Event",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "4941ff9a-3f4c-48ba-8b23-462410db55eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "b4af2440-72ac-4225-8794-11c1e4bf25f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "6d54e46f-56ea-4aae-8ad3-8f662bbfd3fe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6987522e-758b-403b-88b7-0c362a353ba7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "410c0144-b4ab-45f9-b090-5f48a14d8af8", "AQAAAAEAACcQAAAAEFumrcC+BypZHY0bd0Fr1a5hR3kNEeJ1qcj49604BH3tYxLNGWNj9W+UmAfauQ+ImQ==", "a89b9bac-c8c2-4ff3-9f6b-9e412930f447" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8baaf0ce-bcf9-46b9-ac86-a16040b6c487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a404dacd-d5b2-405a-9b36-61a0b588edb8", "AQAAAAEAACcQAAAAEAV9ykUteoZ7SIioNXHwQ7qrt4d0j3+f494ZbfLMOwJQOJ7/YwQItBBK0GVFpUsFjQ==", "d591002f-7ccd-4f74-94c9-88ed0253b043" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18e7db7a-f275-4b25-9f18-da604e25e539", "AQAAAAEAACcQAAAAEBWHtqYMypKFrDsHBVUdops5KeUb37ZV/5o6nQOkFl238SMgotN/2siCFJgoFy88iQ==", "c87be659-311e-4d18-a900-bf39cc792544" });

            migrationBuilder.CreateIndex(
                name: "IX_TicketReservation_UserId1",
                table: "TicketReservation",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReservation_UserId1",
                table: "ServiceReservation",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_UserId1",
                table: "Provider",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Event_UserId1",
                table: "Event",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_AspNetUsers_UserId1",
                table: "Event",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provider_AspNetUsers_UserId1",
                table: "Provider",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceReservation_AspNetUsers_UserId1",
                table: "ServiceReservation",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketReservation_AspNetUsers_UserId1",
                table: "TicketReservation",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
