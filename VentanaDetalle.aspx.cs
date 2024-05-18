using Dominio;
using LecturaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWebForm_equipo_5
{
    public partial class VentanaDetalle : System.Web.UI.Page
    {
        public List<Articulo> listacarrito;
        public List<Imagen> listaImagenes;
        private Articulo seleccionado = null;
        int indiceMaximo = 0;
        int indiceActual = 0;
        public bool masImagenes = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                masImagenes = false;


                if (Session["ArticulosEnCarrito"] != null) //Revisar como es enviado el id (de VentanaProductos)
                {
                    seleccionado = (Articulo)Session["ArticulosEnCarrito"];
                    lblNombreArticulo.Text = seleccionado.Nombre;
                    lblPrecio.Text = seleccionado.Precio.ToString("F2");
                    lblDescripcion.Text = seleccionado.Descripcion;
                    lblCategoria.Text = "Categoría: " + seleccionado.Categoria.Descripcion.ToString();
                    lblMarca.Text = "Marca: " + seleccionado.Marca.Descripcion.ToString();
                    tbxCantidad.Text = 1.ToString();

                    LecturaImagen lecturaImagen = new LecturaImagen();
                    indiceMaximo = lecturaImagen.maximoImagen(seleccionado.Id);
                    cargarImagen(seleccionado.Id);
                    Session.Add("ProductoEndetalle", seleccionado);

                    Session["ArticulosEnCarrito"]=null;

                }
            }

        }

        protected void btnComprarAhora_Click(object sender, EventArgs e)
        {
            seleccionado = (Articulo)Session["ProductoEndetalle"];
                        
            Session.Add("ArticulosEnCarrito", seleccionado);

            Response.Redirect("VentanaCarrito.aspx");
        }

        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {

            Session.Add("listaArticulosEnCarrito", seleccionado);

            Response.Redirect("VentanaProductos.aspx");

            //agregar ventana de confirmacion
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

        public void cargarCarrito()
        {
            if (seleccionado != null)
            {
                Session.Add("ArticulosEnCarrito", seleccionado);
            }
        }
        private void cargarImagen(int Id)
        {
            try
            {
                LecturaImagen lecturaImagen = new LecturaImagen();
                listaImagenes = lecturaImagen.listar(Id);

                //imgUrlArticulo.ImageUrl = listaImagenes[indiceActual].ImagenUrl;
            }
            catch (Exception)
            {
                //imgUrlArticulo.ImageUrl = "https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png";
            }
        }

        protected void BtnImagenes_Click(object sender, EventArgs e)
        {
            masImagenes = true;
        }
    }
}