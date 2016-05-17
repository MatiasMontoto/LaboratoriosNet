using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adivina
{
    public class Juego
    {
        private int _record = 9999;

        public Juego()
        {
            Console.WriteLine("Juego iniciado");
        }

        public void ComenzarJuego()
        {
            Console.WriteLine("1-Nueva partida, 2-Ver record, 3-Fin");
            ConsoleKeyInfo opcion;
            opcion = Console.ReadKey();
            Console.Clear();

            while (opcion.Key != ConsoleKey.D3)
            {

                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        PreguntarMaximo();
                        break;
                    case ConsoleKey.D2:
                        CompararRecord();
                        break;
                    default:
                        Console.WriteLine("Error ingrese de nuevo");
                        break;
                }

                Console.WriteLine("1-Nueva partida, 2-Comparar con record, 3-Fin");
                opcion = Console.ReadKey();
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("  Fin");
            Console.ReadKey();
        }

        private void CompararRecord()
        {
            Console.WriteLine("Record: " + _record);
        }

        private void Continuar(Jugada a)
        {
            bool rta = true;
            bool acerta = false;
            a.Intentos = 0;
            while (rta == true)
            {
                acerta = PreguntarNumero(a);
                if (acerta == true)
                {
                    if (a.Intentos < _record)
                        _record = a.Intentos;
                    rta = false;
                }
                else
                {
                    bool ingresoBien = true;
                    while (ingresoBien == true)
                    {
                        Console.WriteLine("Desea Continuar?(SI/NO)");
                        string z = Console.ReadLine();
                        if (z.ToUpper() == "NO")
                        {
                            Console.Clear();
                            rta = false;
                            ingresoBien = false;
                        }
                        else if (z.ToUpper() == "SI")
                        {
                            ingresoBien = false;

                        }
                        else
                        {
                            Console.WriteLine("ingrese opcion valida");
                        }
                    }
                }
            }

            if (acerta == true)
            {
                Console.WriteLine("fin ha acertado, cantidad de intentos: " + a.Intentos);
            }
            else
            {
                Console.WriteLine("fin no ha acertado, cantidad de intentos: " + a.Intentos);
            }
        }

        private void PreguntarMaximo()
        {
            Console.WriteLine("ingrese Maximo");
            int Max = Int32.Parse(Console.ReadLine());
            JugadaConAyuda b = new JugadaConAyuda(Max);
            Continuar(b);
        }

        private bool PreguntarNumero(Jugada b)
        {
            Console.WriteLine("ingrese numero");
            int elegido = Int32.Parse(Console.ReadLine());
            bool acerta = b.Comparar(elegido);
            return acerta;
        }
    }
}