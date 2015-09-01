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
        public DataSet ConsultaEsp(String campo, String dato)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;

            SqlConnection conn = new SqlConnection(cadena_conexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conn;
            comando.CommandText = "ConsultaEspecifica";
            comando.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlParameter p_campo = new SqlParameter("@campo",  campo );
            p_campo.Size = 50;
            adapter.SelectCommand = comando;

                SqlParameter p_dato;
                if (campo != "id")
                {
                    p_dato = new SqlParameter("@dato", "'" + dato + "'");
                    
                }
                else
                {
                    p_dato = new SqlParameter("@campo", dato);
                }
                  p_dato.Size = 50;
                comando.Parameters.Add(p_dato);
                comando.Parameters.Add(p_campo);
                int numero_registro = comando.ExecuteNonQuery();
                adapter.UpdateCommand = comando;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
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