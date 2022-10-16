using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class UpdateTabelasVendaItem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Pedido_PedidoId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_PedidoId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Item");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_PedidoId",
                table: "Item",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Pedido_PedidoId",
                table: "Item",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id");
        }
    }
}
