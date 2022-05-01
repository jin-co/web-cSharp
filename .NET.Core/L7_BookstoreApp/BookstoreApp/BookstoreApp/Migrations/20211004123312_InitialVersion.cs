using Microsoft.EntityFrameworkCore.Migrations;

namespace BookstoreApp.Migrations
{
    public partial class InitialVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenreID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AuthorID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PublisherID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    LogoImageSource = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherID",
                        column: x => x.PublisherID,
                        principalTable: "Publishers",
                        principalColumn: "PublisherID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "FullName" },
                values: new object[,]
                {
                    { "JKR", "J.K. Rowling" },
                    { "JP", "James Paterson" },
                    { "SK", "Stephen King" },
                    { "CJ", "Craig Johnson" },
                    { "KM", "Kyle Mills" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "Name" },
                values: new object[,]
                {
                    { "F", "Fiction" },
                    { "M", "Mystery" },
                    { "R", "Romance" },
                    { "A", "Adventure" },
                    { "H", "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "Name" },
                values: new object[,]
                {
                    { "H", "Hachette" },
                    { "C", "Conestoga" },
                    { "MH", "McGraw-Hill" },
                    { "S", "Scholastics" },
                    { "SN", "Springer Nature" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "GenreID", "LogoImageSource", "Price", "PublisherID", "Quantity", "Title", "Year" },
                values: new object[,]
                {
                    { 10, "CJ", "M", "mystery.jpg", 12.67, "H", 7, "Mystery 2", 2021 },
                    { 11, "JP", "A", "adventure.jpg", 52.670000000000002, "H", 17, "Adventure 3", 2013 },
                    { 2, "CJ", "F", "fiction.jpg", 25.120000000000001, "C", 15, "Fiction 2", 2005 },
                    { 4, "JKR", "A", "adventure.jpg", 27.870000000000001, "C", 0, "Adventure 1", 2008 },
                    { 7, "JKR", "R", "romance.jpg", 9.7599999999999998, "C", 3, "Romance 2", 2010 },
                    { 3, "SK", "H", "horror.jpg", 12.76, "MH", 2, "Horror 1", 2001 },
                    { 8, "SK", "H", "horror.jpg", 10.43, "MH", 35, "Horror 2", 1990 },
                    { 5, "JP", "A", "adventure.jpg", 14.59, "S", 25, "Adventure 2", 2004 },
                    { 1, "JKR", "F", "fiction.jpg", 19.399999999999999, "SN", 20, "Fiction 1", 2009 },
                    { 6, "JP", "R", "romance.jpg", 12.449999999999999, "SN", 12, "Romance 1", 2019 },
                    { 9, "KM", "M", "mystery.jpg", 32.229999999999997, "SN", 9, "Mystery 1", 1989 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorID",
                table: "Books",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreID",
                table: "Books",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherID",
                table: "Books",
                column: "PublisherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
