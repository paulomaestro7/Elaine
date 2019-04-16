using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;

            Console.WriteLine("-----------------");
            Console.WriteLine("Digite uma frase:");
            Console.WriteLine("-----------------");

            frase = Console.ReadLine();
            Console.Clear();

            char[] ch = new char[50];
            ch = frase.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i].Equals('a'))
                {
                    ch[i] = '&';
                }
            }
            Console.WriteLine("----------------");
            Console.WriteLine(ch);
            Console.WriteLine("----------------");
            Console.ReadKey();
        }
    }
}
