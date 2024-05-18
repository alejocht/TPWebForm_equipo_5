using Dominio;
using LecturaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWebForm_equipo_5
{
    public partial class VentanaProductos : System.Web.UI.Page
    {
        public List<Articulo> listaLecturaArticulos;
        public Articulo articuloseleccionado;
        string busqueda = null;
        protected void Page_Load(object sender, EventArgs e)
        {
                cargardatos();
            if (!IsPostBack)
            {
                repRepetidor.DataSource = listaLecturaArticulos;
                repRepetidor.DataBind();
                busqueda = Request.QueryString["busqueda"];
                if (busqueda != null) filtrarArticulo(busqueda);
            }
        }
        public void cargardatos()
        {
            LecturaArticulo lecturaArticulo = new LecturaArticulo();
            listaLecturaArticulos = lecturaArticulo.listar();
        }
        private void filtrarArticulo(string filtro)
        {
            
            List<Articulo> listaFiltrada;
            listaFiltrada = listaLecturaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            listaLecturaArticulos = listaFiltrada;
        }

        protected void btnComprarahora_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            foreach (var item in listaLecturaArticulos)
            {
                if (id == item.Id)
                {
                    articuloseleccionado = item;
                }
            }

            Session.Add("ArticulosEnCarrito", articuloseleccionado);

            Response.Redirect("VentanaCarrito.aspx", false);
        }

        protected void Btndetalle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            
            Session.Add("DatelleArticulo", id);

            Response.Redirect("VentanaDetalle.aspx", false);
        }
    }
}