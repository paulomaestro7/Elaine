using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Informe sua idade:");
            Console.WriteLine("------------------");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (idade <= 17)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem permissão");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão Concedida");
            }
            Console.ReadKey();
        }
    }
}
