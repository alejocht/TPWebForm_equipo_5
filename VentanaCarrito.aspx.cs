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
            if (Session["ArticulosEnCarrito"] != null)
            {
                List<Articulo> ArticulosEnCarrito = (List<Articulo>)Session["ArticulosEnCarrito"];

                if (!IsPostBack)
                {
                    repCarrito.DataSource = ArticulosEnCarrito;
                    repCarrito.DataBind();

                    decimal SubtotalCarrito = CalcularCarritoTotal(ArticulosEnCarrito);
                    lblSubTotal.Text = "Subtotal: $" + SubtotalCarrito.ToString("0.00");
                    lblEnvio.Text = "Envío: $" + 5000.ToString("0.00"); ;
                    lblTotalCompra.Text = "Total: $" + (SubtotalCarrito + 5000).ToString("0.00");
                }
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int IDArticulo = Convert.ToInt32(btn.CommandArgument);

            List<Articulo> ArticulosEnCarrito;
            if (Session["ArticulosEnCarrito"] != null)
            {
                ArticulosEnCarrito = (List<Articulo>)Session["ArticulosEnCarrito"];
            }
            else
            {
                ArticulosEnCarrito = new List<Articulo>();
            }

            List<Articulo> nuevaLista = new List<Articulo>();
            bool eliminado = false;

            foreach (var articulo in ArticulosEnCarrito)
            {
                if (!eliminado && articulo.Id == IDArticulo) { eliminado = true; }
                else { nuevaLista.Add(articulo); }
            }

            Session["ArticulosEnCarrito"] = nuevaLista;
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
        protected void tbxCantidad_TextChanged(object sender, EventArgs e)
        {
            //Resolver (puede que haya que agregar una propiedad nueva a articulo, con un constructor por defecto de 1)
            //Luego hacer las cuentas correspondientes en el método CalcularCarritoTotal...
        }
    }
}