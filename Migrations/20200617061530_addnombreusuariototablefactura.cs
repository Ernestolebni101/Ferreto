using Microsoft.EntityFrameworkCore.Migrations;

namespace Ferreto.Migrations
{
    public partial class addnombreusuariototablefactura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombreusuario",
                table: "Factura",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombreusuario",
                table: "Factura");
        }
    }
}
