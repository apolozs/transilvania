using System.Collections.Generic;
namespace Transilvania.Models
{
    public class Quarto
    {
        public int Id { get; set; }
        public string NomeQuarto { get; set; }
        public int QuantidadeDeCamas { get; set; }
        public string TipoDeCamas { get; set; }
        public string ImagemQuarto { get; set; }
        public double Preco { get; set; }      
    }
}