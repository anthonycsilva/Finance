using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class Fatura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FaturaId",
                table: "Compras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Fatura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataVencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalFatura = table.Column<double>(type: "float", nullable: false),
                    Pago = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatura", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Fatura_FaturaId",
                table: "Compras");

            migrationBuilder.DropTable(
                name: "Fatura");

            migrationBuilder.DropIndex(
                name: "IX_Compras_FaturaId",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "FaturaId",
                table: "Compras");
        }
    }
}
