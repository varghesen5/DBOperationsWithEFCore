using Microsoft.EntityFrameworkCore.Migrations;

namespace DBOperationsWithEFCoreApp.Migrations
{
    public partial class AddedLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LANGUAGEID",
                table: "BOOKS",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LANGUAGES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TITLE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LANGUAGES", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BOOKS_LANGUAGEID",
                table: "BOOKS",
                column: "LANGUAGEID");

            migrationBuilder.AddForeignKey(
                name: "FK_BOOKS_LANGUAGES_LANGUAGEID",
                table: "BOOKS",
                column: "LANGUAGEID",
                principalTable: "LANGUAGES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BOOKS_LANGUAGES_LANGUAGEID",
                table: "BOOKS");

            migrationBuilder.DropTable(
                name: "LANGUAGES");

            migrationBuilder.DropIndex(
                name: "IX_BOOKS_LANGUAGEID",
                table: "BOOKS");

            migrationBuilder.DropColumn(
                name: "LANGUAGEID",
                table: "BOOKS");
        }
    }
}
