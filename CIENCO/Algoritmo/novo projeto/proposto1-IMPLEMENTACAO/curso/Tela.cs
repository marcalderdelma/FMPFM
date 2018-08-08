using System;
using System.Globalization;
using curso.dominio;

namespace curso {

    // Classe responsavel por conter operações que interagem com o usuário
    // no modo console

    class Tela {
        public static void mostrarMenu() {
            Console.WriteLine("1 - Listar artistas ordenadamente");
            Console.WriteLine("2 - Cadastrar artista");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opção: ");
        }

        public static void mostrarArtistas() {
            Console.WriteLine("LISTAGEM DE ARTISTAS:");
            for (int i = 0; i < Program.artistas.Count; i++) {
                Console.WriteLine(Program.artistas[i]);
            }
            Console.WriteLine();
        }

        public static void cadastrarArtista() {
            Console.WriteLine("Digite os dados do artista: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do cachê: ");
            double cache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Artista A = new Artista(codigo, nome, cache);
            Program.artistas.Add(A);
            Program.artistas.Sort();
        }

        public static void cadastrarFilme() {
            Console.WriteLine("Digite os dados do filme: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Filme F = new Filme(codigo, titulo, ano);
            Console.Write("Quantas participações tem o filme? ");
            int N = int.Parse(Console.ReadLine());
            for (int i=1; i<=N; i++) {
                Console.WriteLine("Digite os dados da " + i + "ª participação:");
                Console.Write("Artista (código): ");
                int codArtista = int.Parse(Console.ReadLine());
                int pos = Program.artistas.FindIndex(x => x.codigo == codArtista);
                if (pos == -1) {
                    throw new ModelException("Código de artista não encontrado: " + codArtista);
                }
                Console.Write("Desconto: ");
                double desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Participacao part = new Participacao(desconto, Program.artistas[pos], F);
                F.participacoes.Add(part);
            }
            Program.filmes.Add(F);
        }

        public static void mostrarFilme() {
            Console.Write("Digite o código do filme: ");
            int codFilme = int.Parse(Console.ReadLine());
            int pos = Program.filmes.FindIndex(x => x.codigo == codFilme);
            if (pos == -1) {
                throw new ModelException("Código de filme não encontrado: " + codFilme);
            }
            Console.WriteLine(Program.filmes[pos]);
            Console.WriteLine();
        }
    }
}
