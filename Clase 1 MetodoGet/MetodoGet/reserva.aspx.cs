using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MetodoGet
{
    public partial class reserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Request.QueryString["nombre"];
            lblApellido.Text = Request.QueryString["apellido"];
            lblSexo.Text = Request.QueryString["sexo"];
            lblPelicula.Text = Request.QueryString["pelicula"];
            lblSnacks.Text = Request.QueryString["snacks"];

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}