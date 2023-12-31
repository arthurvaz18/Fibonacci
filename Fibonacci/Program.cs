using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;

            Console.WriteLine("Quantos valores? ");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequencia de Fibonacci com " + valores + "valores");


            for (int i = 0; i < valores; i++)
            {
                if (i < valores - 1)
                {
                    Console.WriteLine(a + ", ");
                }
                else
                {
                    Console.WriteLine(a);
                }
                c = a + b;
                a = b;
                b = c;
            }


            Console.WriteLine();

        }
    }
}