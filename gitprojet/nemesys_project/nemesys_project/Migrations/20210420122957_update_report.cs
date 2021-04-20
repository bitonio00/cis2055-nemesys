using Microsoft.EntityFrameworkCore.Migrations;

namespace nemesys_project.Migrations
{
    public partial class update_report : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Reports");

            migrationBuilder.RenameColumn(
                name: "ProblemDate",
                table: "Reports",
                newName: "HazardDate");

            migrationBuilder.AddColumn<string>(
                name: "HazardLocation",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HazardType",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HazardLocation",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "HazardType",
                table: "Reports");

            migrationBuilder.RenameColumn(
                name: "HazardDate",
                table: "Reports",
                newName: "ProblemDate");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
