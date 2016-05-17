using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado()
        {
            Console.Write("Ingrese medida de base:");
            base.Lado = float.Parse(Console.ReadLine());
            base.CantLados = 4;
            base.Apotema = (base.Lado / 2);
        }
    }
}