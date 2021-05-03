using Microsoft.EntityFrameworkCore.Migrations;

namespace nemesys_project.Migrations
{
    public partial class update_report : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Investigations_ReportRefId",
                table: "Investigations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "867b5310-9b64-41db-a2f9-1b0df0806ecb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e8578c2-5ee7-430d-9912-1c047edf3dfa");

            migrationBuilder.AddColumn<int>(
                name: "InvestigationRefId",
                table: "Reports",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b6c75e8-7139-42ce-8746-619e73cf9e5f", "b048e87a-c4a9-4d24-9fb0-303bcae9d0ab", "reporter", "REPORTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "041304f9-eb90-4caf-90f3-9c050d25162a", "53efe1fc-5ef3-4391-a53b-c9d8f48b6bca", "investigator", "INVESTIGATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_InvestigationRefId",
                table: "Reports",
                column: "InvestigationRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_ReportRefId",
                table: "Investigations",
                column: "ReportRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Investigations_InvestigationRefId",
                table: "Reports",
                column: "InvestigationRefId",
                principalTable: "Investigations",
                principalColumn: "InvestigationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Investigations_InvestigationRefId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_InvestigationRefId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Investigations_ReportRefId",
                table: "Investigations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "041304f9-eb90-4caf-90f3-9c050d25162a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b6c75e8-7139-42ce-8746-619e73cf9e5f");

            migrationBuilder.DropColumn(
                name: "InvestigationRefId",
                table: "Reports");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e8578c2-5ee7-430d-9912-1c047edf3dfa", "bbb245db-7e2a-45ff-822c-1b5138815f02", "reporter", "REPORTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "867b5310-9b64-41db-a2f9-1b0df0806ecb", "72e4aa4a-5f10-46fd-b94d-4c080b540966", "investigator", "INVESTIGATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_ReportRefId",
                table: "Investigations",
                column: "ReportRefId",
                unique: true);
        }
    }
}
