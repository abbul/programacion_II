using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PersonaDAO
    {
        public static bool Guardar(Persona persona)
        {
            List<Persona> personas = new List<Persona>();

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("INSERT INTO Persona (nombre,apellido) VALUES ({1},{2})", persona.Nombre, persona.Apellido);

            SqlDataReader dato = Conexion.Execute(Convert.ToString(sb));

            while (dato.Read())
            {
                personas.Add(new Persona( Convert.ToInt32(dato["id"].ToString()), dato["nombre"].ToString(), dato["apellido"].ToString()) );
            }

            return false;
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();
            SqlDataReader datos = Conexion.Execute("SELECT * FROM Persona");

            while (datos.Read())
            {
                personas.Add(new Persona(Convert.ToInt32(datos["id"].ToString()), datos["nombre"].ToString(), datos["apellido"].ToString()));
            }

            return personas;
        }
        public static  Persona LeerPorID(int id)
        {
            
            SqlDataReader dato = Conexion.Execute("SELECT * FROM Persona WHERE id="+id);

            Persona persona = new Persona( Convert.ToInt32(dato["id"].ToString()), dato["nombre"].ToString(), dato["apellido"].ToString());
            
            return persona;
        }

        public static Persona Modificar(Persona persona)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("UPDATE Persona SET nombre={1},apellido={2} WHERE id= {3}",persona.Nombre, persona.Apellido, persona.Id);

            SqlDataReader dato = Conexion.Execute(Convert.ToString(sb));

            Persona aux = new Persona(Convert.ToInt32(dato["id"].ToString()), dato["nombre"].ToString(), dato["apellido"].ToString());

            return aux;
        }

        public static bool Borrar(int id)
        {
            bool salida;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("DELTE FROM Persona WHERE id= {1}", id);
                Conexion.Execute(Convert.ToString(sb));
                salida = true;
            }
            catch (Exception)
            {
                salida = false;
                throw;
            }

            return salida;
        }
    }
}
