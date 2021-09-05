namespace Transilvania.Models
{
    public class Reserva
    {
        public Historico Historico { get; set; }  
        public Usuario Usuario { get; set; } 
        public Quarto Quarto { get; set; } 
    }
}