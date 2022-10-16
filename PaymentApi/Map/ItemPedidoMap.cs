using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentApi.Models;

namespace PaymentApi.Map
{
    public class ItemPedidoMap : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.ToTable("item_pedido");
            builder.Property(x => x.Id).HasColumnName("id");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Preco).HasColumnName("preco").HasPrecision(15, 2).IsRequired();
           

            //Dados para Teste
            builder.HasData(new ItemPedido(1, "Teclado Gammer", 350));
            builder.HasData(new ItemPedido(2, "Mouse Gammer", 90));
            builder.HasData(new ItemPedido(3, "Gabinete Gammer", 600));
            builder.HasData(new ItemPedido(4, "Mesa Gammer", 400));
            builder.HasData(new ItemPedido(5, "HeadSet Gammer", 499));
        }
    }
}
