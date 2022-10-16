using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class AjustenasTabelas_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_produto",
                table: "pedido",
                newName: "id_item_pedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_item_pedido",
                table: "pedido",
                newName: "id_produto");
        }
    }
}
