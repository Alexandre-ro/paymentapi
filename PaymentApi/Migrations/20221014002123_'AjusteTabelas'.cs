using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class AjusteTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Vendedor_VendedorId",
                table: "Pedido");

            migrationBuilder.DropTable(
                name: "OrdemPedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_VendedorId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "VendedorId",
                table: "Pedido");

            migrationBuilder.AddColumn<int>(
                name: "IdVendedor",
                table: "Pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProdutoPedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoPedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoPedido_Pedido_IdPedido",
                        column: x => x.IdPedido,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoPedido_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_IdVendedor",
                table: "Pedido",
                column: "IdVendedor");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoPedido_IdPedido",
                table: "ProdutoPedido",
                column: "IdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoPedido_IdProduto",
                table: "ProdutoPedido",
                column: "IdProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Vendedor_IdVendedor",
                table: "Pedido",
                column: "IdVendedor",
                principalTable: "Vendedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Vendedor_IdVendedor",
                table: "Pedido");

            migrationBuilder.DropTable(
                name: "ProdutoPedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_IdVendedor",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "IdVendedor",
                table: "Pedido");

            migrationBuilder.AddColumn<int>(
                name: "VendedorId",
                table: "Pedido",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrdemPedido",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemPedido", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrdemPedido_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdemPedido_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_VendedorId",
                table: "Pedido",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemPedido_PedidoId",
                table: "OrdemPedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemPedido_ProdutoId",
                table: "OrdemPedido",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Vendedor_VendedorId",
                table: "Pedido",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "id");
        }
    }
}
