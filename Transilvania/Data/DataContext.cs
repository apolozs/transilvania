using Microsoft.EntityFrameworkCore;
using Transilvania.Models;


namespace Transilvania.Data
{
    public class DataContext : DbContext
    {
         //Contrutor
         public DataContext(DbContextOptions<DataContext> options) : base(options) { }

         //Lista de propieadas das classes que vão virar tabelas no banco.
            public DbSet<Usuario> Usuarios { get; set;}
            public DbSet<Quarto> Quartos { get; set;}
            public DbSet<Reserva> Reservas { get; set;}
            public DbSet<Adicionais> Adicionais { get; set;}
             
            
    }
}