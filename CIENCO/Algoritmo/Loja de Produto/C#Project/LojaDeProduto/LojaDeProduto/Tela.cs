using System;
using System.Globalization;

namespace LojaDeProduto
{
    class Tela
    {
        public static void ExibirMenu()
        {
            Console.WriteLine(" 1 - Listar produtos ordenadamente");
            Console.WriteLine(" 2 - Cadastrar produto");
            Console.WriteLine(" 3 – Cadastrar pedido");
            Console.WriteLine(" 4 – Mostrar dados de um pedido");
            Console.WriteLine(" 5 – Sair");
            Console.Write("\n");
            Console.WriteLine(" Digite uma opção: ");

        }

        public static void ListarProdutos()
        {
            for (int i = 0; i < Program.produtos.Count; i++)
            {
                Console.WriteLine(Program.produtos[i]);
            }

        }

        public static void CadastrarProdutos()
        {
            Console.WriteLine(" Digite os dados de um produto.");
            Console.Write(" Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write(" Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write(" Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Program.produtos.Add(new Produto(codigo, descricao, preco));
            Program.produtos.Sort();
        }

        public static void CadastrarPedido()
        {
            Console.WriteLine("Digite os dados do pedido:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Pedido p = new Pedido(codigo, dia, mes, ano);

            Console.WriteLine("Quantos itens tem o pedido?");
            int qte = int.Parse(Console.ReadLine());
       
            for (int i = 1; i <= qte; i++)
            {
                Console.WriteLine("Dados do {0}º pedido.", i);
                Console.Write("Código do produto:");
                int codigoP = int.Parse(Console.ReadLine());
                int pos = Program.produtos.FindIndex(x => x.codigo == codigoP);
                if (pos == -1)
                {
                    throw new ExceptionCase("Código não existe: "+pos);
                }
                Console.Write("Quantidade: ");
                int qteP = int.Parse(Console.ReadLine());
                Console.Write("Porcentage de desconto: ");
                double desconto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                ItemPedido ip = new ItemPedido(qteP, desconto, Program.produtos[pos]);
                p.itens.Add(ip);
            }

            Program.pedidos.Add(p);
        }

        public static void MostrarPedido()
        {
            Console.Write("Digite o código do pedido:");
            int codigoP = int.Parse(Console.ReadLine());
            int pos = Program.pedidos.FindIndex(x => x.codigo == codigoP);
            if(pos == -1)
            {
                throw new ExceptionCase("Pedido inexistente: "+codigoP);
            }
            Console.WriteLine(Program.pedidos[pos]);
        }

        public static void Sair()
        {
            Console.Clear();
            Console.WriteLine();
            ExibirMsg(" Fim da aplicação",ConsoleColor.Red);
        }

        public static void ExibirMsg(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
