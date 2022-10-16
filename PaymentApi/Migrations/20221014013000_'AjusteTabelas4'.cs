using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class AjusteTabelas4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedido_vendedor_id_vendedor",
                table: "pedido");

            migrationBuilder.DropTable(
                name: "produto_pedido");

            migrationBuilder.DropIndex(
                name: "IX_pedido_id_vendedor",
                table: "pedido");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "produto",
                newName: "preco");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "produto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VendedorId",
                table: "pedido",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_produto_PedidoId",
                table: "produto",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_VendedorId",
                table: "pedido",
                column: "VendedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_pedido_vendedor_VendedorId",
                table: "pedido",
                column: "VendedorId",
                principalTable: "vendedor",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_produto_pedido_PedidoId",
                table: "produto",
                column: "PedidoId",
                principalTable: "pedido",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedido_vendedor_VendedorId",
                table: "pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_produto_pedido_PedidoId",
                table: "produto");

            migrationBuilder.DropIndex(
                name: "IX_produto_PedidoId",
                table: "produto");

            migrationBuilder.DropIndex(
                name: "IX_pedido_VendedorId",
                table: "pedido");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "produto");

            migrationBuilder.DropColumn(
                name: "VendedorId",
                table: "pedido");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "produto",
                newName: "Preco");

            migrationBuilder.CreateTable(
                name: "produto_pedido",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_pedido = table.Column<int>(type: "int", nullable: false),
                    id_produto = table.Column<int>(type: "int", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_pedido", x => x.id);
                    table.ForeignKey(
                        name: "FK_produto_pedido_pedido_id_pedido",
                        column: x => x.id_pedido,
                        principalTable: "pedido",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_pedido_produto_id_produto",
                        column: x => x.id_produto,
                        principalTable: "produto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pedido_id_vendedor",
                table: "pedido",
                column: "id_vendedor");

            migrationBuilder.CreateIndex(
                name: "IX_produto_pedido_id_pedido",
                table: "produto_pedido",
                column: "id_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_produto_pedido_id_produto",
                table: "produto_pedido",
                column: "id_produto");

            migrationBuilder.AddForeignKey(
                name: "FK_pedido_vendedor_id_vendedor",
                table: "pedido",
                column: "id_vendedor",
                principalTable: "vendedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
