using Microsoft.EntityFrameworkCore.Migrations;

namespace DBOperationsWithEFCoreApp.Migrations
{
    public partial class nextTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CURRENCYTYPES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CURRENCY = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CURRENCYTYPES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BOOKPRICES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    BOOKID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    AMOUNT = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CURRENCYID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CURRENCYTYPEID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOOKPRICES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BOOKPRICES_CURRENCYTYPES_CURRENCYTYPEID",
                        column: x => x.CURRENCYTYPEID,
                        principalTable: "CURRENCYTYPES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BOOKPRICES_CURRENCYTYPEID",
                table: "BOOKPRICES",
                column: "CURRENCYTYPEID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BOOKPRICES");

            migrationBuilder.DropTable(
                name: "CURRENCYTYPES");
        }
    }
}
