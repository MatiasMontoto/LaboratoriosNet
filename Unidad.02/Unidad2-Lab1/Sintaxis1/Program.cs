using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese texto:");
            string inputTexto = Console.ReadLine();
            if (inputTexto == String.Empty)
            {
                Console.WriteLine("String vacio");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("1-Mayusculas, 2-Minusculas, 3-Longitud");

                ConsoleKeyInfo opcion;
                opcion = Console.ReadKey();
                Console.WriteLine();

                if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine(inputTexto.ToUpper());
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine(inputTexto.ToLower());
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine(inputTexto.Length);
                }
                else
                {
                    Console.WriteLine("Error de ingreso.");
                }

                Console.ReadKey();
            }
        }
    }
}
