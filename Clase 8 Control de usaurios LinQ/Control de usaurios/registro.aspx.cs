using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Maestra_productos;
using System.Net.Mail;
using System.Net;

namespace Control_de_usaurios
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == txtClave2.Text)
            {
                libreria registro = new libreria();
                Random rand = new Random();
                int confirmacion = rand.Next(1000,9999);
                String sql = "Insert into usuario (nombre, apellido, correo, clave, confirmacion, estado) Values ('" + txtNombre.Text + "' , '" + txtApellido.Text + "','" + txtCorreo.Text + "','" + txtClave.Text + "', '" + confirmacion + "','P')";
                registro.ejecuta(sql);
                SmtpClient client = new SmtpClient();
                client.Host = "smtp-mail.outlook.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("ucsg3@outlook.com", "programacion3");

                //Enviando correo
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("maildepreubaayudantias@gmail.com");
                mail.To.Add(new MailAddress(txtCorreo.Text));
                mail.Subject = "Confirmacion de correo.";
                mail.IsBodyHtml = true;
                mail.Body = "<h2> Su codigo de confirmacion es : </h2><br> <h1>" + confirmacion + "</h1> Ingresa a esta pagina para validar:  <a href='http://localhost:4320/validar.aspx?codigo=" + confirmacion + "&correo=" + txtCorreo.Text + "'>Confirmar<a/>";
                lblInformacion.Text = "<h2> Su codigo de confirmacion es : </h2><br> <h1>" + confirmacion + "</h1> Ingresa a esta pagina para validar:  <a href='http://localhost:4320/validar.aspx?codigo=" + confirmacion + "&correo=" + txtCorreo.Text + "'>Confirmar<a/>";
              
                // client.Send(mail);
            }
            else
            {
                lblInformacion.Text = "La clave que ingreso no son iguales";

            }
        }
    }
}