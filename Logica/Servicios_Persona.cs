using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Servicios_Persona
    {
        D_Persona daoPersona = new D_Persona();
        public string AddPersona(Persona persona)
        {
            return daoPersona.SavePersona(persona);
        }
        public List<Persona> GetPersonaList() {
        
            return daoPersona.GetPersonaList();
        }

    }
}
