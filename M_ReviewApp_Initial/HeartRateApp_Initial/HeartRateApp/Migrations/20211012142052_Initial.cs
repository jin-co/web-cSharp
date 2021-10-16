using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HeartRateApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeartRateMeasurements",
                columns: table => new
                {
                    HeartRateMeasurementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BPMValue = table.Column<int>(type: "int", nullable: false),
                    MeasurementDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeartRateMeasurements", x => x.HeartRateMeasurementId);
                });

            migrationBuilder.InsertData(
                table: "HeartRateMeasurements",
                columns: new[] { "HeartRateMeasurementId", "BPMValue", "MeasurementDate" },
                values: new object[] { 1, 143, new DateTime(2021, 10, 12, 10, 20, 50, 994, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.InsertData(
                table: "HeartRateMeasurements",
                columns: new[] { "HeartRateMeasurementId", "BPMValue", "MeasurementDate" },
                values: new object[] { 2, 156, new DateTime(2021, 10, 12, 10, 20, 50, 994, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.InsertData(
                table: "HeartRateMeasurements",
                columns: new[] { "HeartRateMeasurementId", "BPMValue", "MeasurementDate" },
                values: new object[] { 3, 167, new DateTime(2021, 10, 12, 10, 20, 50, 994, DateTimeKind.Local).AddTicks(3114) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeartRateMeasurements");
        }
    }
}
