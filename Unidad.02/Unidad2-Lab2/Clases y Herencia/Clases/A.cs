using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class A
    {
        public string NombreInstancia { get; set; }

        public A()
        {
            NombreInstancia = "Instancia sin nombre";
        }
        public A(string nombre)
        {
            NombreInstancia = nombre;
        }

        public void MostrarNombre()
        {
            Console.WriteLine(NombreInstancia);
        }

        public void M1()
        {
            Console.WriteLine("Se invoco el metodo 1");
        }
        public void M2()
        {
            Console.WriteLine("Se invoco el metodo 2");
        }
        public void M3()
        {
            Console.WriteLine("Se invoco el metodo 3");
        }
    }
}
