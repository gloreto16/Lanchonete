namespace Lanchonete
{
    public class Pizza : Comida
    {
        private string MolhoPizza {get; set;}
        private string Borda {get; set;}
        private RecheioPizza RecheioPizza{get; set;}

        public Pizza(string borda, RecheioPizza recheio, string molho, int quantidade)
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
            retorno += "Pizza -> ";
            retorno += "Borda: " + this.Borda + " || ";
            retorno += "Recheio: " + this.RecheioPizza + " || ";
            retorno += "Molho: " + this.MolhoPizza + " || ";
            retorno += "Preço Unitário: R$" + this.PrecoVenda + " || ";
            retorno += "Quantidade: " + this.Quantidade;
            return retorno;
        }
        public override void calculo(){
            this.PrecoTotal = this.PrecoVenda * this.Quantidade;
        }
    }
}