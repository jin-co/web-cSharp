using Microsoft.EntityFrameworkCore.Migrations;

namespace A2_TransactionRecord.Migrations
{
    public partial class Company : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "TransactionRecordKbaek7943s");

            migrationBuilder.DropColumn(
                name: "TicketSymbol",
                table: "TransactionRecordKbaek7943s");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "TransactionRecordKbaek7943s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TickerSymbol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Name", "TickerSymbol" },
                values: new object[] { 1, "USA", "Microsoft", "MSFT" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Name", "TickerSymbol" },
                values: new object[] { 2, "USA", "Google", "GOOG" });

            migrationBuilder.UpdateData(
                table: "TransactionRecordKbaek7943s",
                keyColumn: "TransactionRecordKbaek7943Id",
                keyValue: 1,
                column: "CompanyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TransactionRecordKbaek7943s",
                keyColumn: "TransactionRecordKbaek7943Id",
                keyValue: 2,
                column: "CompanyId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRecordKbaek7943s_CompanyId",
                table: "TransactionRecordKbaek7943s",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionRecordKbaek7943s_Companies_CompanyId",
                table: "TransactionRecordKbaek7943s",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionRecordKbaek7943s_Companies_CompanyId",
                table: "TransactionRecordKbaek7943s");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_TransactionRecordKbaek7943s_CompanyId",
                table: "TransactionRecordKbaek7943s");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "TransactionRecordKbaek7943s");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "TransactionRecordKbaek7943s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TicketSymbol",
                table: "TransactionRecordKbaek7943s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TransactionRecordKbaek7943s",
                keyColumn: "TransactionRecordKbaek7943Id",
                keyValue: 1,
                columns: new[] { "CompanyName", "TicketSymbol" },
                values: new object[] { "Microsoft", "MSFT" });

            migrationBuilder.UpdateData(
                table: "TransactionRecordKbaek7943s",
                keyColumn: "TransactionRecordKbaek7943Id",
                keyValue: 2,
                columns: new[] { "CompanyName", "TicketSymbol" },
                values: new object[] { "Google", "GOOG" });
        }
    }
}
