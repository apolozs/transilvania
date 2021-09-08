using System;
using System.Collections.Generic;

namespace Transilvania.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long QuantidadeQuartos { get; set; }
        public string Adicionais { get; set; }
        public string TipoDeCamas { get; set; }
        public string ImagemHotel { get; set; } 
        public List<Quarto> Quarto { get; set; }
        public string Cidade {get; set; }
    }
}