using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Maestra_productos
{
    public class libreria
    {
        public DataSet Consulta(string sql)
            {
                ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
                string cadena_conexion = param.ConnectionString;

                SqlConnection conn = new SqlConnection(cadena_conexion);
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        public int ejecuta(string sql)
            {
                ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
                string cadena_conexion = param.ConnectionString;

                SqlConnection conn = new SqlConnection(cadena_conexion);
                SqlCommand comando = new SqlCommand(sql, conn);
                conn.Open();
                int numero_registro = comando.ExecuteNonQuery();
                conn.Close();
                return numero_registro;
            }
    }
}