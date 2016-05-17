using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] e;
            Console.Write("Ingrese cantidad de numeros de la serie: ");
            int c = Int32.Parse(Console.ReadLine());
            int sum = 0;
            e = new int[c];
            e[0] = 1;
            e[1] = 1;

            for (int i = 2; i < c; i++)
            {
                e[i] = e[i - 2] + e[i - 1];
            }

            Console.WriteLine("Serie hasta " + c + ": " );
            for (int i = 0; i < c; i++)
            {
                Console.Write(e[i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < c; i++)
            {
                sum = sum + e[i];
            }

            Console.Write("La suma de los primeros " + c + " numeros de la serie de fibonacci es: " + sum);

            Console.ReadKey();
        }
    }
}
