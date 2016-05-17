using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero de filas:");
            int num = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int b = 0; b < num - (i + 1); b++)
                    Console.Write(" ");

                for (int j = -2; j < (2 * i) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
