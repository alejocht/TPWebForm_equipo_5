using System;
using System.Collections.Generic;
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

        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            
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