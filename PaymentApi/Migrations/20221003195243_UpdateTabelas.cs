using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class UpdateTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_item",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "id_vendedor",
                table: "Venda");

            migrationBuilder.AddColumn<int>(
                name: "pedidoId",
                table: "Venda",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendedorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_Vendedor_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedor",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Venda_pedidoId",
                table: "Venda",
                column: "pedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_PedidoId",
                table: "Item",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_VendedorId",
                table: "Pedido",
                column: "VendedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Pedido_PedidoId",
                table: "Item",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Pedido_pedidoId",
                table: "Venda",
                column: "pedidoId",
                principalTable: "Pedido",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Pedido_PedidoId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Pedido_pedidoId",
                table: "Venda");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Venda_pedidoId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Item_PedidoId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "pedidoId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "id_item",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_vendedor",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
