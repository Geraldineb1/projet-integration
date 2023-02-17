using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Identity.Migrations
{
    public partial class FirstMigrationidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_AspNetUsers_ApplicationUserId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceReservation_AspNetUsers_ApplicationUserId",
                table: "ServiceReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketReservation_AspNetUsers_ApplicationUserId",
                table: "TicketReservation");

            migrationBuilder.DropIndex(
                name: "IX_TicketReservation_ApplicationUserId",
                table: "TicketReservation");

            migrationBuilder.DropIndex(
                name: "IX_ServiceReservation_ApplicationUserId",
                table: "ServiceReservation");

            migrationBuilder.DropIndex(
                name: "IX_Event_ApplicationUserId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "TicketReservation");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ServiceReservation");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Event");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "TicketReservation",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "ServiceReservation",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Provider",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "TicketReservation",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ServiceReservation",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Event",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9347aedb-1269-438e-8ac7-c461ee03bde4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "4ab213c8-6d82-4f70-80c8-7754addb1aae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "d261c972-e63a-4ad8-bad0-a9b0dd28c752");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6987522e-758b-403b-88b7-0c362a353ba7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb0f4509-32c4-45b2-bc2f-eee3e82af84d", "AQAAAAEAACcQAAAAELWuKShOjLNwceiUfGP1vO5ZVhKZXqtwtKRGQoCI1dQ88mu2vUxMGEmyLXaA5J496g==", "a9ef18a0-7a76-498c-bb89-2e4e4ed8fed2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8baaf0ce-bcf9-46b9-ac86-a16040b6c487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25d307ac-9af9-4130-8340-c070a172630b", "AQAAAAEAACcQAAAAEBVhyvieo/pYbyVeXSqtg/q1DsrC90w8o7uy0vUUgs3D6NdrEKfq/a8LE7uEu+DStg==", "05653d5d-1bf5-44d2-9787-2ec84a7102a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "413c8a68-7db3-49d9-a087-cbcab86c0825", "AQAAAAEAACcQAAAAEGSP+v79/0PK8sHgO//bRqF3RijJOECkr8ynMnZQHcff2ETDV27/Lnz/y33cU+W6cA==", "1ed87de6-9dee-4923-9223-824f8d684d1b" });

            migrationBuilder.CreateIndex(
                name: "IX_TicketReservation_ApplicationUserId",
                table: "TicketReservation",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReservation_ApplicationUserId",
                table: "ServiceReservation",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_ApplicationUserId",
                table: "Event",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_AspNetUsers_ApplicationUserId",
                table: "Event",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceReservation_AspNetUsers_ApplicationUserId",
                table: "ServiceReservation",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketReservation_AspNetUsers_ApplicationUserId",
                table: "TicketReservation",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
