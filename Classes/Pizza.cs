namespace Lanchonete
{
    public class Pizza : Comida
    {
        private int MolhoPizza {get; set;}
        private string Borda {get; set;}
        private RecheioPizza RecheioPizza{get; set;}

        public Pizza(string borda, RecheioPizza recheio, int molho, int quantidade)
        {
            this.Borda = borda;
            this.RecheioPizza = recheio;
            this.MolhoPizza = molho;
            this.Quantidade = quantidade;
            this.PrecoVenda = 30.00;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Borda: " + this.Borda + " || ";
            retorno += "Recheio: " + this.RecheioPizza + " || ";
            retorno += "Molho: " + this.MolhoPizza;
            return retorno;
        }
    }
}