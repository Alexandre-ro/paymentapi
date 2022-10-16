using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class UpdateTabelasVendaItem3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Vendedor_vendedorId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_vendedorId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "id_vendedor",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "vendedorId",
                table: "Venda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_vendedor",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "vendedorId",
                table: "Venda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_vendedorId",
                table: "Venda",
                column: "vendedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Vendedor_vendedorId",
                table: "Venda",
                column: "vendedorId",
                principalTable: "Vendedor",
                principalColumn: "id");
        }
    }
}
