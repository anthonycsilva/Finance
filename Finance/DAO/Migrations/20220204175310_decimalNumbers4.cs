using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class decimalNumbers4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Fatura_FaturaAssociadaId",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_FaturaAssociadaId",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "FaturaAssociadaId",
                table: "Compras");

            migrationBuilder.AddColumn<int>(
                name: "faturaID",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Compras_faturaID",
                table: "Compras",
                column: "faturaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Fatura_faturaID",
                table: "Compras",
                column: "faturaID",
                principalTable: "Fatura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Fatura_faturaID",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_faturaID",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "faturaID",
                table: "Compras");

            migrationBuilder.AddColumn<int>(
                name: "FaturaAssociadaId",
                table: "Compras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Compras_FaturaAssociadaId",
                table: "Compras",
                column: "FaturaAssociadaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Fatura_FaturaAssociadaId",
                table: "Compras",
                column: "FaturaAssociadaId",
                principalTable: "Fatura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
