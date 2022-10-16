using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentApi.Models;

namespace PaymentApi.Map
{
    public class VendedorMap : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder.ToTable("vendedor");
            builder.Property(x => x.Id).HasColumnName("id");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Cpf).HasColumnName("cpf").HasMaxLength(11).IsRequired();
            builder.Property(x => x.Email).HasColumnName("email").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Telefone).HasColumnName("telefone").HasMaxLength(20).IsRequired();

            //Dados para teste
            builder.HasData(
                new Vendedor(1, "Alexandre R Oliveira", "07391489665", "alexadre.ri.oliveira@gmail.com", "32991022832"),
                 new Vendedor(2, "Franciane C Ildefonso", "1234567890", "franciane@gmail.com", "3291024025")
                );

        }
    }
}
