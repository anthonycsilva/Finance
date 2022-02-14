using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class solucaocomprasFatura2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComprasFaturaId",
                table: "Fatura");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComprasFaturaId",
                table: "Fatura",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
