using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class AjusteTabelas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Vendedor_IdVendedor",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoPedido_Pedido_IdPedido",
                table: "ProdutoPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoPedido_Produto_IdProduto",
                table: "ProdutoPedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendedor",
                table: "Vendedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produto",
                table: "Produto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProdutoPedido",
                table: "ProdutoPedido");

            migrationBuilder.RenameTable(
                name: "Vendedor",
                newName: "vendedor");

            migrationBuilder.RenameTable(
                name: "Produto",
                newName: "produto");

            migrationBuilder.RenameTable(
                name: "Pedido",
                newName: "pedido");

            migrationBuilder.RenameTable(
                name: "ProdutoPedido",
                newName: "produto_pedido");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_IdVendedor",
                table: "pedido",
                newName: "IX_pedido_IdVendedor");

            migrationBuilder.RenameIndex(
                name: "IX_ProdutoPedido_IdProduto",
                table: "produto_pedido",
                newName: "IX_produto_pedido_IdProduto");

            migrationBuilder.RenameIndex(
                name: "IX_ProdutoPedido_IdPedido",
                table: "produto_pedido",
                newName: "IX_produto_pedido_IdPedido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vendedor",
                table: "vendedor",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_produto",
                table: "produto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pedido",
                table: "pedido",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_produto_pedido",
                table: "produto_pedido",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_pedido_vendedor_IdVendedor",
                table: "pedido",
                column: "IdVendedor",
                principalTable: "vendedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_produto_pedido_pedido_IdPedido",
                table: "produto_pedido",
                column: "IdPedido",
                principalTable: "pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_produto_pedido_produto_IdProduto",
                table: "produto_pedido",
                column: "IdProduto",
                principalTable: "produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedido_vendedor_IdVendedor",
                table: "pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_produto_pedido_pedido_IdPedido",
                table: "produto_pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_produto_pedido_produto_IdProduto",
                table: "produto_pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vendedor",
                table: "vendedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produto",
                table: "produto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pedido",
                table: "pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produto_pedido",
                table: "produto_pedido");

            migrationBuilder.RenameTable(
                name: "vendedor",
                newName: "Vendedor");

            migrationBuilder.RenameTable(
                name: "produto",
                newName: "Produto");

            migrationBuilder.RenameTable(
                name: "pedido",
                newName: "Pedido");

            migrationBuilder.RenameTable(
                name: "produto_pedido",
                newName: "ProdutoPedido");

            migrationBuilder.RenameIndex(
                name: "IX_pedido_IdVendedor",
                table: "Pedido",
                newName: "IX_Pedido_IdVendedor");

            migrationBuilder.RenameIndex(
                name: "IX_produto_pedido_IdProduto",
                table: "ProdutoPedido",
                newName: "IX_ProdutoPedido_IdProduto");

            migrationBuilder.RenameIndex(
                name: "IX_produto_pedido_IdPedido",
                table: "ProdutoPedido",
                newName: "IX_ProdutoPedido_IdPedido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendedor",
                table: "Vendedor",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produto",
                table: "Produto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProdutoPedido",
                table: "ProdutoPedido",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Vendedor_IdVendedor",
                table: "Pedido",
                column: "IdVendedor",
                principalTable: "Vendedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoPedido_Pedido_IdPedido",
                table: "ProdutoPedido",
                column: "IdPedido",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoPedido_Produto_IdProduto",
                table: "ProdutoPedido",
                column: "IdProduto",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
