using Microsoft.EntityFrameworkCore;
using Transilvania.Models;
using System.Linq;
using System;



namespace Transilvania.Data
{
    public class DataContext : DbContext
    {
         //Contrutor
         public DataContext(DbContextOptions<DataContext> options) : base(options) {SetData();}

         //Lista de propieadas das classes que vão virar tabelas no banco.
            public DbSet<Usuario> Usuarios { get; set;}
            public DbSet<Quarto> Quartos { get; set;}
            public DbSet<Reserva> Reservas { get; set;}
            public DbSet<Adicionais> Adicionais { get; set;}
            private void SetData(){

                if (!Quartos.Any())
                {    
                Quartos.Add(new Quarto
                {
                    NomeQuarto= "Quarto de Solteiro",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Cama box de mola",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 100.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Duplo Solteiro",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Cama box conjugado",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 200.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Quarto Casal",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Cama box com cofre",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 300.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Dormitórios",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Rede",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 700.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Standard",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Beliche",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 110.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Master",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Bicama",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 22.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Deluxe",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Tradicional de ferro",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 33.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Master Superior",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 44.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Deluxe",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Tradicional com pés",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 190.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Standard",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Queen",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 199.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Standard",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Cama hospitalar",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 200.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Quarto Casal",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Cama baixa",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 210.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Deluxe",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Camas provençal",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 199.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Quarto Casal",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 250.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Quarto Solteiro",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Cama baixa",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 750.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Deluxe",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Cama box com cama para pet",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 600.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Master",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Sofá cama",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 900.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Master",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Camas tecnológicas",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 1000.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Master",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Minicama infantil",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 800.00
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "Standard",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "Cama box com cama dupla",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 356.00
                    });
                SaveChanges();
            } 
        }
     }      
}
         
