using Microsoft.EntityFrameworkCore.Migrations;

namespace A1_TransactionRecord.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    TransactionTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commission = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.TransactionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "TransactionRecordKbaek7943s",
                columns: table => new
                {
                    TransactionRecordKbaek7943Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketSymbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SharePrice = table.Column<double>(type: "float", nullable: false),
                    TransactionTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionRecordKbaek7943s", x => x.TransactionRecordKbaek7943Id);
                    table.ForeignKey(
                        name: "FK_TransactionRecordKbaek7943s_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "TransactionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "TransactionTypeId", "Commission", "Name" },
                values: new object[] { "Buy", 5.9900000000000002, "Buy" });

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "TransactionTypeId", "Commission", "Name" },
                values: new object[] { "Sell", 5.4000000000000004, "Sell" });

            migrationBuilder.InsertData(
                table: "TransactionRecordKbaek7943s",
                columns: new[] { "TransactionRecordKbaek7943Id", "CompanyName", "Quantity", "SharePrice", "TicketSymbol", "TransactionTypeId" },
                values: new object[] { 2, "Google", 100, 2701.7600000000002, "GOOG", "Buy" });

            migrationBuilder.InsertData(
                table: "TransactionRecordKbaek7943s",
                columns: new[] { "TransactionRecordKbaek7943Id", "CompanyName", "Quantity", "SharePrice", "TicketSymbol", "TransactionTypeId" },
                values: new object[] { 1, "Microsoft", 100, 123.45, "MSFT", "Sell" });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRecordKbaek7943s_TransactionTypeId",
                table: "TransactionRecordKbaek7943s",
                column: "TransactionTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionRecordKbaek7943s");

            migrationBuilder.DropTable(
                name: "TransactionTypes");
        }
    }
}
