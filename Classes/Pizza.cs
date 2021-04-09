namespace Lanchonete
{
    public class Pizza : Comida
    {
        private string MolhoPizza {get; set;}
        private string Borda {get; set;}

        public Pizza(string borda, string recheio, string molho, int quantidade)
        {
            this.Borda = borda;
            this.Recheio = recheio;
            this.MolhoPizza = molho;
            this.Quantidade = quantidade;
            this.PrecoVenda = 30.00;
        }
    }
}