using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class Fatura2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Fatura_FaturaId",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_FaturaId",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "FaturaId",
                table: "Compras");

            migrationBuilder.AddColumn<int>(
                name: "ComprasFaturaId",
                table: "Fatura",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fatura_Compras_ComprasFaturaId",
                table: "Fatura");

            migrationBuilder.DropIndex(
                name: "IX_Fatura_ComprasFaturaId",
                table: "Fatura");

            migrationBuilder.DropColumn(
                name: "ComprasFaturaId",
                table: "Fatura");

            migrationBuilder.AddColumn<int>(
                name: "FaturaId",
                table: "Compras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Compras_FaturaId",
                table: "Compras",
                column: "FaturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Fatura_FaturaId",
                table: "Compras",
                column: "FaturaId",
                principalTable: "Fatura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
