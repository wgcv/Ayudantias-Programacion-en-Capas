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
    public partial class BusquedaEspecifica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
           
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            libreria con = new libreria();
            DataSet ds = new DataSet();
            ds = con.ConsultaEsp(ddlBuscar.SelectedItem.Text, txtBuscar.Text );
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}