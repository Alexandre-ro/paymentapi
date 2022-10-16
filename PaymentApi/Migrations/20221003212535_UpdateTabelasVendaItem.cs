using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class UpdateTabelasVendaItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Pedido_pedidoId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Pedido_pedidoId",
                table: "Venda");

            migrationBuilder.RenameColumn(
                name: "pedidoId",
                table: "Venda",
                newName: "vendedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_pedidoId",
                table: "Venda",
                newName: "IX_Venda_vendedorId");

            migrationBuilder.RenameColumn(
                name: "pedidoId",
                table: "Item",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_pedidoId",
                table: "Item",
                newName: "IX_Item_PedidoId");

            migrationBuilder.AddColumn<DateTime>(
                name: "data_venda",
                table: "Venda",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "id_vendedor",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "FK_Item_Pedido_PedidoId",
                table: "Item",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Venda_VendaId",
                table: "Item",
                column: "VendaId",
                principalTable: "Venda",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Vendedor_vendedorId",
                table: "Venda",
                column: "vendedorId",
                principalTable: "Vendedor",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Pedido_PedidoId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Venda_VendaId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Vendedor_vendedorId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Item_VendaId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "data_venda",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "id_vendedor",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "vendedorId",
                table: "Venda",
                newName: "pedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_vendedorId",
                table: "Venda",
                newName: "IX_Venda_pedidoId");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "Item",
                newName: "pedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_PedidoId",
                table: "Item",
                newName: "IX_Item_pedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Pedido_pedidoId",
                table: "Item",
                column: "pedidoId",
                principalTable: "Pedido",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Pedido_pedidoId",
                table: "Venda",
                column: "pedidoId",
                principalTable: "Pedido",
                principalColumn: "Id");
        }
    }
}
