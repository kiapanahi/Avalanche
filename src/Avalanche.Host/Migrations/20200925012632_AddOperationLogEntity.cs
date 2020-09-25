using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avalanche.Host.Migrations
{
    public partial class AddOperationLogEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperationLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Msisdn = table.Column<string>(type: "varchar(11)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(512)", nullable: false),
                    SentDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    BrokerResponse = table.Column<string>(type: "nvarchar(1024)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationLogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationLogs");
        }
    }
}
