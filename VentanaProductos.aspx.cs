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
        protected void Page_Load(object sender, EventArgs e)
        {
            
            cargarddl();
            cargardatos();
            ordenarcards();
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
            if(DdlOrden.SelectedValue == "Precio ↑") {
               listaFiltrada = listaLecturaArticulos.OrderBy(x => x.Precio).ToList();
            } //else //if(DdlOrden.SelectedValue == "Precio ↓")
            listaLecturaArticulos = new List<Articulo>(listaFiltrada);
            
        }

        public void modificarlista() {
            
        }
    }
}