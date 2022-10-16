using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class UpdateTabelasVendaItem6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Venda_VendaId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Vendedor_VendedorId",
                table: "Venda");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "Venda",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VendedorId",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VendaId",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Venda_VendaId",
                table: "Item",
                column: "VendaId",
                principalTable: "Venda",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Vendedor_VendedorId",
                table: "Venda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Venda_VendaId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Vendedor_VendedorId",
                table: "Venda");

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VendedorId",
                table: "Venda",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VendaId",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "IX_Pedido_VendedorId",
                table: "Pedido",
                column: "VendedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Venda_VendaId",
                table: "Item",
                column: "VendaId",
                principalTable: "Venda",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Vendedor_VendedorId",
                table: "Venda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "id");
        }
    }
}
