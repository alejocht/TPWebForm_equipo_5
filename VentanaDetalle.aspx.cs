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
            Response.Redirect("VentanaCarrito.aspx"); //Posible ventana compra?
        }
        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            //Podria solo dejar un msj flotante?
        }
        protected void btnEnviarConsulta_Click(object sender, EventArgs e)
        {
            //Tiene que se un supuesto envio de formulario
        }
    }
}