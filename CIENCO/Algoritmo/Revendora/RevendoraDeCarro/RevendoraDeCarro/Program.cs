using System;
using System.Collections.Generic;

namespace RevendoraDeCarro
{
    class Program
    {
        public static List<Marca> marcas = new List<Marca>();
        public static List<Carro> carros = new List<Carro>();
        static void Main(string[] args)
        {
            //Cadastrando Marcas inicialmente
            Marca M1 = new Marca(1002, "General Motors", "Estados Unidos");
            Marca M2 = new Marca(1001, "Volksvagen", "Alemanha");
            marcas.Add(M1);
            marcas.Add(M2);
            marcas.Sort();
          
            //Cadastrando Carro 
            Carro c1, c2, c3, c4, c5, c6;
            c1 = new Carro(101, "Fusca", 1980, 5000, M2);
            M2.addCarro(c1);
            c2 = new Carro(102, "Golf", 2016, 60000, M2);
            M2.addCarro(c2);
            c3 = new Carro(103, "Fox", 2017, 30000, M2);
            M2.addCarro(c3);
            c4 = new Carro(104, "Cruze", 2016, 30000, M1);
            M1.addCarro(c4);
            c5 = new Carro(105, "Cobalt", 2015, 25000, M1);
            M1.addCarro(c5);
            c6 = new Carro(106, "Cobalt", 2017, 35000, M1);
            M1.addCarro(c6);
            //adicionar os carros cadastrado em lista
            carros.Add(c1);
            carros.Add(c2);
            carros.Add(c3);
            carros.Add(c4);
            carros.Add(c5);
            carros.Add(c6);
            carros.Sort();

            //marcas(1).setCars(carros);
            int opcao = 0;

            while(opcao != 7)
            {
                Console.Clear();
                Tela.Menu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }catch(Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                Console.WriteLine();
                if (opcao == 1)
                {
                    Tela.ListarMarcas();
                }
                else if(opcao == 2)
                {   
                    try
                    {
                        Tela.ListarCarros();  
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }else if (opcao == 3)
                {
                    try
                    {
                        Tela.CadastrarMarca();
                    }catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }else if (opcao == 4)
                {
                    try
                    {
                        Tela.CadastrarCarro();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
                else if (opcao == 5)
                {
                    try
                    {
                        Tela.CadastrarAcessorio();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (opcao == 6)
                {
                    try
                    {
                        Tela.MostrarCarro();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
                else if (opcao == 7)
                {
                    try
                    {
                        Tela.Sair();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
                else
                {
                    Console.WriteLine("Opçção inválida.");
                }
            }
        }
    }
}
