using System.Text.Json.Serialization;

namespace PaymentApi.Models
{
    public class ItemPedido
    {
        public ItemPedido()
        {

        }

        public ItemPedido(int id, string nome, decimal preco)
        {
            Id    = id;
            Nome  = nome;
            Preco = preco;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        [JsonIgnore]
        public Pedido Pedido { get; set; }
    }
}
