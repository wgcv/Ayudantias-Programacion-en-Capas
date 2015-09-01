using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Control_de_usaurios
{
    public class ClaseGeneral
    {
        ConeccionDataContext db = new ConeccionDataContext();
        public GridView mostrar(GridView grv)
        {
            var consulta = from dato in db.Usuario select dato;
            grv.DataSource = consulta;
            grv.DataBind();
            return grv;

        }
        public void guardar(String nombre, String apellido, String correo, String clave)
        {
            Usuario u = new Usuario();

            u.nombre = nombre;
            u.apellido = apellido;
            u.correo = correo;
            u.clave = clave;
            u.estado = 'A';
            db.Usuario.InsertOnSubmit(u);
            db.SubmitChanges();

        }
        public GridView ConsultaNombre(GridView grv, String valor) {
            var consulta = from dato in db.Usuario where dato.nombre == valor select dato;
            grv.DataSource = consulta;
            grv.DataBind();
            return grv;

        }
        public GridView ConsultaApellido(GridView grv, String valor)
        {
            var consulta = from dato in db.Usuario where dato.apellido == valor select dato;
            grv.DataSource = consulta;
            grv.DataBind();
            return grv;

        }
        public GridView ConsultaCorreo(GridView grv, String valor)
        {
            var consulta = from dato in db.Usuario where dato.correo== valor select dato;
            grv.DataSource = consulta;
            grv.DataBind();
            return grv;

        } 
    }
}