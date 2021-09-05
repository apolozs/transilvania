namespace Transilvania.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public Historico Historico { get; set; }  
        public Usuario Usuario { get; set; } 
        public Quarto Quarto { get; set; } 
    }
}