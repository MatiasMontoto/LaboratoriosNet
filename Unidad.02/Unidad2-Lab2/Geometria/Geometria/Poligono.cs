using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Poligono
    {
        private float _apotema;
        private int _cantLados;
        private float _lado;

        public Poligono()
        {
            Console.Write("Ingrese medida de base:");
            _lado = float.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad de lados:");
            _cantLados = int.Parse(Console.ReadLine());
            Console.Write("Ingrese apotema:");
            _apotema = float.Parse(Console.ReadLine());
        }

        public float Apotema
        {
            get
            {
                return _apotema;
            }

            set
            {
                _apotema = value;
            }
        }

        public int CantLados
        {
            get
            {
                return _cantLados;
            }

            set
            {
                _cantLados = value;
            }
        }

        public float Lado
        {
            get
            {
                return _lado;
            }

            set
            {
                _lado = value;
            }
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine("El perimetro es" + (_lado * _cantLados));
        }

        public void CalcularSuperficie()
        {
            Console.WriteLine("La superficie es" + (((_lado * _apotema) / 2) * _cantLados));
        }
    }
}