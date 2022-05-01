using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HeartRateApp.Migrations
{
    public partial class TargetHeatRateGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TargetHeartRateGroupId",
                table: "HeartRateMeasurements",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TargetHeartRateGroups",
                columns: table => new
                {
                    TargetHeartRateGroupId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    LowerEndBPMValue = table.Column<int>(type: "int", nullable: false),
                    UpperEndBPMValue = table.Column<int>(type: "int", nullable: false),
                    AverageMaximumBPMValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetHeartRateGroups", x => x.TargetHeartRateGroupId);
                });

            migrationBuilder.InsertData(
                table: "TargetHeartRateGroups",
                columns: new[] { "TargetHeartRateGroupId", "Age", "AverageMaximumBPMValue", "LowerEndBPMValue", "UpperEndBPMValue" },
                values: new object[,]
                {
                    { "20years", 20, 200, 100, 170 },
                    { "30years", 30, 190, 92, 162 },
                    { "35years", 35, 185, 93, 157 },
                    { "40years", 40, 180, 90, 153 },
                    { "45years", 45, 175, 88, 149 },
                    { "50years", 50, 170, 85, 145 },
                    { "55years", 55, 165, 83, 140 },
                    { "60years", 60, 160, 80, 136 },
                    { "65years", 65, 155, 78, 132 },
                    { "70years", 70, 150, 75, 132 }
                });

            migrationBuilder.UpdateData(
                table: "HeartRateMeasurements",
                keyColumn: "HeartRateMeasurementId",
                keyValue: 1,
                columns: new[] { "MeasurementDate", "TargetHeartRateGroupId" },
                values: new object[] { new DateTime(2021, 10, 16, 14, 29, 57, 733, DateTimeKind.Local).AddTicks(1054), "45years" });

            migrationBuilder.UpdateData(
                table: "HeartRateMeasurements",
                keyColumn: "HeartRateMeasurementId",
                keyValue: 2,
                columns: new[] { "MeasurementDate", "TargetHeartRateGroupId" },
                values: new object[] { new DateTime(2021, 10, 16, 14, 29, 57, 733, DateTimeKind.Local).AddTicks(1699), "65years" });

            migrationBuilder.UpdateData(
                table: "HeartRateMeasurements",
                keyColumn: "HeartRateMeasurementId",
                keyValue: 3,
                columns: new[] { "MeasurementDate", "TargetHeartRateGroupId" },
                values: new object[] { new DateTime(2021, 10, 16, 14, 29, 57, 733, DateTimeKind.Local).AddTicks(1702), "20years" });

            migrationBuilder.CreateIndex(
                name: "IX_HeartRateMeasurements_TargetHeartRateGroupId",
                table: "HeartRateMeasurements",
                column: "TargetHeartRateGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_HeartRateMeasurements_TargetHeartRateGroups_TargetHeartRateGroupId",
                table: "HeartRateMeasurements",
                column: "TargetHeartRateGroupId",
                principalTable: "TargetHeartRateGroups",
                principalColumn: "TargetHeartRateGroupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeartRateMeasurements_TargetHeartRateGroups_TargetHeartRateGroupId",
                table: "HeartRateMeasurements");

            migrationBuilder.DropTable(
                name: "TargetHeartRateGroups");

            migrationBuilder.DropIndex(
                name: "IX_HeartRateMeasurements_TargetHeartRateGroupId",
                table: "HeartRateMeasurements");

            migrationBuilder.DropColumn(
                name: "TargetHeartRateGroupId",
                table: "HeartRateMeasurements");

            migrationBuilder.UpdateData(
                table: "HeartRateMeasurements",
                keyColumn: "HeartRateMeasurementId",
                keyValue: 1,
                column: "MeasurementDate",
                value: new DateTime(2021, 10, 12, 10, 20, 50, 994, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "HeartRateMeasurements",
                keyColumn: "HeartRateMeasurementId",
                keyValue: 2,
                column: "MeasurementDate",
                value: new DateTime(2021, 10, 12, 10, 20, 50, 994, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "HeartRateMeasurements",
                keyColumn: "HeartRateMeasurementId",
                keyValue: 3,
                column: "MeasurementDate",
                value: new DateTime(2021, 10, 12, 10, 20, 50, 994, DateTimeKind.Local).AddTicks(3114));
        }
    }
}
