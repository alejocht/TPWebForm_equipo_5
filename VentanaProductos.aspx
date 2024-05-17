<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="VentanaProductos.aspx.cs" Inherits="TPWebForm_equipo_5.VentanaProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="\css\StyleVentanaProduco.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container text-center">
        <h1>Productos</h1>
    </div>


    <div class="container d-flex justify-content-end" style="margin-right: 10px">
        <asp:DropDownList ID="DdlOrden" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DdlOrden_SelectedIndexChanged"
            aria-label="Default select example">
        </asp:DropDownList>
    </div>

    <div class="container text-center">
        <div class="row row-cols-1 row-cols-md-3 g-1 d-flex justify-content-center">
            <asp:Repeater runat="server" ID="repRepetidor">
                <ItemTemplate>
                    <div class="col d-flex justify-content-center">
                        <div class="card">
                            <img src="<%# Eval("ImagenUrl")%>" class="card-img-top" alt="Responsive image">
                            <div class="card-body">
                                <h5 class="card-title" style="color: #E7ECEF"><%#Eval("Nombre")%></h5>
                                <p class="card-text" style="color: #E7ECEF"><%#Eval("Descripcion")%></p>
                            </div>
                            <div class="card-footer">
                                <asp:Button text="Comprar ahora" CssClass="btn btn-primary" runat="server" ID="btnEjemplo" CommandArgument='<%#Eval("Id")%>' CommandName="ArticuloId" OnClick="btnEjemplo_Click"/>
                                <br />
                                <small  style="color:white">Precio: $<%#Eval("Precio")%> </small>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
