using System;
using System.Globalization;
using System.Collections.Generic;

namespace LojaDeProduto
{
    public class Tela
    {
        public static void ExibirMenu(){
            Console.WriteLine("1 – Listar produtos ordenadamente");
            Console.WriteLine("2 – Cadastrar produto");
            Console.WriteLine("3 – Cadastrar pedido");
            Console.WriteLine("4 – Mostrar dados de um pedido");
            Console.WriteLine("5 – Sair"); 
        }

        public static void ListarProdutos(){
            Console.WriteLine("Listagem de produtos:");
            for (int i=0; i<Program.produtos.Count; i++){
                Console.WriteLine(Program.produtos[i]);
            }
        }

        public static void CadastrarProdutos(){
            Console.WriteLine("Digite os dados de um produto.");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Program.produtos.Add(new Produto(codigo,descricao,preco));
            Program.produtos.Sort();
        }

        public static void CadastrarPedido()
        {

        }

        public static void MostrarPedido()
        {

        }

        public static void Sair(){
            Console.Clear();
            Console.WriteLine("Fim da aplicação!!!");
        }
        public static void AlertMessage(string msg, ConsoleColor color){
            Console.WriteLine(msg,color);
            Console.ResetColor();
        }
    }
}
