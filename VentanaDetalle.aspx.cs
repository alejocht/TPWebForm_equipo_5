using Dominio;
using LecturaDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWebForm_equipo_5
{
    public partial class VentanaDetalle : System.Web.UI.Page
    {
        private List<Articulo> listaLecturaArticulos;
        private List<Imagen> listaImagenes;
        int indiceMaximo = 1;
        int indiceActual = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            LecturaArticulo lecturaArticulo = new LecturaArticulo();
            listaLecturaArticulos = lecturaArticulo.listar();
            LecturaImagen lecturaImagen = new LecturaImagen();
            listaImagenes = lecturaImagen.listar(listaLecturaArticulos[0].Id); //Revisar
            indiceMaximo = lecturaImagen.maximoImagen(listaLecturaArticulos[0].Id);
            Articulo seleccionado = new Articulo();

            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null) //Revisar como esw enviado el id
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    lecturaImagen.listar(id); //revisar como se envia el id
                    listaImagenes = lecturaImagen.listar(id);
                    tbxCantidad.Text = 1.ToString();
                }
                lblNombreArticulo.Text = seleccionado.Nombre;
                lblPrecio.Text = seleccionado.Precio.ToString();
                lblDescripcion.Text = seleccionado.Descripcion;
                lblCategoria.Text = seleccionado.Categoria.ToString();
                lblMarca.Text = seleccionado.Marca.ToString();
            }
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

            //Modificar para adaptar con carrito
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