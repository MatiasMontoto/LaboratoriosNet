using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] arreglo = new string[cantIteraciones];

            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine("Ingrese cadena {0}:",i);
                arreglo[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = cantIteraciones-1; i > -1; i--)
            {
                Console.WriteLine("Cadena {0}: {1}", i, arreglo[i]);
            }

            Console.ReadKey();
        }
    }
}
