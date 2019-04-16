using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, escolha;

            do
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Informe um número:");
                Console.WriteLine("---------------------------");
                numero = int.Parse(Console.ReadLine());
                Console.Clear();

                if (numero % 2 == 0)
                {
                    Console.WriteLine("--------------");
                    Console.WriteLine("O número é Par");
                    Console.WriteLine("--------------"); 
                }
                else
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine("O número é Impar");
                    Console.WriteLine("----------------");
                }

                Console.WriteLine("Deseja conferir outro número? 1 - Sim 0 - Não");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (escolha != 0);

            Console.ReadKey();
        }
    }
}
