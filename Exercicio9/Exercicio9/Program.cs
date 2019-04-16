using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string executar = "";
            string caminhoSalvar = "calculoImc.txt";
            string nome = "", resultado = "";
            Double peso, altura, imc;
            int idade;

            Console.WriteLine("_______________________");
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1 - Cadastrar Novo");
            Console.WriteLine("2 - Consultar cadastrados");
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
                    Console.Write("Idade: ");
                    idade = int.Parse(Console.ReadLine());
                    Console.Write("Peso: ");
                    peso = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    altura = double.Parse(Console.ReadLine());
                    
                    imc = Math.Round(peso/(altura*altura));
 
                    if (imc < 18.5)
                    {
                        resultado = "Peso abaixo do normal";
                    }
                    else if (imc >= 18.5 && imc < 25)
                    {
                        resultado = "Peso normal";
                    }
                    else if (imc >= 25 && imc < 30)
                    {
                        resultado = "Sobrepeso";
                    }
                    else if (imc >= 30 && imc < 35)
                    {
                        resultado = "Grau de obesidade I";
                    }
                    else if (imc >= 35 && imc < 40)
                    {
                        resultado = "Grau de obesidade II";
                    }
                    else if (imc >= 40)
                    {
                        resultado = "Grau de obesidade III";
                    }
                    StreamWriter gravar = new StreamWriter(caminhoSalvar, true);
                    gravar.WriteLine("######################");
                    gravar.WriteLine("Nome: " + nome);
                    gravar.WriteLine("Idade: " + idade);
                    gravar.WriteLine("Altura: " + altura);
                    gravar.WriteLine("IMC: " + imc);
                    gravar.WriteLine(resultado);
                    gravar.WriteLine("######################");
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
                Console.WriteLine("1 - Cadastrar Novo");
                Console.WriteLine("2 - Consultar cadastrados");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("_______________________");

                executar = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
