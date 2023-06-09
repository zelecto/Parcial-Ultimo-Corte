using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Datos
{
    public class D_Persona
    {
        OracleConnection oracleCon = new OracleConnection();
        public string SavePersona(Persona persona)
        {
            OracleCommand comando;
            try
            {
                oracleCon = Conexion.getInstancia().CrearConexion();
                comando = new OracleCommand("INSERT INTO PERSONAS(CEDULA,NOMBRE,TELEFONO) VALUES(:cedula, :nombre,:telefono)",oracleCon);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("cedula", OracleDbType.Varchar2).Value = persona.Cedula;
                comando.Parameters.Add("nombre", OracleDbType.Varchar2).Value = persona.Nombre;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = persona.Telefono;

                oracleCon.Open();
                comando.ExecuteNonQuery();
                oracleCon.Close();
                return "Guardado Correctamente";
                
            }
            catch (Exception)
            {
                return "Error al Guardar";
            }
        }

        public List<Persona> GetPersonaList() {
            OracleCommand comando;
            OracleDataReader lector;
            List<Persona> personas = new List<Persona>();
            try
            {
                oracleCon = Conexion.getInstancia().CrearConexion();
                comando = new OracleCommand("SELECT * FROM Vista_Personas", oracleCon);
                comando.CommandType = CommandType.Text;

                oracleCon.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    personas.Add(Mapper(lector));
                }
                oracleCon.Close();
                return personas;

            }
            catch (Exception)
            {
                return null;
            }


        }

        public Persona Mapper(OracleDataReader reader)
        {
            Persona persona = new Persona();

            persona.Nombre = reader.GetString(0);
            persona.Cedula = reader.GetString(1);
            persona.Telefono = reader.GetString(2);

            return persona;
        }
    }
}
