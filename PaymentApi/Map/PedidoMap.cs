using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentApi.Models;

namespace PaymentApi.Map
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("pedido");
            builder.Property(x => x.Id).HasColumnName("id");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdVendedor).HasColumnName("id_vendedor").IsRequired();

            //Relacionamento 1:N Vendedor e Pedido
            builder.HasOne(x => x.Vendedor).WithMany().HasForeignKey(x => x.IdVendedor);
            
        }
    }
}
