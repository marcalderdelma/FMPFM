using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevendoraDeCarro
{
    class Tela
    {
        public static void Menu()
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("*                    Menu                         *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* 1 – Listar marcas                               *");
            Console.WriteLine("* 2 – Listar carros de uma marca ordenadamente    *");
            Console.WriteLine("* 3 – Cadastrar marca                             *");
            Console.WriteLine("* 4 – Cadastrar carro                             *");
            Console.WriteLine("* 3 – Cadastrar acessório                         *");
            Console.WriteLine("* 6 – Mostrar detalhes de um carro                *");
            Console.WriteLine("* 7 – Sair                                        *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("");
            Console.Write("Digite uma opção: ");
        }

        public static void ListarMarcas()
        {
            Console.WriteLine("LISTAGEM DE MARCAS:");
            for (int i = 0; i < Program.marcas.Count; i++)
            {
              Console.WriteLine(Program.marcas[i]);  
            }
        }
        public static void ListarCarros(){
            Console.Write("Digite o código da marca: ");
            try
            {
                int codMarca = int.Parse(Console.ReadLine());
                int pos = Program.marcas.FindIndex(x => x.codigo == codMarca);
                if(pos == -1)
                {
                    throw new Exception("Código inexistente.");
                }
                Console.WriteLine("Carro(s) da marca "+ Program.marcas[pos].nome +": ");
                for (int i = 0; i < Program.carros.Count; i++)
                {
                    if (Program.carros[i].marca == Program.marcas[pos])
                    {
                        Console.WriteLine(Program.carros[i]);
                    }
                }
            }
            catch 
            {
                
                throw new Exception("Código inválido.");
            }
        }
        public static void CadastrarMarca()
        {
            Console.WriteLine("Digite os dados da marca:");
            Console.Write("Código: ");
            try
            {
                int cod = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("País de origem: ");
                string pais = Console.ReadLine();
                Marca m = new Marca(cod,nome,pais);
                Program.marcas.Add(m);
                Program.marcas.Sort(); 
            }
            catch 
            {
                
                throw new Exception("Erro de operação.");
            }
        }
        public static void CadastrarCarro()
        {
            Console.WriteLine("Digita os dados do carro:");
            Console.Write("Marca (código): ");
            try
            {
                int codM = int.Parse(Console.ReadLine());
                int pos = Program.marcas.FindIndex(x => x.codigo == -1);
                if (pos == -1)
                {
                    Console.WriteLine("Código inexistente.");
                }
                else
                {
                    Console.Write("Código do carro");
                    int codC = int.Parse(Console.ReadLine());
                    Console.Write("Modelo: ");
                    string mod = Console.ReadLine();
                    Console.Write("Ano: ");
                    int ano = int.Parse(Console.ReadLine());
                    Console.Write("Preço básico: ");
                    double pb = double.Parse(Console.ReadLine());
                    Carro c = new Carro(codC,mod,ano,pb,Program.marcas[pos]);
                    Program.carros.Add(c);
                    Program.carros.Sort();
                }
            }
            catch
            {

                throw new Exception("Código inválido, digite apenas números inteiros.");
            }
        }
        public static void CadastrarAcessorio()
        {
            Console.WriteLine("Digite os dados do acessório");
            Console.Write("Carro (código): ");
            try
            {
                int codC = int.Parse(Console.ReadLine());
                int pos = Program.carros.FindIndex(x => x.codigo == codC);
                if (pos == -1)
                {
                    Console.WriteLine("Código inexistente.");
                }else
                {
                    Console.Write("Descrição: ");
                    string descricao = Console.ReadLine();
                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine());
                    Acessrio a = new Acessrio(descricao,preco);
                    Carro c = Program.carros[pos];
                    c.acessrios.Add(a);
                }
            }
            catch
            {
                throw new Exception("Erro de negócio.");
            }
        }
        public static void MostrarCarro()
        {
            Console.Write("Digite o código do carro: ");
            try
            {
                int codC = int.Parse(Console.ReadLine());
                int pos = Program.carros.FindIndex(x => x.codigo == codC);
                if (pos == -1)
                {
                    Console.WriteLine("Código inexistente.");
                }
                else
                {
                    Console.WriteLine(Program.carros[pos]);
                }

            }
            catch
            {
                throw new Exception("Erro de negócio.");
            }

        }
        public static void Sair()
        {
            
        }
    }
}
