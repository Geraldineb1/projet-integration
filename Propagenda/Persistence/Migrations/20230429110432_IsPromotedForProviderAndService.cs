using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class IsPromotedForProviderAndService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPromoted",
                table: "Services",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPromoted",
                table: "Providers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                column: "ConcurrencyStamp",
                value: "28a355c4-40c7-463b-96ec-61ee49ddf711");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "939a19a2-b5ff-46ac-b525-ab884320dc85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "b60511aa-4ba7-4f95-ac5f-88265fb29bca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "8296ed59-491b-458a-b539-80fa135285a0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "047a1feb-b527-43af-8194-f1e3c92b7607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccf371dd-0f1e-4a5c-8d8d-29617bd2b1ac", "AQAAAAEAACcQAAAAEAiwoUrNvPuc+ZvVuUygKOkpqgof0yK3jTJxMwSybSCSuvG6DmON4g8mQeWRtcWxmQ==", "6ae88413-d514-4200-99d4-e5eb1aef054b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19e62abd-bd13-464b-813d-84976499789e", "AQAAAAEAACcQAAAAEMapE7EUYkOJb3XtBl6CGW5yTc/K+ixcO5HWBk6X1PNlinoDl/sbhpKX6fVlKJw25A==", "8ce7727c-9491-4a49-af3d-3cf8abce8afb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed742fb6-87ff-40a9-a30b-717211f5d456",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59014b91-609a-43df-8c08-72d931ee1c4c", "AQAAAAEAACcQAAAAEE+dOIY00WGqEK4oQq2M1/adZRZqskLwVBoYDAMg5kOPZzYdhuPT538uK+cfGZOpvg==", "1d1f91a7-ace4-47f6-9a63-6d139e85f165" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPromoted",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "IsPromoted",
                table: "Providers");

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
    }
}
