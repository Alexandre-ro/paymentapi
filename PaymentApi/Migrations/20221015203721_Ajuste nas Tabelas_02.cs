using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class AjustenasTabelas_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedido_vendedor_VendedorId1",
                table: "pedido");

            migrationBuilder.DropIndex(
                name: "IX_pedido_VendedorId1",
                table: "pedido");

            migrationBuilder.DropColumn(
                name: "VendedorId1",
                table: "pedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendedorId1",
                table: "pedido",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_pedido_VendedorId1",
                table: "pedido",
                column: "VendedorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_pedido_vendedor_VendedorId1",
                table: "pedido",
                column: "VendedorId1",
                principalTable: "vendedor",
                principalColumn: "id");
        }
    }
}
