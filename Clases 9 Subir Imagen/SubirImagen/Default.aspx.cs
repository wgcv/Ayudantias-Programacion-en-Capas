using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Maestra_productos;

namespace SubirImagen
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(Server.MapPath("~/imagenes"));
                FileInfo[] fileInfo = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);

                GridView1.DataSource = fileInfo;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fullPath = Path.Combine(Server.MapPath("~/imagenes"), FileUpload1.FileName);
                FileUpload1.SaveAs(fullPath);
       
                libreria cg = new libreria();
                cg.ejecuta("INSERT INTO imagenes (path) VALUES ('"+fullPath+"');");
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}
