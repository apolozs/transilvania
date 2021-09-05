using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
         //Contrutor
         public DataContext(DbContextOptions<DataContext> options) : base(options) { }

         //Lista de propieadas das classes que vão virar tabelas no banco.
         //public DbSet<Produto> Produtos { get; set;}
            
    }
}