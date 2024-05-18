<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="VentanaProductos.aspx.cs" Inherits="TPWebForm_equipo_5.VentanaProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="\css\StyleVentanaProduco.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container text-center">
        <h1>Productos</h1>
    </div>


    <div class="container d-flex justify-content-end" style="margin-right: 10px"  >
        <asp:DropDownList ID="DdlOrden" runat="server" OnSelectedIndexChanged="DdlOrden_SelectedIndexChanged" AutoPostBack="true"
            aria-label="Default select example">
        </asp:DropDownList>
    </div>

    <div class="container text-center">
        <div class="row row-cols-1 row-cols-md-3 g-1 d-flex justify-content-center">
            <asp:Repeater runat="server" id="repRepetidor">
                <itemtemplate>
                    <div class="col d-flex justify-content-center">
                        <div class="card">
                            <img src="<%#Eval("ImagenUrl")%>" class="card-img-top" alt="Responsive image">
                            <div class="card-body">
                                <h5 class="card-title" style="color: #E7ECEF"><%#Eval("Nombre")%></h5>
                                <asp:button text="Detalles" runat="server" CssClass="btn btn-dark" id="Btndetalle"  CommandArgument ='<%#Eval("Id") %>' CommandName="ArticuloId" OnClick="Btndetalle_Click" />
                            </div>
                            <div class="card-footer">
                                <asp:Button Text="Comprar ahora" CssClass="btn btn-primary" runat="server"  id="btnComprarAhora" CommandArgument='<%#Eval("Id") %>' CommandName="ArticuloId" OnClick="btnComprarAhora_Click"/>
                                <br />
                                <small style="color:white">Precio: $<%#Eval("Precio")%> </small>
                            </div>
                        </div>
                    </div>
                </itemtemplate>

            </asp:Repeater>
        </div>
    </div>
</asp:Content>
