using System;
using System.Collections.Generic;

namespace EV_Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opção;
            opção = true;
            ConsoleKey key;
            Console.WriteLine("Digite uma opção (1, 2, 3, 4, 5, 6, 7).");
            key = Console.ReadKey().Key;

            while (opção) {
                switch (key) {
                    case ConsoleKey.NumPad1:
                        Exercicio1();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad2:
                        Exercicio2();
                        //opção = false;
                        break;
                    case ConsoleKey.NumPad3:
                        Exercicio3();
                        break;
                    case ConsoleKey.NumPad4:
                        Exercicio4();
                        break;
                    case ConsoleKey.NumPad5:
                        Exercicio5();
                        break;
                    case ConsoleKey.NumPad6:
                        Exercicio6();
                        break;
                    case ConsoleKey.NumPad7:
                        Exercicio7();
                        
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fim da aplicação!");
                        Console.ResetColor();
                        opção = false;
                        break;
                }
            }
            Console.ReadKey();
        }
        static void Exercicio1()
        {
            Console.WriteLine(" Digite dois números (separando-os com espaço).");
            string[] texto = Console.ReadLine().Split(' ');
            int a = int.Parse(texto[0]);
             int b = int.Parse(texto[1]);
            //Console.WriteLine($"1º número: {a}, 2º número: {b}");
            if(a == b)
            {
                Console.WriteLine($"{a} é igual a {b}");
            }else if(a > b)
            {
                Console.WriteLine($"{a} é maior que {b}");
            }
            else
            {
                Console.WriteLine($"{a} é menor que {b}");
            }

        }
        static void Exercicio2()
        {
            Console.WriteLine("Digite três números (separando-os com espaço).");
            string[] texto = Console.ReadLine().Split(' ');
            List<string> lista = new List<string>();
            lista.Add(texto[0]);
            lista.Add(texto[1]);
            lista.Add(texto[2]);
            lista.Sort();
            lista.Reverse();
            foreach (string n in lista)
            {
                Console.Write($"{n} ");
            }
        }
        static void Exercicio3()
        {
            Console.WriteLine("Digite os três lados A B C de triangulo (separando-os com espaço).");
            string[] texto = Console.ReadLine().Split(' ');
            int a = int.Parse(texto[0]);
            int b = int.Parse(texto[1]);
            int c = int.Parse(texto[2]);

            if (a+b > c || a+c > b || b+c > a)
            {
                Console.WriteLine("A figura não é triangulo.");
            }
            else if(a == b && a == c && b ==c)
            {
                Console.WriteLine($"O triangulo de lados: A = {a}, B = {b}, C = {c} é equilátero.");
            }
            else if(a==b || a==c || b==c)
            {
                Console.WriteLine($"O triangulo de lados: A = {a}, B = {b}, C = {c} é isósceles.");
            }else if(a!=b && b!=c && a!=c)
            {
                Console.WriteLine($"O triangulo de lados: A = {a}, B = {b}, C = {c} é escaleno.");
            }
        }
        static void Exercicio4()
        {
            Console.WriteLine("Número pares de 0 a 100.");
            for(int i = 0; i <= 100; i += 2) {
                Console.WriteLine($"\t{i}");
            }
        }
        static void Exercicio5()
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Número impares de 0 a {n}.");
            for (int i = 1; i <= n; i += 2)
            {
                Console.WriteLine($"\t{i}");
            }
        }
        static void Exercicio7()
        {
            Console.WriteLine("Digite dois números (separando-os com espaço).");
            string[] texto = Console.ReadLine().Split(' ');
            int a = int.Parse(texto[0]);
            int b = int.Parse(texto[1]);
            int c = 0;
            for (int i = 0; i < b; i++)
            {
                c+=a;
            }
            Console.WriteLine($"O produto de {a} * {b} = {c}");
        }
        static void Exercicio6()
        {
            int C = 0;
            Console.Write("\nDigite um número qulquer: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.Write($"Número {i}: ");
                int N = int.Parse(Console.ReadLine());
                C += N;
            }
            double M = C / n;
            Console.WriteLine($"A média dos valores digitados: {C} / {n} = {M.ToString("F2")}");
        }
        static void Exercicio8()
        {

        }

    }
}
