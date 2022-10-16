using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class Update2TabelaVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Venda_VendaId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_VendaId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "Item");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_VendaId",
                table: "Item",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Venda_VendaId",
                table: "Item",
                column: "VendaId",
                principalTable: "Venda",
                principalColumn: "id");
        }
    }
}
