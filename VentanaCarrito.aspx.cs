using Dominio;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Seleccionados"] != null)
            {
                List<Articulo> seleccionados = (List<Articulo>)Session["Seleccionados"];

                if (!IsPostBack)
                {
                    repCarrito.DataSource = seleccionados;
                    repCarrito.DataBind();

                    decimal SubtotalCarrito = CalcularCarritoTotal(seleccionados);
                    lblTotalCompra.Text = "Total del Carrito: $" + SubtotalCarrito.ToString("0.00");
                    lblEnvio.Text = "Costo de envío: $" + 5000.ToString("0.00"); ;
                    lblTotalCompra.Text = "Total: $" + (SubtotalCarrito + 5000).ToString("0.00");
                }
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int IDArticulo = Convert.ToInt32(btn.CommandArgument);

            List<Articulo> seleccionados;
            if (Session["Seleccionados"] != null)
            {
                seleccionados = (List<Articulo>)Session["Seleccionados"];
            }
            else
            {
                seleccionados = new List<Articulo>();
            }

            List<Articulo> nuevaLista = new List<Articulo>();
            bool eliminado = false;

            foreach (var articulo in seleccionados)
            {
                if (!eliminado && articulo.Id == IDArticulo) { eliminado = true; }
                else { nuevaLista.Add(articulo); }
            }

            Session["Seleccionados"] = nuevaLista;
            Response.Redirect(Request.RawUrl);
            repCarrito.DataSource = nuevaLista;
            repCarrito.DataBind();
        }
        protected void btnContinuarComprando_Click(object sender, EventArgs e)
        {
            Response.Redirect("VentanaPrincipal.aspx");
        }
        protected void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            Response.Redirect("VentanaCompra.aspx");
        }
        private decimal CalcularCarritoTotal(List<Articulo> articulos)
        {
            decimal total = 0;

            foreach (var articulo in articulos)
            {
                total += (decimal)articulo.Precio;
            }

            return total;
        }
    }
}