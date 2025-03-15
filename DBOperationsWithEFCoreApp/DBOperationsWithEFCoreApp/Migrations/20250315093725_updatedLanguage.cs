using Microsoft.EntityFrameworkCore.Migrations;

namespace DBOperationsWithEFCoreApp.Migrations
{
    public partial class updatedLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LANGUAGES",
                columns: new[] { "ID", "DESCRIPTION", "TITLE" },
                values: new object[,]
                {
                    { 1, "English", "English" },
                    { 2, "Hindi", "Hindi" },
                    { 3, "Malayalam", "Malayalam" },
                    { 4, "Tamil", "Tamil" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LANGUAGES",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LANGUAGES",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LANGUAGES",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LANGUAGES",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
