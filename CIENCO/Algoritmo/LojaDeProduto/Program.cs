using System;
using System.Collections.Generic;
using System.Globalization;

namespace LojaDeProduto
{   
    class Program
    {
        public static List<Produto> produtos = new List<Produto>();
        static void Main(string[] args)
        {
            produtos.Add(new Produto(1001, "Cadeira simples",500.00));
            produtos.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
            produtos.Add(new Produto(1003, "Sofá de três lugares", 2000.00));
            produtos.Add(new Produto(1004, "Mesa retangular", 1500.00));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000.00));
            produtos.Sort();

            Tela.ExibirMenu();
            int opcao = 0;
            Console.Write("Escolha uma opção: ");
            while (opcao!=5){
                opcao = int.Parse(Console.ReadLine());
                if(opcao==1){
                    Tela.ListarProdutos();
                }else if(opcao==2){
                    Tela.CadastrarProdutos();
                }else if(opcao==3){
                    Tela.CadastrarPedido();
                }
                else if(opcao==4){
                    Tela.MostrarPedido();
                }else{
                    Tela.AlertMessage("Opção inválida!", ConsoleColor.Red);
                }
                opcao = 0;
            }
            if(opcao==5){
                    Tela.Sair();
            }

            Console.ReadLine();
        }
    }
}
