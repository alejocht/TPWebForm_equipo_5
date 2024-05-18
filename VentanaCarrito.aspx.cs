﻿using Dominio;
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
        public List<Articulo> listaLecturaArticulos;
        public Articulo articulo;
        public int indice = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ArticulosEnCarrito"] != null)
            {

                if (!IsPostBack)
                {
                    if (listaLecturaArticulos == null)
                    {
                        if (Session["listaArticulosEnCarrito"] != null)
                        {
                            listaLecturaArticulos = (List<Articulo>)Session["listaArticulosEnCarrito"];
                        }
                        else
                        {
                            listaLecturaArticulos = new List<Articulo>();
                        }

                    }
                    articulo = (Articulo)Session["ArticulosEnCarrito"];
                    listaLecturaArticulos.Add(articulo);
                    Session.Add("listaArticulosEnCarrito", listaLecturaArticulos);

                    repCarrito.DataSource = listaLecturaArticulos;
                    repCarrito.DataBind();

                    decimal SubtotalCarrito = CalcularCarritoTotal(listaLecturaArticulos);
                    lblSubTotal.Text = "Subtotal: $" + SubtotalCarrito.ToString("F2");

                    lblEnvio.Text = "Envío: $" + 5000.ToString("0.00"); ;
                    lblTotalCompra.Text = "Total: $" + (SubtotalCarrito + 5000).ToString("0.00");
                }
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int IdArticulo = int.Parse(((Button)sender).CommandArgument);
            listaLecturaArticulos = (List<Articulo>)Session["listaArticulosEnCarrito"];

            List<Articulo> nuevaLista = new List<Articulo>();
            bool eliminado = false;

            foreach (var articulo in listaLecturaArticulos)
            {
                if (!eliminado && articulo.Id == IdArticulo)
                {
                    eliminado = true;
                }
                else
                {
                    nuevaLista.Add(articulo);
                }
            }

            listaLecturaArticulos = nuevaLista;
            if(listaLecturaArticulos.Count < 0)
            {
                Response.Redirect("VentanaCarrito.aspx");
            }
            else {
                repCarrito.DataSource = listaLecturaArticulos;
                repCarrito.DataBind();
            }
            Session.Add("listaArticulosEnCarrito", listaLecturaArticulos);
        }
        protected void btnContinuarComprando_Click(object sender, EventArgs e)
        {
            Response.Redirect("VentanaProductos.aspx");
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