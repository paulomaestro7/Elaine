using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {

            string executar = "";
            string caminhoSalvar = "cliente.txt";
            string nome = "", email = "", rg = "", telefone = "";

            Console.WriteLine("_______________________");
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1 - Gravar um usuário");
            Console.WriteLine("2 - Ler arquivos salvos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("_______________________");

            executar = Console.ReadLine();
            Console.WriteLine();

            while (executar != "0")
            {
                if (executar == "1")
                {
                    Console.Write("Nome Completo: ");
                    nome = Console.ReadLine();
                    Console.Write("E-mail: ");
                    email = Console.ReadLine();
                    Console.Write("RG: ");
                    rg = Console.ReadLine();
                    Console.Write("Telefone: ");
                    telefone = Console.ReadLine();

                    StreamWriter gravar = new StreamWriter(caminhoSalvar, true);
                    gravar.WriteLine("#####################");
                    gravar.WriteLine("Nome Completo: " + nome);
                    gravar.WriteLine("E-mail: " + email);
                    gravar.WriteLine("RG: " + rg);
                    gravar.WriteLine("Telefone: " + telefone);
                    gravar.WriteLine("#####################");
                    gravar.Close();
                }
                else if (executar == "2")
                {
                    StreamReader ler = new StreamReader(caminhoSalvar);

                    while (ler.EndOfStream != true)
                    {
                        Console.WriteLine(ler.ReadLine());
                    }
                    ler.Close();
                }
                Console.WriteLine("\nPressione uma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("_______________________");
                Console.WriteLine("Escolha uma das opções:");
                Console.WriteLine("1 - Gravar um usuário");
                Console.WriteLine("2 - Ler arquivos salvos");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("_______________________");

                executar = Console.ReadLine();
                Console.WriteLine();


            }
        }
    }
}

