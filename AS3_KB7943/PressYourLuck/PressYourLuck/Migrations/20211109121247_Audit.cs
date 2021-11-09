using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PressYourLuck.Migrations
{
    public partial class Audit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audits",
                columns: table => new
                {
                    AuditId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audits", x => x.AuditId);
                });

            migrationBuilder.InsertData(
                table: "Audits",
                columns: new[] { "AuditId", "Amount", "CreatedDate", "PlayerName" },
                values: new object[,]
                {
                    { 1, 400.0, new DateTime(2021, 11, 9, 21, 12, 47, 421, DateTimeKind.Local).AddTicks(4965), "Jack" },
                    { 2, 400.0, new DateTime(2021, 11, 9, 21, 12, 47, 422, DateTimeKind.Local).AddTicks(4452), "Rack" },
                    { 3, 430.0, new DateTime(2021, 11, 9, 21, 12, 47, 422, DateTimeKind.Local).AddTicks(4467), "Hack" },
                    { 4, 450.0, new DateTime(2021, 11, 9, 21, 12, 47, 422, DateTimeKind.Local).AddTicks(4470), "Zack" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audits");
        }
    }
}
