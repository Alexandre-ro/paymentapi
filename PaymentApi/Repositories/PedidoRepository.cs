using PaymentApi.Context;
using PaymentApi.Models;

namespace PaymentApi.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly PaymentApiContext _context;

        private const string AguardandoPagamento = "Aguardando pagamento";
        private const string PagamentoAprovado = "Pagamento Aprovado";
        private const string Cancelada = "Cancelada";
        private const string EnviadoTransportadora = "Enviado para Transportadora";
        private const string Entregue = "Entregue";

        public PedidoRepository(PaymentApiContext context)
        {
            _context = context;
        }

        public IEnumerable<Pedido> GetAll()
        {
            var pedidos = _context.Pedido.ToList();

            return pedidos;
        }

        public IQueryable GetById(int id)
        {
            var pedido = _context.Pedido
                                 .Join(_context.ItemPedido,
                                 pedido => pedido.Id,
                                 item => item.Pedido.Id,
                                 (pedido, item) => new
                                 {
                                     Id = pedido.Id,
                                     DataPedido = pedido.DataPedido,
                                     Status = pedido.Status,
                                     Vendedor = pedido.Vendedor,
                                     Item = item.Nome,
                                     Valor = item.Preco
                                 })
                                 .Where(pedido => pedido.Id == id);

            return pedido;
        }


        public int Add(Pedido pedido)
        {
            try
            {
                pedido.Status = AguardandoPagamento;

                _context.Add(pedido);
                _context.SaveChanges();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public int UpdateStatus(int id, string status)
        {
            try
            {
                var pedido = _context.Pedido.Find(id);

                //validação para o Status Aguardando pagamento
                if (pedido.Status == AguardandoPagamento)
                {
                    if (status == EnviadoTransportadora || status == Entregue || status == AguardandoPagamento )
                    {
                        return 0;
                    }
                }

                //Validação para o Status Pagamento Aprovado
                if (pedido.Status == PagamentoAprovado)
                {
                    if (status == PagamentoAprovado ||  status == Entregue)
                    {
                        return 0;
                    }
                }

                //Validação para o Status Entregue
                if (pedido.Status == EnviadoTransportadora)
                {
                    if (status != Entregue)
                    {
                        return 0;
                    }
                }

                pedido.Status = status;
                _context.Update(pedido);
                _context.SaveChanges();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int Update(int id, Pedido pedido)
        {
            return 1;
        }

    }
}
