using Microsoft.EntityFrameworkCore.Migrations;

namespace nemesys_project.Migrations
{
    public partial class updat_reportsimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6587c09-6b7e-4110-bed1-5df6461c7784");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd9a6643-8bfb-4f52-b851-527d1862f1e4");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7545bdd3-9ee9-481b-b3e6-da1b179f747a", "97eff1ca-e2a4-4e0f-a579-cc38557a6bac", "reporter", "REPORTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4574e0e9-e20f-42b2-b0b6-d2f6a36cd153", "bc3a3f72-68f9-4bb6-804a-50d9af777eb7", "investigator", "INVESTIGATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4574e0e9-e20f-42b2-b0b6-d2f6a36cd153");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7545bdd3-9ee9-481b-b3e6-da1b179f747a");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Reports");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6587c09-6b7e-4110-bed1-5df6461c7784", "e897ee4e-5fe6-4603-a409-79962e8c7962", "reporter", "REPORTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd9a6643-8bfb-4f52-b851-527d1862f1e4", "b1086b55-338c-4b13-a8c4-8f541a4b9fa4", "investigator", "INVESTIGATOR" });
        }
    }
}
