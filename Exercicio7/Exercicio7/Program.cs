using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, resultado;
            int escolha;

            do
            {
                Console.WriteLine("______________________________");
                Console.WriteLine("Informe o valor do salário R$");
                Console.WriteLine("______________________________");
                salario = Double.Parse(Console.ReadLine());
                Console.Clear();

                if (salario <= 1.700)
                {
                    resultado = salario + 300.00;
                }
                else
                {
                    resultado = salario + 200.00;
                }
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("Salário com o valor do reajuste é: {0}", resultado.ToString("C"));
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("\nDeseja efetuar outra consulta? 1-Sim 0=-Não");
                
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (escolha != 0);
            Console.ReadKey();
        }
    }
}
