using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public Persona() { }

        public Persona(string cedula, string nombre, string telefono)
        {
            Cedula = cedula;
            Nombre = nombre;
            Telefono = telefono;
        }

        public string Cedula { get; set; }
        public string Nombre { get; set;}
        public string Telefono { get; set;}
    }
}
