﻿using System;
using System.Collections.Generic;

//Arrumar lista de objetos
namespace Lanchonete
{
    class Program
    {
        //static List<Comida> listaComidas = new List<Comida>();
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
                        fazerPedido();
                        break;
                    case "3":
                        //TODO fazerPagamento();
                        break;
                    case "4":
                        //TODO listarComidas();
                        break;
                    case "5":
                        Console.Clear();
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
            Console.WriteLine("4 - Mostrar pedido");
            Console.WriteLine("5 - Limpar a tela");
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
        private static void fazerPedido()
        {
            Console.WriteLine("Escolha o que você vai pedir: 1 - Pizza: R$30\n 2- Lanche: R$12\n3 - Salgadinhos: R$3,50");
            string escolha = Console.ReadLine();
            switch(escolha)
            {
                case "1":
                    pedidoPizza();
                    break;
                case "2":
                    pedidoLanche();
                    break;
                case "3":
                    pedidoSalgado();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }
        private static void pedidoPizza()
        {
            Console.WriteLine("Você vai querer borda recheada? S/N");
            string escolhaBorda = Console.ReadLine();
            Console.WriteLine("Digite o sabor que deseja: ");
            foreach (int i in Enum.GetValues(typeof(RecheioPizza)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(RecheioPizza), i));
            }
            int escolhaRecheio = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o acompanhamento: 1 - Ketchup\n2 - Mostarda\n3 - Maionese\n4 - Todos");
            int escolhaMolho = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantas pizzas deste tipo você vai querer: ");
            int quantidadePizza = int.Parse(Console.ReadLine());

            Pizza pizza = new Pizza(borda: escolhaBorda, recheio: (RecheioPizza)escolhaRecheio, molho: escolhaMolho, quantidade: quantidadePizza);
            //listaComidas.Add(pizza);

            Console.WriteLine("Deseja continuar pedindo? S/N");
            string opcaoPedido = Console.ReadLine().ToUpper();
            if(opcaoPedido == "S")
            {
                fazerPedido();
            }
        }
        private static void pedidoLanche()
        {
            Console.WriteLine("Você vai querer qual tipo de pão: 1 - 9 grãos\n2 - Italiano\n3 - 3 Queijos\n4 - Parmesão com Orégano");
            int escolhaPao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sabor que deseja: ");
            foreach (int i in Enum.GetValues(typeof(RecheioLanche)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(RecheioLanche), i));
            }
            int escolhaRecheio = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o acompanhamento: 1 - Ketchup\n2 - Mostarda\n3 - Maionese\n4 - Todos");
            int escolhaMolho = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos lanches deste tipo você vai querer: ");
            int quantidadeLanche = int.Parse(Console.ReadLine());

            Lanches lanche = new Lanches(pao: escolhaPao, recheio: (RecheioLanche)escolhaRecheio, molho: escolhaMolho, quantidade: quantidadeLanche);
            //listaComidas.Add(lanche);

            Console.WriteLine("Deseja continuar pedindo? S/N");
            string opcaoPedido = Console.ReadLine().ToUpper();
            if(opcaoPedido == "S")
            {
                fazerPedido();
            }
        }
        private static void pedidoSalgado()
        {
            Console.WriteLine("Digite o sabor que deseja: ");
            foreach (int i in Enum.GetValues(typeof(RecheioSalgados)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(RecheioSalgados), i));
            }
            int escolhaRecheio = int.Parse(Console.ReadLine());
            Console.WriteLine("O senhor(a) irá querer o salgado frito? S/N");
            string escolhaTipo = Console.ReadLine();
            Console.WriteLine("Digite quantos salgados deste tipo você vai querer: ");
            int quantidadeSalgado = int.Parse(Console.ReadLine());

            Salgados salgado = new Salgados(recheio: (RecheioSalgados)escolhaRecheio, tipo: escolhaTipo, quantidade: quantidadeSalgado);
            //listaComidas.Add(salgado);

            Console.WriteLine("Deseja continuar pedindo? S/N");
            string opcaoPedido = Console.ReadLine().ToUpper();
            if(opcaoPedido == "S")
            {
                fazerPedido();
            }
        }
        /*private static void listarComidas()
        {
            if(listaComidas.Count == 0)
            {
                Console.WriteLine("Nenhuma comida cadastrada.");
                return;
            }

            for(int i = 0; i < listaComidas.Count; i++)
            {
                Comida comida = listaComidas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(comida);
            }
        }
        */
    }
}
