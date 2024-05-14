using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWebForm_equipo_5
{
    public partial class VentanaDetalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnComprarAhora_Click(object sender, EventArgs e)
        {
            string nombreArticulo = lblNombreArticulo.Text;
            string precio = lblPrecio.Text;
            string descripcion = lblDescripcion.Text;
            string cantidad = tbxCantidad.Text;

            Session.Add("nombreArticuloDetalle", nombreArticulo);
            Session.Add("precioDetalle", precio);
            Session.Add("descripcionDetalle", descripcion);
            Session.Add("cantidadDetalle", cantidad);

            Response.Redirect("VentanaCarrito.aspx", false);
        }

        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {

        }

        protected void btnEnviarConsulta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;
            string consulta = txtConsulta.Text;

            if (nombre != "" && email != "" && consulta != "")
            {
                //lblMensaje.Text = "Consulta enviada correctamente";
            }
            else
            {
                //lblMensaje.Text = "Por favor, complete todos los campos";
            }
        }
    }
}