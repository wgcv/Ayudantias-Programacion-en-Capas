using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace Control_de_usaurios
{
    public partial class MaestraUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
               server control at run time. */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=usuario.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);

           

            //Aqui va el objeto a pasar a PDF
            GridView1.RenderControl(hw);

            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
               
        try
        {
            pdfDoc.Open();
          

    
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            //Imagen Derecha
            string imageURL = Server.MapPath(".") + "/Koala.jpg";
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageURL);
            //Resize image depend upon your need
            jpg.ScaleToFit(120f, 120f);
            //Give space before image
            jpg.SpacingBefore = 10f;
            //Give some space after the image
            jpg.SpacingAfter = 0f;
          //  jpg.Alignment = Element.ALIGN_LEFT;
            jpg.Alignment = Element.ALIGN_RIGHT;
            pdfDoc.Add(jpg);

          
            //Texto
            Paragraph paragraph = new Paragraph("Maestra Usuarios");
            paragraph.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(paragraph);
            paragraph = new Paragraph("\n");
            paragraph.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(paragraph);

            //Agregar Gridview
            htmlparser.Parse(sr);
            //Imagen Abajo

            imageURL = Server.MapPath(".") + "/Panda.jpg";
            jpg = iTextSharp.text.Image.GetInstance(imageURL);
            //Resize image depend upon your need
            jpg.ScaleToFit(120f, 120f);
            //Give space before image
            jpg.SpacingBefore = 0f;
            //Give some space after the image
            jpg.SpacingAfter = 0f;
            //  jpg.Alignment = Element.ALIGN_LEFT;
            jpg.Alignment = Element.ALIGN_LEFT;
            pdfDoc.Add(jpg);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
        }

          
        catch (Exception ex)
        { }
        }
    }
}