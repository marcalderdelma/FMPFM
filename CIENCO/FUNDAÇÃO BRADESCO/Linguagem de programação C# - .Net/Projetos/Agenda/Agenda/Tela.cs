using System;
using System.IO;
using System.Text;

namespace Agenda {
    class Tela {
        public static void Menu()
        {
            //Inicando as variáveis
            bool opcao;
            ConsoleKey key;
            opcao = true;

            //Estruturando um loop de exibição do menu
            while (true)
            {
                Console.Clear();//Limpando a a tela
                //Montagem do layout do menu
                Console.WriteLine("************* CONTATOS *************");
                Console.WriteLine("* Escolha uma das opções abaixo:   *");
                Console.WriteLine("* 1 - Adicionar contatos           *");
                Console.WriteLine("* 2 - Listar                       *");
                Console.WriteLine("* S - Sair do programa             *");
                Console.WriteLine("*__________________________________*");
                Console.Write("\nOpção:");

                key = Console.ReadKey().Key; //Leitura da tecla apertada pelo usuário
                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        AddContact();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        ListContact();
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine();
                        Sair();
                        opcao = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

        }
        static void AddContact()
        {
            Contato contato;
            Console.WriteLine("Preencher estes campos para adicionar um contato:");
            try
            {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Telefone: ");
                string tel = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                contato = new Contato(id, nome, tel, email);
                SaveContact(contato);
            }
            catch 
            {
                throw new Exception("Erro");
            }
        }
        static void SaveContact(Contato contato)
        {
            byte[] byteArray;
            FileStream file;
            string strContato;
            try
            {
                file = new FileStream(@"C:\Usuários\Público\", FileMode.Append, FileAccess.ReadWrite);
                if (file.CanWrite)
                {
                    strContato = contato.ToString();
                    byteArray = Encoding.ASCII.GetBytes(strContato);
                    file.Write(byteArray, 0, byteArray.Length);
                    file.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        static void ListContact()
        {
            StreamReader reader;
            try {
                reader = new StreamReader(@"C:\Users\Public\");
                if (reader.BaseStream.CanRead) {
                    Console.WriteLine();
                    while (!reader.EndOfStream) {
                        Console.WriteLine(reader.ReadLine());
                    }
                    reader.Close();
                    Console.ReadKey();
                }
            } catch {

            }
            
        }
        static void Sair()
        {

        }
    }
}
