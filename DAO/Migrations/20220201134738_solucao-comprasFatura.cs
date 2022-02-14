using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class solucaocomprasFatura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fatura_Compras_ComprasFaturaId",
                table: "Fatura");

            migrationBuilder.DropIndex(
                name: "IX_Fatura_ComprasFaturaId",
                table: "Fatura");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Fatura_ComprasFaturaId",
                table: "Fatura",
                column: "ComprasFaturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fatura_Compras_ComprasFaturaId",
                table: "Fatura",
                column: "ComprasFaturaId",
                principalTable: "Compras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
