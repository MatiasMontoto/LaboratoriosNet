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
            int[] serie;
            Console.Write("Ingrese cantidad de numeros de la serie: ");
            int n = Int32.Parse(Console.ReadLine());
            int sum = 0;
            serie = new int[n];
            serie[0] = 1;
            serie[1] = 1;

            for (int i = 2; i < n; i++)
            {
                serie[i] = serie[i - 2] + serie[i - 1];
            }

            Console.WriteLine("Serie hasta " + n + ": " );
            for (int i = 0; i < n; i++)
            {
                Console.Write(serie[i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                sum = sum + serie[i];
            }

            Console.Write("La suma de los primeros " + n + " numeros de la serie de fibonacci es: " + sum);

            Console.ReadKey();
        }
    }
}
