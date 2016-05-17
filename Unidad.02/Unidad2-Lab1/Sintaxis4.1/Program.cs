using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero1, numero2;
            int a = 0, b = 0, c = 0;

            Console.Write("Ingrese primer numero: ");
            numero1 = Console.ReadLine();
            Console.Write("Ingrese segundo numero: ");
            numero2 = Console.ReadLine();

            a = Int32.Parse(numero1);
            b = Int32.Parse(numero2);
            c = a + b;

            Console.WriteLine("El resultado de la suma de: " + numero1 + " y " + numero2 + " es: " + c);
            Console.ReadKey();
        }
    }
}
