using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, resultado;
            int escolha;
            do
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Informe o primeiro número: ");
                Console.WriteLine("---------------------------");
                numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("---------------------------");
                Console.WriteLine("Informe o segundo número: ");
                Console.WriteLine("---------------------------");
                numero2 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Escolha uma das opções abaixo:\n1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n0-Sair");
                escolha = Convert.ToInt32(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        Console.WriteLine("Resultado da soma: {0}", resultado);
                        break;
                    case 2:
                        resultado = numero1 - numero2;
                        Console.WriteLine("Resultado da subtração: {0}", resultado);
                        break;
                    case 3:
                        resultado = numero1 * numero2;
                        Console.WriteLine("Resultado da multiplicação: {0}", resultado);
                        break;
                    case 4:
                        resultado = numero1 / numero2;
                        Console.WriteLine("Resultado da divisão: {0}", resultado);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Deseja efetuar mais uma operação? 1 - Sim 0 - Não");
                escolha = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (escolha != 0);

            Console.ReadKey();
        }
    }
}
