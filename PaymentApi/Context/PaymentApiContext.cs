using PaymentApi.Models;
using Microsoft.EntityFrameworkCore;
using PaymentApi.Map;

namespace PaymentApi.Context
{
    public class PaymentApiContext : DbContext
    {
        public PaymentApiContext(DbContextOptions<PaymentApiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new VendedorMap());
            builder.ApplyConfiguration(new ItemPedidoMap());
            builder.ApplyConfiguration(new PedidoMap());
        }

        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
    }
}
