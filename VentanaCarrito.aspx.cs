using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWebForm_equipo_5
{
    public partial class VentanaCarrito : System.Web.UI.Page
    {
        public string nombreCarrito { get; set; }
        public string precioCarrito { get; set; }
        public string descripcionCarrito { get; set; }
        public string cantidadCarrito { get; set; }

        public VentanaCarrito()
        {
            nombreCarrito = "";
            precioCarrito = "";
            descripcionCarrito = "";
            cantidadCarrito = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreArticuloDetalle"].ToString() != null)
            {
                nombreCarrito = Session["nombreArticuloDetalle"].ToString();
                precioCarrito = Session["precioDetalle"].ToString();
                descripcionCarrito = Session["descripcionDetalle"].ToString();
                cantidadCarrito = Session["cantidadDetalle"].ToString();

                lblArticulo.Text = nombreCarrito;
                lblPrecio.Text = precioCarrito;
                lblDescripcion.Text = descripcionCarrito;
                tbxCantidad.Text = cantidadCarrito;
            }
            else
            {
                nombreCarrito = ""; //Cambiar luego con la base de datos
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            nombreCarrito = "";
            precioCarrito = "";
            descripcionCarrito = "";
            cantidadCarrito = "";
        }
        protected void btnContinuarComprando_Click(object sender, EventArgs e)
        {
            Response.Redirect("VentanaPrincipal.aspx");
        }
        protected void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            Response.Redirect("VentanaCompra.aspx");
        }
    }
}