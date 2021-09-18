using System.Collections.Generic;
namespace Transilvania.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public List<Quarto> Quarto { get; set; }
        public List<Historico> Adicionais { get; set; }
       
    }
}