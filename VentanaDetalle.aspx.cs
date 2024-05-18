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
        public List<Articulo> listaLecturaArticulos;
        private List<Imagen> listaImagenes;
        private Articulo seleccionado = null;
        int indiceMaximo = 0;
        int indiceActual = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ArticulosEnCarrito"] != null ) //Revisar como es enviado el id (de VentanaProductos)
            {
                //int id = 50; //Simulacion de id de articulo
                             //int id = int.Parse(Request.QueryString["id"]);

                //LecturaArticulo lecturaArticulo = new LecturaArticulo();
                //listaLecturaArticulos = lecturaArticulo.listar();
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
            }
        }

        protected void btnComprarAhora_Click(object sender, EventArgs e)
        {
            cargarCarrito();
            Response.Redirect("VentanaCarrito.aspx");
        }

        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            cargarCarrito();
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
            Session["ArticulosEnCarrito"] = Session["DetalleArticulo"];

            if (Session["ArticulosEnCarrito"] != null)
            {
                List<Articulo> ArticulosEnCarrito = (List<Articulo>)Session["ArticulosEnCarrito"];
                ArticulosEnCarrito.Add(seleccionado);
                Session["ArticulosEnCarrito"] = ArticulosEnCarrito;
            }
            else
            {
                List<Articulo> ArticulosEnCarrito = new List<Articulo>();
                ArticulosEnCarrito.Add(seleccionado);
                Session["ArticulosEnCarrito"] = ArticulosEnCarrito;
            }
        }
        private void cargarImagen(int Id)
        {
            try
            {
                LecturaImagen lecturaImagen = new LecturaImagen();
                listaImagenes = lecturaImagen.listar(Id);

                imgUrlArticulo.ImageUrl = listaImagenes[indiceActual].ImagenUrl;              
            }
            catch (Exception)
            {
                imgUrlArticulo.ImageUrl = "https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png";
            }
        }
    }
}