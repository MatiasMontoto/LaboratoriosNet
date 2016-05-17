using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        public Rectangulo()
        {
            Console.Write("Ingrese medida de base:");
            base.Lado = float.Parse(Console.ReadLine());
            base.CantLados = 4;
            Console.Write("Ingrese altura:");
            base.Apotema = (int.Parse(Console.ReadLine()) / 2);
        }
    }
}