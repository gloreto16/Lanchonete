using System;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = menuPrincipal();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        mostrarCardapio();
                        break;
                    case "2":
                        //TODO fazerPedido();
                        break;
                    case "3":
                        //TODO fazerPagamento();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = menuPrincipal();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços!");
            Console.ReadLine();
        }

        private static string menuPrincipal()
        {
            Console.WriteLine("---------------//--------------");
            Console.WriteLine("Bem vindo(a) a Lanchonete do Jorjão!");
            Console.WriteLine("Por favor, escolha uma das opções abaixo: ");
            Console.WriteLine("1 - Visualizar cardápio");
            Console.WriteLine("2 - Fazer um pedido");
            Console.WriteLine("3 - Efetuar pagamento");
            Console.WriteLine("X - Sair");
            Console.WriteLine("---------------//--------------");
            Console.WriteLine();
            string opcao = Console.ReadLine().ToUpper();
            return opcao;
        }
        private static void mostrarCardapio()
        {
            Console.WriteLine("---------------//--------------");
            Console.WriteLine("Pizzas: R$30,00 - Validade: 8/2021 - Peso: 560g");
            Console.WriteLine("Lanches: R$12,00 - Validade: 5/2021 - Peso: 250g");
            Console.WriteLine("Salgadinhos: R$3,50 - Validade: 4/2021 - Peso: 25g");
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.WriteLine("---------------//--------------");
            Console.ReadLine();
        }
    }
}
