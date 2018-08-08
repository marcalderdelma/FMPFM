using System;
using System.Collections.Generic;
using System.Globalization;

namespace Hollywood
{
    class Tela
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("******************Menu******************");
            Console.WriteLine("* 1 – Listar artistas ordenadamente    *");
            Console.WriteLine("* 2 – Cadastrar artista                *");
            Console.WriteLine("* 3 – Cadastrar filme                  *");
            Console.WriteLine("* 4 – Mostrar dados de um filme        *");
            Console.WriteLine("* 5 – Sair                             *");
            Console.WriteLine("****************************************");
            Console.WriteLine("");
            Console.Write("Digite uma opção: ");


        }
        public static void ListarArtistas()
        {
            Console.WriteLine("LISTAGEM DE ARTISTAS: ");
            for(int i = 0; i < Program.artistas.Count; i++)
            {
                Console.WriteLine(Program.artistas[i]);
            }
        }
        public static void CadastrarAtista()
        {
            Console.WriteLine("Digite os dados do artista.");
            Console.Write("Código: ");
            try
            {
                int codigo = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Cachê: ");
                double cache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Program.artistas.Add(new Artista(codigo, nome, cache));
                Program.artistas.Sort();
            } catch
            {
                throw new ExceptionCase("Digite números inteiros!");
            }

        }
        public static void CadastrarFilme()
        {
            Console.WriteLine("Digite os dados do filme.");
            Console.Write("Código: ");
            try
            {
                int codigo = int.Parse(Console.ReadLine());
                Console.Write("Titúlo: ");
                string titulo = Console.ReadLine();
                Console.Write("Ano: ");
                int ano = int.Parse(Console.ReadLine());
                Filme F = new Filme(codigo,titulo,ano);
                Console.Write("Quantas participações tem o filme: ");
                int participacao = int.Parse(Console.ReadLine());
                for (int i = 1; i <= participacao; i++ )
                {
                    Console.WriteLine("Digite os dados do {0}º artista:", i);
                    Console.Write("Artista (código): ");
                    int artistaCod = int.Parse(Console.ReadLine());
                    int pos = Program.artistas.FindIndex(x => x.codigo == artistaCod);
                    if(pos == -1)
                    {
                        throw new ExceptionCase("Código inválido!");
                    }
                    Console.Write("Desconto da participação do artista: ");
                    double artistaDesc = double.Parse(Console.ReadLine());
                    Participacao pA = new Participacao(artistaDesc, Program.artistas[pos]);
                    F.participacaos.Add(pA);
                }
                Program.filmes.Add(F);

            }
            catch
            {
                throw new ExceptionCase("As informaçoes fornecidas são inválidas, confira.");
            }
            

        }

        public static void MostrarCadastroFilme()
        {
            Console.WriteLine("Digite os dados do filme:");

            Console.Write("Código: ");    
            int codF = int.Parse(Console.ReadLine());
            int pos = Program.filmes.FindIndex(x => x.codigo == codF);
            if (pos == -1)
             {
                throw new ExceptionCase("Cadastro inexitente: " + pos);
             }
            Console.WriteLine(Program.filmes[pos]);
            

        }
        public static void Sair()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Fim da Aplicação!");
            Console.ResetColor();
        }
    }
}
