// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentApi.Context;

#nullable disable

namespace PaymentApi.Migrations
{
    [DbContext(typeof(PaymentApiContext))]
    [Migration("20221015203721_Ajuste nas Tabelas_02")]
    partial class AjustenasTabelas_02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PaymentApi.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int")
                        .HasColumnName("id_produto");

                    b.Property<int>("IdVendedor")
                        .HasColumnType("int")
                        .HasColumnName("id_vendedor");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdVendedor");

                    b.ToTable("pedido", (string)null);
                });

            modelBuilder.Entity("PaymentApi.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("preco");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("produto", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Teclado Gammer",
                            Preco = 350m
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Mouse Gammer",
                            Preco = 90m
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Gabinete Gammer",
                            Preco = 600m
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Mesa Gammer",
                            Preco = 400m
                        },
                        new
                        {
                            Id = 5,
                            Nome = "HeadSet Gammer",
                            Preco = 499m
                        });
                });

            modelBuilder.Entity("PaymentApi.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("vendedor", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = "07391489665",
                            Email = "alexadre.ri.oliveira@gmail.com",
                            Nome = "Alexandre R Oliveira",
                            Telefone = "32991022832"
                        },
                        new
                        {
                            Id = 2,
                            Cpf = "1234567890",
                            Email = "franciane@gmail.com",
                            Nome = "Franciane C Ildefonso",
                            Telefone = "3291024025"
                        });
                });

            modelBuilder.Entity("PaymentApi.Models.Pedido", b =>
                {
                    b.HasOne("PaymentApi.Models.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("IdVendedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("PaymentApi.Models.Produto", b =>
                {
                    b.HasOne("PaymentApi.Models.Pedido", null)
                        .WithMany("Produtos")
                        .HasForeignKey("PedidoId");
                });

            modelBuilder.Entity("PaymentApi.Models.Pedido", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
