using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class UpdateTabelasVendaItem10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemPedido_Pedido_pedido_id",
                table: "OrdemPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemPedido_Produto_produto_id",
                table: "OrdemPedido");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Produto",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Produto",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Pedido",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "data_pedido",
                table: "Pedido",
                newName: "DataPedido");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "OrdemPedido",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "produto_id",
                table: "OrdemPedido",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "pedido_id",
                table: "OrdemPedido",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemPedido_produto_id",
                table: "OrdemPedido",
                newName: "IX_OrdemPedido_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemPedido_pedido_id",
                table: "OrdemPedido",
                newName: "IX_OrdemPedido_PedidoId");

            migrationBuilder.AddColumn<string>(
                name: "Produto",
                table: "Pedido",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemPedido_Pedido_PedidoId",
                table: "OrdemPedido",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemPedido_Produto_ProdutoId",
                table: "OrdemPedido",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemPedido_Pedido_PedidoId",
                table: "OrdemPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemPedido_Produto_ProdutoId",
                table: "OrdemPedido");

            migrationBuilder.DropColumn(
                name: "Produto",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produto",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Produto",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Pedido",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "DataPedido",
                table: "Pedido",
                newName: "data_pedido");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "OrdemPedido",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "OrdemPedido",
                newName: "produto_id");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "OrdemPedido",
                newName: "pedido_id");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemPedido_ProdutoId",
                table: "OrdemPedido",
                newName: "IX_OrdemPedido_produto_id");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemPedido_PedidoId",
                table: "OrdemPedido",
                newName: "IX_OrdemPedido_pedido_id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemPedido_Pedido_pedido_id",
                table: "OrdemPedido",
                column: "pedido_id",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemPedido_Produto_produto_id",
                table: "OrdemPedido",
                column: "produto_id",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
