using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Digite seu nome:");
            Console.WriteLine("-----------------");
            string nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Olá meu nome é {0} ", nome);
            Console.WriteLine("--------------------------");
            Console.ReadKey();
        }
    }
}
