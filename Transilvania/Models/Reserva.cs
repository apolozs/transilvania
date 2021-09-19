using System.Collections.Generic;
namespace Transilvania.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public Quarto Quarto { get; set; }
        public Usuario Usuario { get; set; }
        public List<Adicionais> Adicionais { get; set; }
        public string CheckIn { get; set; }      
        public string CheckOut { get; set; }
        
    }
}