using Microsoft.EntityFrameworkCore.Migrations;

namespace nemesys_project.Migrations
{
    public partial class update_vote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d877312-83c5-4c24-9f48-097b2c372330");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8eea8b1f-fa30-49ce-bb36-2552f6571856");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfVote",
                table: "NemesysUserVotes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf2a62dc-0998-453b-a5b2-f3d64b4b997c", "eb03a66a-7e58-4d6d-9d58-f530d0ee6839", "reporter", "REPORTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98bdb98d-6176-4a1b-bc76-93d8a5c3c4c5", "9fb93a49-76c3-469b-82b6-6e00f70be280", "investigator", "INVESTIGATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98bdb98d-6176-4a1b-bc76-93d8a5c3c4c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf2a62dc-0998-453b-a5b2-f3d64b4b997c");

            migrationBuilder.DropColumn(
                name: "TypeOfVote",
                table: "NemesysUserVotes");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8eea8b1f-fa30-49ce-bb36-2552f6571856", "56c24e86-180c-4867-9eff-f8ad9597830b", "reporter", "REPORTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d877312-83c5-4c24-9f48-097b2c372330", "d5f188b9-7aef-4b74-9371-4ac5eb58fde8", "investigator", "INVESTIGATOR" });
        }
    }
}
