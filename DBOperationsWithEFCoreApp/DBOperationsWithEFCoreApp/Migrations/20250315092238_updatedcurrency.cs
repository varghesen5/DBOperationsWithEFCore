using Microsoft.EntityFrameworkCore.Migrations;

namespace DBOperationsWithEFCoreApp.Migrations
{
    public partial class updatedcurrency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CURRENCYTYPES",
                columns: new[] { "ID", "CURRENCY", "DESCRIPTION" },
                values: new object[,]
                {
                    { 1, "INR", "Indian INR" },
                    { 2, "dollar", "Dollar" },
                    { 3, "Euro", "Euro" },
                    { 4, "Dinar", "Dinar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CURRENCYTYPES",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CURRENCYTYPES",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CURRENCYTYPES",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CURRENCYTYPES",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
