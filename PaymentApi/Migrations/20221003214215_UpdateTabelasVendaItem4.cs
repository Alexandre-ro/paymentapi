using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class UpdateTabelasVendaItem4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendedorId",
                table: "Venda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_VendedorId",
                table: "Venda",
                column: "VendedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Vendedor_VendedorId",
                table: "Venda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Vendedor_VendedorId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_VendedorId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "VendedorId",
                table: "Venda");
        }
    }
}
