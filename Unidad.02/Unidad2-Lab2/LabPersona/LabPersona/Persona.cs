using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPersona
{
    public class Persona
    {
        private string _Nombre;
        private string _Apellido;
        private string _Edad;
        private string _Dni;

        public Persona(string nombre, string apellido, string edad, string dni)
        {
            _Nombre = nombre;
            _Apellido = apellido;
            _Edad = edad;
            _Dni = dni;
            Console.WriteLine("se ha creado una instancia de persona");
        }

        ~Persona()
        {
            Console.WriteLine("se ha eliminado una instancia de persona");
        }

        public string Apellido
        {
            get
            {
                return _Apellido;
            }

            set
            {
                _Apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Dni
        {
            get
            {
                return _Dni;
            }

            set
            {
                _Dni = value;
            }
        }

        public string Edad
        {
            get
            {
                return _Edad;
            }

            set
            {
                _Edad = value;
            }
        }

        public void GetFullName()
        {
            Console.WriteLine(_Nombre + _Apellido);
        }

        public void GetAge()
        {
            Console.WriteLine(_Edad);
        }
    }
}
