namespace CadastroClientess.Models
{
    public class Clientes
    {
        // Criando atributos para nossos clientes
        // get pegar informação / set adicionar informação
        public int IdCliente { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string UF { get; set; }
    }
}
