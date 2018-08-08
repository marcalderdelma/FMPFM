using System;
using System.Collections.Generic;
using System.Globalization;

namespace LojaDeProduto
{
    class Program
    {
        public static List<Produto> produtos = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();


        static void Main(string[] args)
        {
            produtos.Add(new Produto(1001, "Cadeira simples",500.00));
            produtos.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
            produtos.Add(new Produto(1003, "Sofá de três lugares", 2000.00));
            produtos.Add(new Produto(1004, "Mesa retangular", 1500.00));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000.00));
            produtos.Sort();

            int opcao = 0;
            Tela.ExibirMenu();

            while (opcao < 5)
            {
                try { 
                opcao = int.Parse(Console.ReadLine());
                }catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                if (opcao == 1)
                {
                    Tela.ListarProdutos();

                } else if (opcao == 2)
                {
                    try
                    {
                        Tela.CadastrarProdutos();
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Erro inesperado: " + e.Message);
                        opcao = 0;
                    }
                    
                } else if (opcao == 3)
                {
                    try
                    {
                        Tela.CadastrarPedido();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                        opcao = 0;
                    }
                    
                }
                else if (opcao == 4)
                {
                    Tela.MostrarPedido();
                }
                else if (opcao == 5)
                {
                    Tela.Sair();
                }
                

            }
            Console.ReadKey();
        }
    }
}
