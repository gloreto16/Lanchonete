namespace Lanchonete
{
    public abstract class Comida
    {
        protected double PrecoVenda {get; set;}
        protected int Quantidade {get; set;}
        public double PrecoTotal{get; set;}
        public abstract void calculo();
        
    }
}