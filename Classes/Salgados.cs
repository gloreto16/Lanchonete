namespace Lanchonete
{
    public class Salgados : Comida
    {
        private string Massa {get; set;}
        private string Tipo {get; set;}

        public Salgados(string massa, string recheio, string tipo, int quantidade)
        {
            this.Tipo = tipo;
            this.Recheio = recheio;
            this.Massa = massa;
            this.Quantidade = quantidade;
            this.PrecoVenda = 3.50;
        }
    }
}