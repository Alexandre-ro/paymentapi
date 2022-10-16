using PaymentApi.Models;

namespace PaymentApi.Repositories
{
    public interface IPedidoRepository
    {
        IEnumerable<Pedido> GetAll();
        IQueryable GetById(int id);
        int Add(Pedido entity);
        int UpdateStatus(int id, string status);
    }
}
