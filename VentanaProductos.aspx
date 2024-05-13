<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="VentanaProductos.aspx.cs" Inherits="TPWebForm_equipo_5.VentanaProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Productos</h2>
    </div>

    <div class="row row-cols-1 row-cols-md-3 g-4">
        <% foreach (Dominio.Articulo item in listaLecturaArticulos)
            { 
        %>
        <div class="col">
            <div class="card" style="background-color: #6096BA">
                <img src="<%=item.ImagenUrl%>" class="card-img-top" style="background-color: #A3CEF1" alt="Responsive image">
                <div class="card-body">
                    <h5 class="card-title" style="color: #E7ECEF"><%=item.Nombre%></h5>
                    <p class="card-text" style="color: #E7ECEF"><%=item.Descripcion%></p>
                </div>
                <div class="card-footer">
                    <small class="text-body-secondary" >Precio: $<%=item.Precio%> </small>
                </div>
            </div>
        </div>
        <%  } %>
    </div>
</asp:Content>
