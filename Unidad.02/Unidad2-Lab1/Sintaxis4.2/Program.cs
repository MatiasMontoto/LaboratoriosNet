using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string año;
            int a;
            Console.Write("Ingrese un año: ");
            año = Console.ReadLine();

            a = Int32.Parse(año);

            if ( (a%4) == 0)
            {
                if ( (a%100) == 0)
                {
                    if ( (a%400) == 0)
                    {
                        Console.WriteLine("Año bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("Año no bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("Año bisiesto");
                }
            }
            else
            {
                Console.WriteLine("Año no bisiesto");
            }

            Console.ReadKey();
        }
    }
}
