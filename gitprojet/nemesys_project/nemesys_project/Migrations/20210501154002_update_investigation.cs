using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nemesys_project.Migrations
{
    public partial class update_investigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08ad86f4-94b1-4952-afd4-99deb4309d9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9769ef22-5c86-4756-8550-0c80152fd850");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "Investigations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e8578c2-5ee7-430d-9912-1c047edf3dfa", "bbb245db-7e2a-45ff-822c-1b5138815f02", "reporter", "REPORTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "867b5310-9b64-41db-a2f9-1b0df0806ecb", "72e4aa4a-5f10-46fd-b94d-4c080b540966", "investigator", "INVESTIGATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "867b5310-9b64-41db-a2f9-1b0df0806ecb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e8578c2-5ee7-430d-9912-1c047edf3dfa");

            migrationBuilder.DropColumn(
                name: "DateOfCreation",
                table: "Investigations");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9769ef22-5c86-4756-8550-0c80152fd850", "ca0e6632-1b06-4ca6-9fdf-d3227f3589f6", "reporter", "REPORTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08ad86f4-94b1-4952-afd4-99deb4309d9f", "e13e10cf-3558-4e4e-b89a-ae73e67930ae", "investigator", "INVESTIGATOR" });
        }
    }
}
