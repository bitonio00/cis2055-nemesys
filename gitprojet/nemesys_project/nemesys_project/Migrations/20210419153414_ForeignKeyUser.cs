using Microsoft.EntityFrameworkCore.Migrations;

namespace nemesys_project.Migrations
{
    public partial class ForeignKeyUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NemesysUserId",
                table: "Reports",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NemesysUserId",
                table: "Investigations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_NemesysUserId",
                table: "Reports",
                column: "NemesysUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_NemesysUserId",
                table: "Investigations",
                column: "NemesysUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investigations_AspNetUsers_NemesysUserId",
                table: "Investigations",
                column: "NemesysUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_NemesysUserId",
                table: "Reports",
                column: "NemesysUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investigations_AspNetUsers_NemesysUserId",
                table: "Investigations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_AspNetUsers_NemesysUserId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_NemesysUserId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Investigations_NemesysUserId",
                table: "Investigations");

            migrationBuilder.DropColumn(
                name: "NemesysUserId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "NemesysUserId",
                table: "Investigations");
        }
    }
}
