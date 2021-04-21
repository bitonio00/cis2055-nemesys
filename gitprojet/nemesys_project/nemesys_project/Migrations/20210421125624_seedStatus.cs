using Microsoft.EntityFrameworkCore.Migrations;

namespace nemesys_project.Migrations
{
    public partial class seedStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "StatusOfReport" },
                values: new object[] { 1, "closed" });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "StatusOfReport" },
                values: new object[] { 2, "being investigated" });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "StatusOfReport" },
                values: new object[] { 3, "no action required" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 3);
        }
    }
}
