using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Se deben importar estas librerias
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Maestra
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
                string cadenaConexcion = param.ConnectionString;
                SqlConnection conexion = new SqlConnection(cadenaConexcion);
                string sql = "Select * from productos where estado = 'A'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                grvProductos.DataSource = ds;
                grvProductos.DataBind();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadenaConexcion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadenaConexcion);
            string sql = "Insert into productos (nombre, unidad, caracteristicas, inflamable, cantidad, marca,estado) values ('" + txtNombre.Text+"','" + txtUnidad.Text +"','"+ txtCaracteristica.Text+"','"+txtInflamabilidad.Text +"'," + Convert.ToDecimal(txtCantidad.Text) +",'"+txtMarca.Text+"', 'A' )";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            conexion.Open();
            int confirmacion = cmd.ExecuteNonQuery();
            if (confirmacion == 1)
            {
                lblConfirmacion.Text = "Se  agrego con éxito";
            }
            Response.Redirect("Default.aspx");
        }

        /*
         * 
         *   SqlCommand commando = new SqlCommand(sql, conexion);
            conexion.Open();
            int numeo_registro = commando.ExecuteNonQuery();
            if (numeo_registro == 1)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Se realiazo con éxito";
            }else{   lblMensaje.Visible = true;
         * ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
                string cadenaConexion = param.ConnectionString;
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                string sql = "SELECT * FROM empleados WHERE estado='A'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                grvEmpleado.DataSource = ds;
                grvEmpleado.DataBind()*/

    }
}
