using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adivina
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero)
        {
            Random rnd = new Random();
            base.Numero = rnd.Next(maxNumero);
        }

        public override bool Comparar(int num)
        {
            bool a = base.Comparar(num);
            if (a == false)
            {
                if ((base.Numero - num) > 100)
                {
                    Console.WriteLine("Es mayor y dista a mas de 100 numeros");
                }
                else if ((num - base.Numero) > 100)
                {
                    Console.WriteLine("Es menor y dista a mas de 100 numeros");
                }
                else if ((base.Numero - num) > 50)
                {
                    Console.WriteLine("Es mayor y dista a mas de 50 numeros");
                }
                else if ((num - base.Numero) > 50)
                {
                    Console.WriteLine("Es menor y dista a mas de 50 numeros");
                }
                else if ((base.Numero - num) > 10)
                {
                    Console.WriteLine("Es mayor y dista a mas de 10 numeros");
                }
                else if ((num - base.Numero) > 10)
                {
                    Console.WriteLine("Es menor y dista a mas de 10 numeros");
                }
                else if ((num - base.Numero) < 10 && (num - base.Numero) > 0)
                {
                    Console.WriteLine("Es menor y dista a menos de 10 numeros");
                }
                else if ((base.Numero - num) < 10 && (num - base.Numero) < 0)
                {
                    Console.WriteLine("Es mayor y dista a menos de 10 numeros");
                }
            }

            return a;
        }
    }
}