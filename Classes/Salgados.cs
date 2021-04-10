namespace Lanchonete
{
    public class Salgados : Comida
    {
        private string Tipo {get; set;}
        private RecheioSalgados RecheioSalgado {get; set;}

        public Salgados(RecheioSalgados recheio, string tipo, int quantidade)
        {
            this.Tipo = tipo;
            this.RecheioSalgado = recheio;
            this.Quantidade = quantidade;
            this.PrecoVenda = 3.50;
        }
    }
}