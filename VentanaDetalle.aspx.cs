using Dominio;
using LecturaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if (Session["ArticulosEnCarrito"] != null ) //Revisar como es enviado el id (de VentanaProductos)
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
            if (seleccionado!=null)
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
        public void PopulateCarousel(List<string> imagePaths, Carousel carouselControl)
        {
            if (imagePaths == null || imagePaths.Count == 0)
            {
                // Handle empty list gracefully (e.g., display a message or default image)
                return;
            }

            carouselControl.Controls.Clear(); // Ensure clean slate before population

            StringBuilder carouselItemsHtml = new StringBuilder();

            for (int i = 0; i < imagePaths.Count; i++)
            {
                string imagePath = listaImagenes[indiceActual].ImagenUrl;
                string activeClass = i == 0 ? "active" : ""; // Set active class for first image

                carouselItemsHtml.AppendFormat(
                    @"<div class=""carousel-item {0}"">
                <img src=""{1}"" class=""d-block w-100"" alt=""..."">
            </div>",
                    activeClass,
                    imagePath);
            }

            carouselControl.InnerHtml = carouselItemsHtml.ToString();

            // Optionally, initialize carousel behavior after population
            // (Consider using a separate method for initialization)
            // carouselControl.Initialize(); // Replace with your initialization logic
        }

        protected void BtnImagenes_Click(object sender, EventArgs e)
        {
            masImagenes = true;
        }
    }
}