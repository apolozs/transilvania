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
                    NomeQuarto= "1",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "2",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "3",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "4",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "5",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "6",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "7",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "8",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "9",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "10",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "11",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "12",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "13",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "14",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "15",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "16",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "17",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "18",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "19",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                    Quartos.Add(new Quarto{
                    NomeQuarto= "20",
                    QuantidadeDeCamas= 1,
                    TipoDeCamas= "king",
                    ImagemQuarto= "https://s2.glbimg.com/NO1Mrkp3Z96htIx8_RhrdHTux0w=/e.glbimg.com/og/ed/f/original/2018/03/08/decoracao-de-quarto-cabeceira-suede-rosa-roupa-de-cama-branco-com-rosa-papel-de-parede-florido-romantico-abajur-e-pendente-brancoarquiteta-leticia-arcangeli.jpg ",
                    Preco= 10.0
                    });
                SaveChanges();
            } 
        }
     }      
}
         
