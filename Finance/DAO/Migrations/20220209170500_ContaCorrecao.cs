using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class ContaCorrecao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Salario",
                table: "Conta",
                newName: "Saldo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Saldo",
                table: "Conta",
                newName: "Salario");
        }
    }
}
