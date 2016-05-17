using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adivina
{
    public class Jugada
    {
        private bool _adivino;
        private int _intentos;
        private int _numero;

        public Jugada()
        {
        }

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            _numero = rnd.Next(maxNumero);
        }

        public bool Adivino
        {
            get
            {
                return _adivino;
            }

            set
            {
                _adivino = value;
            }
        }

        public int Intentos
        {
            get
            {
                return _intentos;
            }

            set
            {
                _intentos = value;
            }
        }

        public int Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public virtual bool Comparar(int num)
        {
            if (num == _numero)
            {
                _intentos++;
                _adivino = true;
            }
            else
            {
                _intentos++;
                _adivino = false;
            }

            return _adivino;
        }
    }
}