export interface Quarto {
  Id: number;
  NomeQuarto: string;
  QuantidadeDeCamas: string; //Verificar como que funciona no front quando tem relacionamento aqui é um relacionamento de quarto com reserva
  TipoDeCamas: string; // Aqui é um relacionamento de Usuario com reserva
  ImagemQuarto: string; //Aqui é um relacionamento de Adicionais com Reserva
  Preco: number;
}
