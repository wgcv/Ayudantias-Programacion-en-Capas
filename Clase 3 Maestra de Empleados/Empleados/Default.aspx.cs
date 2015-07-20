using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Empleados
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack){
                //Recupera toda el parametro de conexion
                ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
                //Recupera la Varaible de conexion en cadena de caracteres
                string cadenaConexion = param.ConnectionString;
                //Crea un objeto tipo SQL conexion
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                //La sentencia SQL
                string sql = "SELECT * FROM empleados WHERE estado='A'";
                //Se conecta y se realiza la consulta con la base
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                //Creamos un DataSet para agregarlo al gridview
                DataSet ds = new DataSet();
                //Llenamos nuestro DataSet
                da.Fill(ds);
                //Se le especifica el DataSet que usará
                grvEmpleados.DataSource = ds;
                //Se lee los datos del DataSet
               grvEmpleados.DataBind();
        }
    }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            lblBuscarError.Text = "";
              //Recupera toda el parametro de conexion
                ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
                //Recupera la Varaible de conexion en cadena de caracteres
                string cadenaConexion = param.ConnectionString;
                //Crea un objeto tipo SQL conexion
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                //La sentencia SQL
                string sql;
             
                if (ddlBuscar.SelectedValue == "codigo")
                {
                    int numVal = 0;
                    //Se intenta convertir
                    try
                    {
                         numVal = Convert.ToInt32(txtBuscar.Text);
                    }
                    catch {
                        lblBuscarError.Text = " Ingrese un valor valido";
                    }
                    
                    sql = "SELECT * FROM empleados WHERE estado='A' AND " + ddlBuscar.SelectedValue + "=" + numVal;

                }
                else {
                    sql = "SELECT * FROM empleados WHERE estado='A' AND " + ddlBuscar.SelectedValue + "='" + (txtBuscar.Text)+"'";

                }
              //Se conecta y se realiza la consulta con la base
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                //Creamos un DataSet para agregarlo al gridview
                DataSet ds = new DataSet();
                //Llenamos nuestro DataSet
                da.Fill(ds);
                //Se le especifica el DataSet que usará
                grvEmpleados.DataSource = ds;
                //Se lee los datos del DataSet
               grvEmpleados.DataBind();
        }
        }
}

