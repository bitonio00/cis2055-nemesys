using Microsoft.EntityFrameworkCore.Migrations;

namespace nemesys_project.Migrations
{
    public partial class update_invest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b37a348-5a94-4613-bb7e-d65df0c21ac9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e583647a-fd32-45e1-8883-c1899a35b852");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9769ef22-5c86-4756-8550-0c80152fd850", "ca0e6632-1b06-4ca6-9fdf-d3227f3589f6", "reporter", "REPORTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08ad86f4-94b1-4952-afd4-99deb4309d9f", "e13e10cf-3558-4e4e-b89a-ae73e67930ae", "investigator", "INVESTIGATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08ad86f4-94b1-4952-afd4-99deb4309d9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9769ef22-5c86-4756-8550-0c80152fd850");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b37a348-5a94-4613-bb7e-d65df0c21ac9", "5a137798-f51b-4126-85e4-c4be76ce6def", "reporter", "REPORTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e583647a-fd32-45e1-8883-c1899a35b852", "10d003fc-f44f-4a5d-9655-291064ade02f", "investigator", "INVESTIGATOR" });
        }
    }
}
