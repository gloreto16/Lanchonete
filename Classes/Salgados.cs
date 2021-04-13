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
        public override string ToString()
        {
            string retorno = "";
            retorno += "Salgado -> ";
            retorno += "Tipo: " + this.Tipo + " || ";
            retorno += "Recheio: " + this.RecheioSalgado + " || ";
            retorno += "Preço Unitário: " + this.PrecoVenda + " || ";
            retorno += "Quantidade: " + this.Quantidade;
            return retorno;
        }
        public override void calculo(){
            this.PrecoTotal = this.PrecoVenda * this.Quantidade;
        }
    }
}