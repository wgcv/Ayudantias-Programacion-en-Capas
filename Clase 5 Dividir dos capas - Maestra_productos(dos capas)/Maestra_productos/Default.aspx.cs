using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Maestra_productos
{
    public partial class _Default : System.Web.UI.Page
    {
        libreria lib = new libreria();
        protected void Page_Load(object sender, EventArgs e)
        {
            visible(false);
            /*
            lblcodigo.Visible = false;
            txtcodigo.Visible = false;
            lblnombre.Visible = false;
            txtnombre.Visible = false;
            lblunidad.Visible = false;
            ddlunidad.Visible = false;
            lblcaracteristicas.Visible = false;
            cblcaracteristicas.Visible = false;
            lblinflamable.Visible = false;
            rblinflamable.Visible = false;
            lblcantidad.Visible = false;
            txtcantidad.Visible = false;
            lblmarca.Visible = false;
            ddlmarca.Visible = false;
            btngrabar.Visible = false;
            btnlimpiar.Visible = false;
            btnsalir.Visible = false;
            */
            if (!Page.IsPostBack)
                {
                    string sql = "SELECT co_unidad, nombre_unidad FROM unidad WHERE estado = 'A'";
                    
                    DataSet ds = new DataSet();
                    ds = lib.Consulta(sql);
                    ddlunidad.DataSource = ds;
                    ddlunidad.DataTextField = "nombre_unidad";
                    ddlunidad.DataValueField = "co_unidad";
                    ddlunidad.DataBind();

                    sql = "SELECT co_marca, nombre_marca FROM marca WHERE estado = 'A'";
                    DataSet ds1 = new DataSet();
                    ds1 = lib.Consulta(sql);
                    ddlmarca.DataSource = ds1;
                    ddlmarca.DataTextField = "nombre_marca";
                    ddlmarca.DataValueField = "co_marca";
                    ddlmarca.DataBind();

                    sql = "SELECT codigo, nombre, unidad, caracteristicas, inflamable, cantidad, marca FROM productos WHERE estado = 'A'";
                    DataSet ds2 = new DataSet();
                    ds2 = lib.Consulta(sql);
                    grvproductos.DataSource = ds2;
                    grvproductos.DataBind();

                }



        }

        protected void grvproductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            
            string sql = "SELECT codigo, nombre, unidad, caracteristicas, inflamable, cantidad, marca FROM productos WHERE estado = 'A' AND " + ddlbuscar.SelectedValue + " LIKE '%" + txtbuscar.Text + "%'";

            
            DataSet ds = new DataSet();
            ds = lib.Consulta(sql);
            grvproductos.DataSource = ds;
            grvproductos.DataBind();

        }

        protected void btnnuevo_Click(object sender, EventArgs e)
        {
            visible(true);
            enable("H");
            limpiar();
            /*
            lblnombre.Visible = true;
            txtnombre.Visible = true;
            lblunidad.Visible = true;
            ddlunidad.Visible = true;
            lblcaracteristicas.Visible = true;
            cblcaracteristicas.Visible = true;
            lblinflamable.Visible = true;
            rblinflamable.Visible = true;
            lblcantidad.Visible = true;
            txtcantidad.Visible = true;
            lblmarca.Visible = true;
            ddlmarca.Visible = true;
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;
            btnsalir.Visible = true;
            */
            /*
             txtnombre.Text = "";
            txtcantidad.Text = "";
            ddlunidad.SelectedIndex = 0;
            ddlmarca.SelectedIndex = 0;
            rblinflamable.SelectedIndex = 1;
            cblcaracteristicas.ClearSelection();
             */

            Session["modo"] = "I";
        }

        protected void grvproductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int fila = Convert.ToInt32(e.CommandArgument);
            GridViewRow registro = grvproductos.Rows[fila];
            visible(true);
            /*
            lblcodigo.Visible = true;
            txtcodigo.Visible = true;
            lblnombre.Visible = true;
            txtnombre.Visible = true;
            lblunidad.Visible = true;
            ddlunidad.Visible = true;
            lblcaracteristicas.Visible = true;
            cblcaracteristicas.Visible = true;
            lblinflamable.Visible = true;
            rblinflamable.Visible = true;
            lblcantidad.Visible = true;
            txtcantidad.Visible = true;
            lblmarca.Visible = true;
            ddlmarca.Visible = true;
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;
            btnsalir.Visible = true;
            */
            
            txtcodigo.Text = registro.Cells[1].Text;
            txtcodigo.Enabled = false;
            txtnombre.Text = registro.Cells[2].Text;
            ddlunidad.SelectedItem.Text = registro.Cells[3].Text;
            int i;
            for (i=0; i < cblcaracteristicas.Items.Count - 1;i++)
               {
                if (cblcaracteristicas.Items[i].Text == registro.Cells[4].Text)
                    {
                        cblcaracteristicas.Items[i].Selected = true;
                    }
               }

            for (i = 0; i < rblinflamable.Items.Count - 1; i++)
            {
                if (rblinflamable.Items[i].Text == registro.Cells[5].Text)
                {
                    rblinflamable.Items[i].Selected = true;
                }
            }

            txtcantidad.Text = registro.Cells[6].Text;
            ddlmarca.SelectedItem.Text = registro.Cells[7].Text;
            if (e.CommandName == "eliminar")
                {
                enable("I");
                 /*   txtnombre.Enabled = false;
                    ddlunidad.Enabled = false;
                    cblcaracteristicas.Enabled = false;
                    ddlmarca.Enabled = false;
                    rblinflamable.Enabled = false;
                    txtcantidad.Enabled = false;
               */
                    lblmensaje.Text = "Seguro desea eliminar?";

                    Session["modo"] = "E";
                }
            else
            {
                enable("H");
                /*
                txtnombre.Enabled = true;
                ddlunidad.Enabled = true;
                cblcaracteristicas.Enabled = true;
                ddlmarca.Enabled = true;
                rblinflamable.Enabled = true;
                txtcantidad.Enabled = true;
                 */
                lblmensaje.Text = "";
                                                           
                Session["modo"] = "M";

            }
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            
            string sql = "";
            lblmensaje.Text = "";
            if (Session["modo"]=="I")
               {
                int i;
                string caracteristicas = "";
                for(i=0;i <= cblcaracteristicas.Items.Count -1;i++)
                    {
                       if (cblcaracteristicas.Items[i].Selected == true)
                          {
                           caracteristicas = caracteristicas + " " + cblcaracteristicas.Items[i].Text + " ";
                           }
                     }



                sql = "INSERT INTO productos (nombre,unidad,caracteristicas,inflamable,cantidad,marca,estado) VALUES('" + txtnombre.Text + "','" + ddlunidad.SelectedItem.Text + "','" + caracteristicas + "','" + rblinflamable.SelectedItem.Value + "'," + Convert.ToDecimal(txtcantidad.Text) + ",'" + ddlmarca.SelectedItem.Text + "','A')";
               }
            else
                {
                  if (Session["modo"]=="M")
                      {
                          int i;
                          string caracteristicas = "";
                          for (i = 0; i < cblcaracteristicas.Items.Count - 1; i++)
                          {
                              if (cblcaracteristicas.Items[i].Selected == true)
                              {
                                  caracteristicas = caracteristicas + " " + cblcaracteristicas.Items[i].Text + " ";
                              }
                          }
                          sql = "UPDATE productos SET nombre='" + txtnombre.Text + "',unidad='" + ddlunidad.SelectedItem.Text + "',caracteristicas='" + caracteristicas + "',inflamable='" + rblinflamable.SelectedItem.Value + "',cantidad=" + Convert.ToDecimal(txtcantidad.Text) + ",marca='" + ddlmarca.SelectedItem.Text + "' WHERE codigo = " + Convert.ToInt32(txtcodigo.Text) + ""; 
                      }
                  else
                      {
                          sql = "UPDATE productos SET estado = 'I' WHERE codigo = " + Convert.ToInt32(txtcodigo.Text) + "";
                      }

                }


            int numero_registro = lib.ejecuta(sql);
            if (numero_registro == 1)
            {
                lblmensaje.Text = "Operación realizada exitosamente";
            }
            else
            {
                lblmensaje.Text = "Ocurrio un error intentelo mas tarde";
            }
            
        }

        protected void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtcantidad.Text = "";
            ddlunidad.SelectedIndex = 0;
            ddlmarca.SelectedIndex = 0;
            rblinflamable.SelectedIndex = 1;
            cblcaracteristicas.ClearSelection();
        }

        protected void btnsalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");

        }
        public void visible(Boolean valor)
        {
            txtcodigo.Visible = valor;
            lblcodigo.Visible = valor;
            lblnombre.Visible = valor;
            txtnombre.Visible = valor;
            lblunidad.Visible = valor;
            ddlunidad.Visible = valor;
            lblcaracteristicas.Visible = valor;
            cblcaracteristicas.Visible = valor;
            lblinflamable.Visible = valor;
            rblinflamable.Visible = valor;
            lblcantidad.Visible = valor;
            txtcantidad.Visible = valor;
            lblmarca.Visible = valor;
            ddlmarca.Visible = valor;
            btngrabar.Visible = valor;
            btnlimpiar.Visible = valor;
            btnsalir.Visible = valor;
        }
        public void enable(String valor)
        {
            if (valor == "H")
            {
                txtcodigo.Enabled = true;
                txtnombre.Enabled = true;
                ddlunidad.Enabled = true;
                cblcaracteristicas.Enabled = true;
                rblinflamable.Enabled = true;
                txtcantidad.Enabled = true;
                ddlmarca.Enabled = true;
                btnlimpiar.Enabled = true;
            }
            else
            {
                txtcodigo.Enabled=false;
                txtnombre.Enabled=false;
                ddlunidad.Enabled=false;
                cblcaracteristicas.Enabled=false;
                rblinflamable.Enabled=false;
                txtcantidad.Enabled=false;
                ddlmarca.Enabled=false;
                btnlimpiar.Enabled = false;
            }

        }
        public void limpiar() { 

        txtcodigo.Text="";
        txtnombre.Text="";
        ddlunidad.SelectedIndex=0;
        cblcaracteristicas.ClearSelection();
        rblinflamable.SelectedIndex=0;
        txtcantidad.Text="";
        ddlmarca.SelectedIndex = 0;
        }

    }
}
