using Microsoft.EntityFrameworkCore.Migrations;

namespace nemesys_project.Migrations
{
    public partial class loginadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Reporters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Reporters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Reporters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Reporters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Reporters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Investigators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Investigators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Investigators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Investigators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Investigators",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Reporters");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Reporters");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Reporters");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Reporters");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Reporters");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Investigators");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Investigators");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Investigators");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Investigators");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Investigators");
        }
    }
}
