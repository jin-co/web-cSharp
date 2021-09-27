using Microsoft.EntityFrameworkCore.Migrations;

namespace A1_TransactionRecord.Migrations
{
    public partial class TransactionType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TicketSymbol",
                table: "TransactionRecordKbaek7943s",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "TransactionRecordKbaek7943s",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "TransactionTypeId",
                table: "TransactionRecordKbaek7943s",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "TransactionTypeId", "Commission", "Name" },
                values: new object[] { "Buy", 5.9900000000000002, "Buy" });

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "TransactionTypeId", "Commission", "Name" },
                values: new object[] { "Sell", 5.4000000000000004, "Sell" });

            migrationBuilder.UpdateData(
                table: "TransactionRecordKbaek7943s",
                keyColumn: "TransactionRecordKbaek7943Id",
                keyValue: 1,
                column: "TransactionTypeId",
                value: "Sell");

            migrationBuilder.UpdateData(
                table: "TransactionRecordKbaek7943s",
                keyColumn: "TransactionRecordKbaek7943Id",
                keyValue: 2,
                column: "TransactionTypeId",
                value: "Buy");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRecordKbaek7943s_TransactionTypeId",
                table: "TransactionRecordKbaek7943s",
                column: "TransactionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionRecordKbaek7943s_TransactionTypes_TransactionTypeId",
                table: "TransactionRecordKbaek7943s",
                column: "TransactionTypeId",
                principalTable: "TransactionTypes",
                principalColumn: "TransactionTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionRecordKbaek7943s_TransactionTypes_TransactionTypeId",
                table: "TransactionRecordKbaek7943s");

            migrationBuilder.DropTable(
                name: "TransactionTypes");

            migrationBuilder.DropIndex(
                name: "IX_TransactionRecordKbaek7943s_TransactionTypeId",
                table: "TransactionRecordKbaek7943s");

            migrationBuilder.DropColumn(
                name: "TransactionTypeId",
                table: "TransactionRecordKbaek7943s");

            migrationBuilder.AlterColumn<string>(
                name: "TicketSymbol",
                table: "TransactionRecordKbaek7943s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "TransactionRecordKbaek7943s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
