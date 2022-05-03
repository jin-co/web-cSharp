using Microsoft.EntityFrameworkCore.Migrations;

namespace BPApp.Migrations
{
    public partial class Position : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PositionId",
                table: "BPMeasurements",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PositionId", "Name" },
                values: new object[] { "Standing", "Standing" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PositionId", "Name" },
                values: new object[] { "Sitting", "Sitting" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PositionId", "Name" },
                values: new object[] { "Lying down", "Lying down" });

            migrationBuilder.UpdateData(
                table: "BPMeasurements",
                keyColumn: "BPMeasurementId",
                keyValue: 1,
                column: "PositionId",
                value: "Lying down");

            migrationBuilder.UpdateData(
                table: "BPMeasurements",
                keyColumn: "BPMeasurementId",
                keyValue: 2,
                column: "PositionId",
                value: "Standing");

            migrationBuilder.UpdateData(
                table: "BPMeasurements",
                keyColumn: "BPMeasurementId",
                keyValue: 3,
                column: "PositionId",
                value: "Sitting");

            migrationBuilder.UpdateData(
                table: "BPMeasurements",
                keyColumn: "BPMeasurementId",
                keyValue: 4,
                column: "PositionId",
                value: "Standing");

            migrationBuilder.UpdateData(
                table: "BPMeasurements",
                keyColumn: "BPMeasurementId",
                keyValue: 5,
                column: "PositionId",
                value: "Sitting");

            migrationBuilder.CreateIndex(
                name: "IX_BPMeasurements_PositionId",
                table: "BPMeasurements",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_BPMeasurements_Positions_PositionId",
                table: "BPMeasurements",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "PositionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BPMeasurements_Positions_PositionId",
                table: "BPMeasurements");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_BPMeasurements_PositionId",
                table: "BPMeasurements");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "BPMeasurements");
        }
    }
}
