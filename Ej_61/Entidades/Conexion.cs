using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Entidades
{
    public static class Conexion
    {
        private const string nombreDB = "asd";
        public static SqlDataReader Execute(string query)
        {
            SqlConnection conexion;
            conexion = new SqlConnection(nombreDB);

            SqlCommand comando;
            comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = query;

            conexion.Open();

            return comando.ExecuteReader();

        }

        public static SqlDataReader Delete(string query)
        {
            SqlConnection conexion;
            conexion = new SqlConnection("sa");

            SqlCommand comando;
            comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = query;

            conexion.Open();

            return comando.ExecuteReader();

        }

        public static SqlDataReader Update(string query)
        {
            SqlConnection conexion;
            conexion = new SqlConnection("sa");

            SqlCommand comando;
            comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = query;

            conexion.Open();

            return comando.ExecuteReader();

        }
    }
}
