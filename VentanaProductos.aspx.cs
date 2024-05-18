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
        public Articulo artseleccionado;
        string busqueda = null;
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
                busqueda = Request.QueryString["busqueda"];
                if (busqueda != null) filtrarArticulo(busqueda);
            }
        }
        public void cargardatos()
        {
            LecturaArticulo lecturaArticulo = new LecturaArticulo();
            listaLecturaArticulos = lecturaArticulo.listar();
        }
        public void ordenarpag(int value)
        {
            if (value == 0) { }
        }

        public void cargarddl()
        {
            DdlOrden.Items.Add("Precio ↑");
            DdlOrden.Items.Add("Orden alfabetico");
            DdlOrden.Items.Add("Precio ↓");
        }

        public void ordenarcards()
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            if (DdlOrden.SelectedValue == "Precio ↑")
            {
                listaFiltrada = listaLecturaArticulos.OrderBy(x => x.Precio).ToList();
            } //else //if(DdlOrden.SelectedValue == "Precio ↓")
            listaLecturaArticulos = new List<Articulo>(listaFiltrada);

        }

        public void modificarlista()
        {

        }

        protected void btnComprarAhora_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            foreach (var item in listaLecturaArticulos)
            {
                if (id == item.Id)
                {
                    artseleccionado=item;
                }
            }

            Session.Add("ArticulosEnCarrito", artseleccionado);

            Response.Redirect("VentanaCarrito.aspx", false);
        }
    }
}