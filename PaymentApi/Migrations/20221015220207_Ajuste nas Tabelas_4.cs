using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class AjustenasTabelas_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.CreateTable(
                name: "item_pedido",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    preco = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_pedido", x => x.id);
                    table.ForeignKey(
                        name: "FK_item_pedido_pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "pedido",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "item_pedido",
                columns: new[] { "id", "nome", "PedidoId", "preco" },
                values: new object[,]
                {
                    { 1, "Teclado Gammer", null, 350m },
                    { 2, "Mouse Gammer", null, 90m },
                    { 3, "Gabinete Gammer", null, 600m },
                    { 4, "Mesa Gammer", null, 400m },
                    { 5, "HeadSet Gammer", null, 499m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_item_pedido_PedidoId",
                table: "item_pedido",
                column: "PedidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "item_pedido");

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: true),
                    preco = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.id);
                    table.ForeignKey(
                        name: "FK_produto_pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "pedido",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "produto",
                columns: new[] { "id", "nome", "PedidoId", "preco" },
                values: new object[,]
                {
                    { 1, "Teclado Gammer", null, 350m },
                    { 2, "Mouse Gammer", null, 90m },
                    { 3, "Gabinete Gammer", null, 600m },
                    { 4, "Mesa Gammer", null, 400m },
                    { 5, "HeadSet Gammer", null, 499m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_produto_PedidoId",
                table: "produto",
                column: "PedidoId");
        }
    }
}
