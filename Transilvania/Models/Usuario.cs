namespace Transilvania.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
    }
}