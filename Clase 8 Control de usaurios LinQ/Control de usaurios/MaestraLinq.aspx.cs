using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Control_de_usaurios
{
    public partial class MaestraLinq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ClaseGeneral cg = new ClaseGeneral();
                GridView1 = cg.mostrar(GridView1);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClaseGeneral cg = new ClaseGeneral();
            cg.guardar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
            Response.Redirect("MaestraLinq.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClaseGeneral cg = new ClaseGeneral();
            if (DropDownList1.SelectedItem.Text == "Nombre")
            {
                GridView1 = cg.ConsultaNombre(GridView1, TextBox5.Text);
            }
            if (DropDownList1.SelectedItem.Text == "Apellido")
            {
                GridView1 = cg.ConsultaApellido(GridView1, TextBox5.Text);
            }
            if (DropDownList1.SelectedItem.Text == "Correo")
            {
                GridView1 = cg.ConsultaCorreo(GridView1, TextBox5.Text);
            }
        }
    }
}