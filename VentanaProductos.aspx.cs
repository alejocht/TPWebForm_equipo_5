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
        public Articulo articulosellecionado;
        string busqueda = null;
        bool cartasfiltradas;
        private void filtrarArticulo(string filtro)
        {
            List<Articulo> listaFiltrada;
            listaFiltrada = listaLecturaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            listaLecturaArticulos = listaFiltrada;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
                cargardatos();
            if (!IsPostBack)
            {
                cargarddl();
                repRepetidor.DataSource = listaLecturaArticulos;
                repRepetidor.DataBind();
            }

            busqueda = Request.QueryString["busqueda"];
            if (busqueda != null) filtrarArticulo(busqueda);
        }
        public void cargardatos()
        {
            LecturaArticulo lecturaArticulo = new LecturaArticulo();
            listaLecturaArticulos = lecturaArticulo.listar();
        }


        public void cargarddl()
        {
            DdlOrden.Items.Add("Precio ↑");
            DdlOrden.Items.Add("Orden alfabetico");
            DdlOrden.Items.Add("Precio ↓");
        }

        public void modificarlista()
        {

        }

        protected void btnEjemplo_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            
            Session.Add("ArticulosEnCarrito", id);

            Response.Redirect("VentanaCarrito.aspx", false);

        }

        protected void DdlOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            cargardatos();
            listaFiltrada = listaLecturaArticulos;

            if (DdlOrden.SelectedValue == "Precio ↑")
            {
                listaFiltrada = listaLecturaArticulos.OrderByDescending(x => x.Precio).ToList();
                listaLecturaArticulos = listaFiltrada;
                repRepetidor.DataSource = listaLecturaArticulos;
                repRepetidor.DataBind();
            }
            else if (DdlOrden.SelectedValue == "Precio ↓")
            {
                listaFiltrada = listaLecturaArticulos.OrderBy(x => x.Precio).ToList();
                listaLecturaArticulos = listaFiltrada;
                repRepetidor.DataSource = listaLecturaArticulos;
                repRepetidor.DataBind();
            }
            else
            {
                listaFiltrada = listaLecturaArticulos.OrderBy(x => x.Nombre).ToList();
                listaLecturaArticulos = listaFiltrada;
                repRepetidor.DataSource = listaLecturaArticulos;
                repRepetidor.DataBind();
            }
        }
    }
}