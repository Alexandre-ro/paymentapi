using System.Text.Json.Serialization;

namespace PaymentApi.Models
{
    public class Pedido
    {
        public Pedido()
        {

        }
                
        public int Id { get; set; }
        public int IdVendedor { get; set; }
               
        public DateTime DataPedido { get; set; }

        [JsonIgnore]
        public string Status { get; set; }

        [JsonIgnore]
        public Vendedor Vendedor { get; set; }       
       
        public List<ItemPedido> Itens { get; set; }
    }
}
