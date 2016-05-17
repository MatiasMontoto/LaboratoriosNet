using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis4._5
{
    class Program
    {
        enum Meses
        {
            enero=1, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese mes: ");
            string mes = Console.ReadLine();
            
            for (int i = 0; i < 12; i++)
            {
                if (Enum.GetName(typeof(Meses), i) == mes)
                {
                    Console.WriteLine(mes + " es el mes numero: " + (int)i);
                }
            }

            Console.ReadKey();
        }
    }
}
