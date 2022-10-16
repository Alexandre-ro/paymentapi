namespace PaymentApi.Models
{
    public class Vendedor
    {
        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string cpf, string email, string telefone)
        {
            Id       = id;
            Nome     = nome;
            Cpf      = cpf;
            Email    = email;
            Telefone = telefone;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
