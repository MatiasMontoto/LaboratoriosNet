using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis2
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

                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine();

                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine(inputTexto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine(inputTexto.Length);
                        break;
                    default: Console.WriteLine("Error de ingreso.");
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
