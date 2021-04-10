namespace Lanchonete
{
    public class Lanches : Comida
    {
        private int Pao {get; set;}
        private int MolhoLanche {get; set;}
        private RecheioLanche RecheioLanche {get; set;}

        public Lanches(int pao, RecheioLanche recheio, int molho, int quantidade)
        {
            this.Pao = pao;
            this.RecheioLanche = recheio;
            this.MolhoLanche = molho;
            this.Quantidade = quantidade;
            this.PrecoVenda = 12.00;
        }
    }
}