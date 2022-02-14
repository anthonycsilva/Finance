using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class decimalNumbers3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdFatura",
                table: "Compras");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdFatura",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
