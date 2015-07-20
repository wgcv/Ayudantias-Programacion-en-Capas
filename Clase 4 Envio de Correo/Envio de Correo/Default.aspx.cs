using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace Envio_de_Correo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EnviarCorreo();
        }
        private static void EnviarCorreo()
        {
            String nombre = "Gustavo";
            //Configurando el cliente SMTP
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("maildepreubaayudantias@gmail.com", "aceracer123");
            
            //Enviando correo
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("maildepreubaayudantias@gmail.com");
            mail.To.Add(new MailAddress("maildepreubaayudantias@gmail.com"));
            mail.Subject = "Correo simple de HTML con documento adjunto.";
            mail.IsBodyHtml = true;
            mail.Body = "<h2>Hola! " + nombre + "</h2>Visiten: <a href='http://xamldevelopment.blogspot.com'>XAML Development</>";
            client.Send(mail);
        }
    }
}
