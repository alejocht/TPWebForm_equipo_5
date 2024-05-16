﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWebForm_equipo_5
{
    public partial class MiMaster : System.Web.UI.MasterPage
    {
        string busqueda;

        protected bool ValidarTextBox(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda)) {  return false; }
            else { return true; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBusqueda_Click(object sender, EventArgs e)
        {
            busqueda = txtBusqueda.Text;
            if(ValidarTextBox(busqueda))
            {
                //caso en el que tiene que iniciar la busqueda
                Response.Redirect("VentanaProductos.aspx?busqueda="+busqueda, false);
            }
            else
            {
                //caso en el que tiene que mostrar todo
                Response.Redirect("VentanaProductos.aspx", false);
            }
        }
    }
}