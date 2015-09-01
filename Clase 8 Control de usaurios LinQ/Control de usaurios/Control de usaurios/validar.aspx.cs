using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Maestra_productos;
using System.Data;

namespace Control_de_usaurios
{
    public partial class validar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String codigo = Request.QueryString["codigo"];
            String mail = Request.QueryString["correo"];
            libreria coneccion = new libreria();
            String sql = "select confirmacion from usuario where correo ='" + mail + "'";
            DataSet consulta = coneccion.Consulta(sql);
            DataRow dr;
            String codigo2="";
            try
            {
                dr = consulta.Tables[0].Rows[0];
                codigo2 = dr["confirmacion"].ToString();
            }
            catch { }


            if (codigo == codigo2)
            {
                String update = "update usuario set estado='A' where correo='" + mail + "'";
                coneccion.ejecuta(update);
                lblinformacion.Text = "Felicidades ha confirmado su registro";
            }
            else {
                lblinformacion.Text = "No se a confirmado";
            }
        }
    }
}