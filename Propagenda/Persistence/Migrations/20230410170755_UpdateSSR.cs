using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class UpdateSSR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceServiceReservation_ServiceReservations_ReservationsId",
                table: "ServiceServiceReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceServiceReservation",
                table: "ServiceServiceReservation");

            migrationBuilder.DropIndex(
                name: "IX_ServiceServiceReservation_ServicesId",
                table: "ServiceServiceReservation");

            migrationBuilder.RenameColumn(
                name: "ReservationsId",
                table: "ServiceServiceReservation",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "ServiceReservationsId",
                table: "ServiceServiceReservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceServiceReservation",
                table: "ServiceServiceReservation",
                columns: new[] { "ServicesId", "ServiceReservationsId" });

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

            migrationBuilder.CreateIndex(
                name: "IX_ServiceServiceReservation_ServiceReservationsId",
                table: "ServiceServiceReservation",
                column: "ServiceReservationsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceServiceReservation_ServiceReservations_ServiceReservationsId",
                table: "ServiceServiceReservation",
                column: "ServiceReservationsId",
                principalTable: "ServiceReservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceServiceReservation_ServiceReservations_ServiceReservationsId",
                table: "ServiceServiceReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceServiceReservation",
                table: "ServiceServiceReservation");

            migrationBuilder.DropIndex(
                name: "IX_ServiceServiceReservation_ServiceReservationsId",
                table: "ServiceServiceReservation");

            migrationBuilder.DropColumn(
                name: "ServiceReservationsId",
                table: "ServiceServiceReservation");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ServiceServiceReservation",
                newName: "ReservationsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceServiceReservation",
                table: "ServiceServiceReservation",
                columns: new[] { "ReservationsId", "ServicesId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "c6384bf5-10bd-4c4f-bfd8-d75f525d8f19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "d855dcda-b3e8-47d0-84e9-3d6a0807d949");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "d03cf493-b22a-4658-bd48-ec7f98447994");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "f0893e21-2f9b-4ec8-bacf-1d1592edf34f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96992006-87b9-4a31-b8bd-30c0a023c907", "AQAAAAEAACcQAAAAEFejhZXQ4Dfz0vXPHHWQzbY98ygLIEKnMDQ7R+h1pvCWYTRa83/Uy5JBNwy+fgJ5yg==", "bad0ecd8-e94c-4702-8c06-f7916c6150ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b420920b-f027-4ff8-9e38-1ff502155466", "AQAAAAEAACcQAAAAEK0flLSGESwdeDAoQu0BkCai7iXL62GNaelVhragi4f0WkFWCxlCX27DCCC+6gkFOA==", "21e1562a-44ca-490a-afd8-2e4075946684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a22061e5-b1da-44e1-a860-ea8c0792cdef", "AQAAAAEAACcQAAAAEL2WDYDlJoIFXJuURLV3LR1NdgKd1NEKvkjGlU+Z4u0W8wvl4hZ7+WFqIrEmXFo58g==", "475d5e53-4587-491e-a882-20479f8182cf" });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceServiceReservation_ServicesId",
                table: "ServiceServiceReservation",
                column: "ServicesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceServiceReservation_ServiceReservations_ReservationsId",
                table: "ServiceServiceReservation",
                column: "ReservationsId",
                principalTable: "ServiceReservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
