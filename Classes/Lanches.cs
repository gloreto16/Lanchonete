namespace Lanchonete
{
    public class Lanches : Comida
    {
        private string Pao {get; set;}
        private string MolhoLanche {get; set;}
        private RecheioLanche RecheioLanche {get; set;}

        public Lanches(string pao, RecheioLanche recheio, string molho, int quantidade)
        {
            this.Pao = pao;
            this.RecheioLanche = recheio;
            this.MolhoLanche = molho;
            this.Quantidade = quantidade;
            this.PrecoVenda = 12.00;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Lanche -> ";
            retorno += "Pao: " + this.Pao + " || ";
            retorno += "Recheio: " + this.RecheioLanche + " || ";
            retorno += "Molho: " + this.MolhoLanche + " || ";
            retorno += "Preço Unitário: " + this.PrecoVenda + " || ";
            retorno += "Quantidade: " + this.Quantidade;
            return retorno;
        }
        
    }
}