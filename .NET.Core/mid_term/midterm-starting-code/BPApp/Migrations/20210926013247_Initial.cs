using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BPApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BPMeasurements",
                columns: table => new
                {
                    BPMeasurementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Systolic = table.Column<int>(type: "int", nullable: false),
                    Diastolic = table.Column<int>(type: "int", nullable: false),
                    MeasurementDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BPMeasurements", x => x.BPMeasurementId);
                });

            migrationBuilder.InsertData(
                table: "BPMeasurements",
                columns: new[] { "BPMeasurementId", "Diastolic", "MeasurementDate", "Systolic" },
                values: new object[,]
                {
                    { 1, 78, new DateTime(1996, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 118 },
                    { 2, 79, new DateTime(1998, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 122 },
                    { 3, 85, new DateTime(2002, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 131 },
                    { 4, 91, new DateTime(2005, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 142 },
                    { 5, 121, new DateTime(2008, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 181 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BPMeasurements");
        }
    }
}
