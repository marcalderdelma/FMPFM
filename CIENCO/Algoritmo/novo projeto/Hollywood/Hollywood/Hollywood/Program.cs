using System;
using System.Collections.Generic;


namespace Hollywood
{
    class Program
    {
        public static List<Artista> artistas = new List<Artista>();
        public static List<Filme> filmes = new List<Filme>();

        static void Main(string[] args)
        {
            artistas.Add(new Artista(102,"Chris Evans",2500000.00));
            artistas.Add(new Artista(104,"Morgan Freeman",4000000.00));
            artistas.Add(new Artista(101,"Scarlett Johansson",4000000.00));
            artistas.Add(new Artista(103,"Robert Downey Jr",3000000.00));
            artistas.Sort();

            Tela.MostrarMenu();
            int opcao = 0;

            while (opcao <= 5)
            {
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch
                {
                    throw new ExceptionCase("Opção inválida!");
                }
                
                if (opcao == 1)
                {
                    Tela.ListarArtistas();
                    opcao = 0;
                }
                else if (opcao == 2)
                {
                    try
                    {
                        Tela.CadastrarAtista();
                    }catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        opcao = 0;
                    }
                }
                else if (opcao == 3)
                {
                    try
                    {
                        Tela.CadastrarFilme();
                    }catch(ExceptionCase e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
                else if (opcao == 4)
                {
                    try
                    {
                        Tela.MostrarCadastroFilme();
                    }catch(ExceptionCase e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (opcao == 5)
                {
                    try
                    {
                        Tela.Sair();
                    }
                    catch(ExceptionCase e)
                    {
                        Console.WriteLine(e.Message);
                      
                    }

                }
            }
            opcao = int.Parse(Console.ReadLine());
            Tela.ListarArtistas();
            Console.ReadLine();


        }
    }
}
