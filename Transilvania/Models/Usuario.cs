using System;
using System.Collections.Generic;
namespace Transilvania.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
       
    }
}