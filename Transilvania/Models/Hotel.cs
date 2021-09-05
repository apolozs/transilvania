namespace Transilvania.Models
{
    public class Hotel
    {
        public string NomeHotel { get; set; }
        public long QuantidadeQuartos { get; set; }
        public string Adicionais { get; set; }
        public string TipoDeCamas { get; set; }
        public string ImagemHotel { get; set; } 
        public Quarto Quarto { get; set; }
        public Endereco Endereco { get; set; }
    }
}