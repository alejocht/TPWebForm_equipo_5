<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="VentanaProductos.aspx.cs" Inherits="TPWebForm_equipo_5.VentanaProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="\css\StyleVentanaProduco.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container text-center">
        <h1>Productos</h1>
    </div>


    <div class="container d-flex justify-content-end" style="margin-right: 10px">
        <asp:DropDownList ID="DdlOrden" runat="server"
            aria-label="Default select example">
            
        </asp:DropDownList>
    </div>

    <div class="container text-center">
    <div class="row row-cols-1 row-cols-md-3 g-1 d-flex justify-content-center"  >
        <% foreach (Dominio.Articulo item in listaLecturaArticulos)
            {
        %>

        <div class="col d-flex justify-content-center">
            <div class="card">
                <img src="<%=item.ImagenUrl%>" class="card-img-top" alt="Responsive image">
                <div class="card-body">
                    <h5 class="card-title" style="color: #E7ECEF"><%=item.Nombre%></h5>
                    <p class="card-text" style="color: #E7ECEF"><%=item.Descripcion%></p>
                </div>
                <div class="card-footer">
                    <small class="text-body-secondary">Precio: $<%=item.Precio%> </small>
                </div>
            </div>
        </div>
        <%  } %>
        </div>
    </div>
</asp:Content>
