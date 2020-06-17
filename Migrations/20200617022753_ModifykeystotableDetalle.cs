using Microsoft.EntityFrameworkCore.Migrations;

namespace Ferreto.Migrations
{
    public partial class ModifykeystotableDetalle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_tventa",
                table: "Factura");

            migrationBuilder.DropIndex(
                name: "IX_Factura_idventa",
                table: "Factura");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Venta__F82D1AFBC027FC2F",
                table: "Detallefactura");

            migrationBuilder.DropColumn(
                name: "idventa",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "idventa",
                table: "Detallefactura");

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Persona",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "iddetalle",
                table: "Detallefactura",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "idfactura",
                table: "Detallefactura",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK__Venta__F82D1AFBC027FC2F",
                table: "Detallefactura",
                column: "iddetalle");

            migrationBuilder.CreateIndex(
                name: "IX_Detallefactura_idfactura",
                table: "Detallefactura",
                column: "idfactura");

            migrationBuilder.AddForeignKey(
                name: "fk_tfactura",
                table: "Detallefactura",
                column: "idfactura",
                principalTable: "Factura",
                principalColumn: "idfactura",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_tfactura",
                table: "Detallefactura");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Venta__F82D1AFBC027FC2F",
                table: "Detallefactura");

            migrationBuilder.DropIndex(
                name: "IX_Detallefactura_idfactura",
                table: "Detallefactura");

            migrationBuilder.DropColumn(
                name: "iddetalle",
                table: "Detallefactura");

            migrationBuilder.DropColumn(
                name: "idfactura",
                table: "Detallefactura");

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Persona",
                type: "nvarchar(9)",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idventa",
                table: "Factura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idventa",
                table: "Detallefactura",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Venta__F82D1AFBC027FC2F",
                table: "Detallefactura",
                column: "idventa");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_idventa",
                table: "Factura",
                column: "idventa");

            migrationBuilder.AddForeignKey(
                name: "fk_tventa",
                table: "Factura",
                column: "idventa",
                principalTable: "Detallefactura",
                principalColumn: "idventa",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
