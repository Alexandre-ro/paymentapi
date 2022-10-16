using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class Update2Tabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Pedido_PedidoId",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "Item",
                newName: "pedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_PedidoId",
                table: "Item",
                newName: "IX_Item_pedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Pedido_pedidoId",
                table: "Item",
                column: "pedidoId",
                principalTable: "Pedido",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Pedido_pedidoId",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "pedidoId",
                table: "Item",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_pedidoId",
                table: "Item",
                newName: "IX_Item_PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Pedido_PedidoId",
                table: "Item",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id");
        }
    }
}
