using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class DB
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        public DB(string connectionStr)
        {
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
        }

        private void Comando()
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        private void CargarQuery(string query)
        {
            Comando();

            comando.CommandText = query;
            conexion.Open();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query">La consulta completa</param>
        /// <param name="opcion">true indica que la consulta es de un SELECT</param>
        /// <returns>SqlDataReader o Null</returns>
        public SqlDataReader EjecutarQuery(string query, bool opcion)
        {
            SqlDataReader oDr;

            Comando();
            CargarQuery(query);

            if (opcion)
            {
                oDr = comando.ExecuteReader();
                return oDr;
            }
            else
            {
                comando.ExecuteNonQuery();
                return null;
            }
        }
    }
}
