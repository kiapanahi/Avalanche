using Microsoft.EntityFrameworkCore.Migrations;

namespace Avalanche.Host.Migrations
{
    public partial class AddIndexOnOperationLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Msisdn",
                table: "OperationLogs",
                column: "Msisdn");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Msisdn",
                table: "OperationLogs");
        }
    }
}
