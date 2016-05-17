using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Circulo
    {
        private int m_radio;

        public int Radio
        {
            get
            {
                return m_radio;
            }

            set
            {
                m_radio = value;
            }
        }

        public void CalcularPerimetro()
        {
            double perimetro = 0;
            perimetro = m_radio * 2 * 3.14;
            Console.WriteLine("Perimetro: " + perimetro);
        }

        public void CalcularSuperficie()
        {
            double superficie = 0;
            superficie = 3.14 * Math.Pow(m_radio, 2);
            Console.WriteLine("La superficie es: " + superficie);
        }
    }
}
