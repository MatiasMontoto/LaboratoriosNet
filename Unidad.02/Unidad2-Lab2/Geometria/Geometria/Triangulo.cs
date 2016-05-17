using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo
    {
        private int _altura;
        private int _base;
        private float[] _lados = new float [3];

        public int Altura
        {
            get
            {
                return _altura;
            }

            set
            {
                _altura = value;
            }
        }

        public int Base
        {
            get
            {
                return _base;
            }

            set
            {
                _base = value;
            }
        }

        public float[] Lado
        {
            get
            {
                return _lados;
            }

            set
            {
                _lados = value;
            }
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine("El perimetro es" + (Lado[1] + Lado[2] + Lado[3]));
        }

        public void CalcularSuperficie()
        {
            Console.WriteLine("La superficie es: " + ((Base * Altura) / 2));
        }
    }
}