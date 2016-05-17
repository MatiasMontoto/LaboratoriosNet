using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] romanos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
            int[] valores = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            Console.Write("Ingrese numero entero: ");
            int n = Int32.Parse(Console.ReadLine());
            int numeroIngresado = n;
            string r = "";

            for (int i = 0; i < 13; i++)
            {
                while (valores[i] <= n)
                {
                    r = r + romanos[i];
                    n = n - valores[i];
                }
            }

            Console.Write(numeroIngresado + " en romano es = " + r);
            Console.ReadKey();
        }
    }
}
