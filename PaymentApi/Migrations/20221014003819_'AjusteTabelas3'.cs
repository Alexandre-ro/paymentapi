using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class AjusteTabelas3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "produto_pedido",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "produto_pedido",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IdProduto",
                table: "produto_pedido",
                newName: "id_produto");

            migrationBuilder.RenameColumn(
                name: "IdPedido",
                table: "produto_pedido",
                newName: "id_pedido");

            migrationBuilder.RenameIndex(
                name: "IX_produto_pedido_IdProduto",
                table: "produto_pedido",
                newName: "IX_produto_pedido_id_produto");

            migrationBuilder.RenameIndex(
                name: "IX_produto_pedido_IdPedido",
                table: "produto_pedido",
                newName: "IX_produto_pedido_id_pedido");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "produto",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "produto",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "pedido",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "pedido",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IdVendedor",
                table: "pedido",
                newName: "id_vendedor");

            migrationBuilder.RenameColumn(
                name: "DataPedido",
                table: "pedido",
                newName: "data_pedido");

            migrationBuilder.RenameIndex(
                name: "IX_pedido_IdVendedor",
                table: "pedido",
                newName: "IX_pedido_id_vendedor");

            migrationBuilder.AddForeignKey(
                name: "FK_pedido_vendedor_id_vendedor",
                table: "pedido",
                column: "id_vendedor",
                principalTable: "vendedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_produto_pedido_pedido_id_pedido",
                table: "produto_pedido",
                column: "id_pedido",
                principalTable: "pedido",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_produto_pedido_produto_id_produto",
                table: "produto_pedido",
                column: "id_produto",
                principalTable: "produto",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedido_vendedor_id_vendedor",
                table: "pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_produto_pedido_pedido_id_pedido",
                table: "produto_pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_produto_pedido_produto_id_produto",
                table: "produto_pedido");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "produto_pedido",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "produto_pedido",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id_produto",
                table: "produto_pedido",
                newName: "IdProduto");

            migrationBuilder.RenameColumn(
                name: "id_pedido",
                table: "produto_pedido",
                newName: "IdPedido");

            migrationBuilder.RenameIndex(
                name: "IX_produto_pedido_id_produto",
                table: "produto_pedido",
                newName: "IX_produto_pedido_IdProduto");

            migrationBuilder.RenameIndex(
                name: "IX_produto_pedido_id_pedido",
                table: "produto_pedido",
                newName: "IX_produto_pedido_IdPedido");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "produto",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "produto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "pedido",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "pedido",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id_vendedor",
                table: "pedido",
                newName: "IdVendedor");

            migrationBuilder.RenameColumn(
                name: "data_pedido",
                table: "pedido",
                newName: "DataPedido");

            migrationBuilder.RenameIndex(
                name: "IX_pedido_id_vendedor",
                table: "pedido",
                newName: "IX_pedido_IdVendedor");

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
    }
}
