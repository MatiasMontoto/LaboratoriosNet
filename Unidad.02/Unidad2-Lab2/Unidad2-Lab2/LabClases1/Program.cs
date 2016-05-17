using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A("Inst");
            B obj2 = new B();

            obj2.M1();
            obj2.M2();
            obj2.M3();
            obj2.M4();
            obj2.MostrarNombre();

            obj1.MostrarNombre();
            obj1.M1();
            obj1.M2();
            obj1.M3();

            Console.ReadKey();
        }
    }
}
