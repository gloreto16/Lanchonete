namespace Lanchonete
{
    public class Lanches : Comida
    {
        private string Pao {get; set;}
        private string MolhoLanche {get; set;}

        public Lanches(string pao, string recheio, string molho, int quantidade)
        {
            this.Pao = pao;
            this.Recheio = recheio;
            this.MolhoLanche = molho;
            this.Quantidade = quantidade;
            this.PrecoVenda = 12.00;
        }
    }
}