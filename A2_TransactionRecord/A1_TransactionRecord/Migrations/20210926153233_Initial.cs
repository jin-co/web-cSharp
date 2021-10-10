using Microsoft.EntityFrameworkCore.Migrations;

namespace A1_TransactionRecord.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransactionRecordKbaek7943s",
                columns: table => new
                {
                    TransactionRecordKbaek7943Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketSymbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SharePrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionRecordKbaek7943s", x => x.TransactionRecordKbaek7943Id);
                });

            migrationBuilder.InsertData(
                table: "TransactionRecordKbaek7943s",
                columns: new[] { "TransactionRecordKbaek7943Id", "CompanyName", "Quantity", "SharePrice", "TicketSymbol" },
                values: new object[] { 1, "Microsoft", 100, 123.45, "MSFT" });

            migrationBuilder.InsertData(
                table: "TransactionRecordKbaek7943s",
                columns: new[] { "TransactionRecordKbaek7943Id", "CompanyName", "Quantity", "SharePrice", "TicketSymbol" },
                values: new object[] { 2, "Google", 100, 2701.7600000000002, "GOOG" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionRecordKbaek7943s");
        }
    }
}
