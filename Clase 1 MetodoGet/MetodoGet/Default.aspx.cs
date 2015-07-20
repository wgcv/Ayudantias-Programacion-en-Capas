using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MetodoGet
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //rblPelicula.SelectedIndex = 0;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApeliido.Text;
            String sexo = ddlSexo.SelectedValue;
            String pelicula = rblPelicula.SelectedValue;
            String snacks = "";
            for (int i = 0; i < cblSnack.Items.Count; i++)
            {
                if (cblSnack.Items[i].Selected)
                {
                    snacks = snacks + cblSnack.Items[i].Text + " ";
                }
            }

            Response.Redirect("reserva.aspx?nombre=" + nombre + "&apellido=" + apellido + "&sexo=" + sexo + "&pelicula=" + pelicula + "&snacks=" + snacks);
         
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
