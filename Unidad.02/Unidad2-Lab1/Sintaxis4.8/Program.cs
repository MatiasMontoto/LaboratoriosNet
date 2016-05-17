using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            string clave, pass = "asdfg";
            while (intentos < 4)
            {
                intentos++;
                Console.WriteLine("Ingrese contraseña:");
                clave = Console.ReadLine();
                if (clave == pass)
                {
                    Console.WriteLine("Contraseña ingresada correctamente");
                    intentos = 4;
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");
                    Console.WriteLine("Intento {0} de 4", intentos);
                }
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
    }
}
