using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class decimalNumbers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdFatura",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdFatura",
                table: "Compras");
        }
    }
}
