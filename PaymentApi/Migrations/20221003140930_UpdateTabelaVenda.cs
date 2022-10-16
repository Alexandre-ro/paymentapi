using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentApi.Migrations
{
    public partial class UpdateTabelaVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_item",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_item",
                table: "Venda");
        }
    }
}
