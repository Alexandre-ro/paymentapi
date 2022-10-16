using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class AjustenasTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedido_vendedor_VendedorId",
                table: "pedido");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "pedido",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "data_pedido",
                table: "pedido",
                newName: "DataPedido");

            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "pedido",
                newName: "VendedorId1");

            migrationBuilder.RenameIndex(
                name: "IX_pedido_VendedorId",
                table: "pedido",
                newName: "IX_pedido_VendedorId1");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "vendedor",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "vendedor",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "produto",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "id_produto",
                table: "pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_vendedor",
                table: "pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.InsertData(
                table: "vendedor",
                columns: new[] { "id", "cpf", "email", "nome", "telefone" },
                values: new object[,]
                {
                    { 1, "07391489665", "alexadre.ri.oliveira@gmail.com", "Alexandre R Oliveira", "32991022832" },
                    { 2, "1234567890", "franciane@gmail.com", "Franciane C Ildefonso", "3291024025" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_pedido_id_vendedor",
                table: "pedido",
                column: "id_vendedor");

            migrationBuilder.AddForeignKey(
                name: "FK_pedido_vendedor_id_vendedor",
                table: "pedido",
                column: "id_vendedor",
                principalTable: "vendedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pedido_vendedor_VendedorId1",
                table: "pedido",
                column: "VendedorId1",
                principalTable: "vendedor",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedido_vendedor_id_vendedor",
                table: "pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_pedido_vendedor_VendedorId1",
                table: "pedido");

            migrationBuilder.DropIndex(
                name: "IX_pedido_id_vendedor",
                table: "pedido");

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "vendedor",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "vendedor",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "id_produto",
                table: "pedido");

            migrationBuilder.DropColumn(
                name: "id_vendedor",
                table: "pedido");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "pedido",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "DataPedido",
                table: "pedido",
                newName: "data_pedido");

            migrationBuilder.RenameColumn(
                name: "VendedorId1",
                table: "pedido",
                newName: "VendedorId");

            migrationBuilder.RenameIndex(
                name: "IX_pedido_VendedorId1",
                table: "pedido",
                newName: "IX_pedido_VendedorId");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "vendedor",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "vendedor",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "produto",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_pedido_vendedor_VendedorId",
                table: "pedido",
                column: "VendedorId",
                principalTable: "vendedor",
                principalColumn: "id");
        }
    }
}
