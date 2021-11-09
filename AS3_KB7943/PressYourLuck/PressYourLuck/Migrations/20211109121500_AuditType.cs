using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PressYourLuck.Migrations
{
    public partial class AuditType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuditTypeId",
                table: "Audits",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AuditTypes",
                columns: table => new
                {
                    AuditTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditTypes", x => x.AuditTypeId);
                });

            migrationBuilder.InsertData(
                table: "AuditTypes",
                columns: new[] { "AuditTypeId", "Name" },
                values: new object[,]
                {
                    { "Cash In", "Cash In" },
                    { "Cash Out", "Cash Out" },
                    { "Win", "Win" },
                    { "Lose", "Lose" }
                });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "AuditId",
                keyValue: 1,
                columns: new[] { "AuditTypeId", "CreatedDate" },
                values: new object[] { "Cash In", new DateTime(2021, 11, 9, 21, 14, 59, 876, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "AuditId",
                keyValue: 2,
                columns: new[] { "AuditTypeId", "CreatedDate" },
                values: new object[] { "Cash Out", new DateTime(2021, 11, 9, 21, 14, 59, 877, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "AuditId",
                keyValue: 3,
                columns: new[] { "AuditTypeId", "CreatedDate" },
                values: new object[] { "Win", new DateTime(2021, 11, 9, 21, 14, 59, 877, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "AuditId",
                keyValue: 4,
                columns: new[] { "AuditTypeId", "CreatedDate" },
                values: new object[] { "Lose", new DateTime(2021, 11, 9, 21, 14, 59, 877, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.CreateIndex(
                name: "IX_Audits_AuditTypeId",
                table: "Audits",
                column: "AuditTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Audits_AuditTypes_AuditTypeId",
                table: "Audits",
                column: "AuditTypeId",
                principalTable: "AuditTypes",
                principalColumn: "AuditTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audits_AuditTypes_AuditTypeId",
                table: "Audits");

            migrationBuilder.DropTable(
                name: "AuditTypes");

            migrationBuilder.DropIndex(
                name: "IX_Audits_AuditTypeId",
                table: "Audits");

            migrationBuilder.DropColumn(
                name: "AuditTypeId",
                table: "Audits");

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "AuditId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 9, 21, 12, 47, 421, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "AuditId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 9, 21, 12, 47, 422, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "AuditId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 9, 21, 12, 47, 422, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "AuditId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 9, 21, 12, 47, 422, DateTimeKind.Local).AddTicks(4470));
        }
    }
}
