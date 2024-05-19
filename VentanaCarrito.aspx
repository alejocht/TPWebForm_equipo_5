﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="VentanaCarrito.aspx.cs" Inherits="TPWebForm_equipo_5.VentanaCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container text-center">
        <div class="container text-center">
            <h1>Carrito de Compras</h1>
        </div>

        <%  if (listaLecturaArticulos.Count() != 0)
            { %>
        <div class="container" id="containerCarrito">
            <div class="row">
                <asp:Repeater runat="server" ID="repCarrito">
                    <ItemTemplate>
                        <div>
                            <div class="container">
                                <div class="row">
                                    <div class="col-4">
                                        <img src="<%#Eval("ImagenUrl")%>" class="card-img-top" alt="Image description" onerror="this.src='https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png'">
                                    </div>
                                    <div class="col text-start p-md-5">
                                        <div class="container">
                                            <div class="row">
                                                <div class="col">
                                                    <div>
                                                        <label>Articulo: <%#Eval("Nombre")%> </label>
                                                    </div>
                                                    <div>
                                                        <label>Descripcion: <%#Eval("Descripcion")%> </label>

                                                    </div>
                                                    <div>
                                                        <label>Precio: $<%#Eval("Precio")%> </label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="container">
                                            <div class="row">
                                                <%--<div class="col-2">
                                                <p>Cantidad</p>
                                            </div>
                                            <div class="col">
                                                <asp:TextBox ID="tbxCantidad" runat="server" TextMode="Number" CssClass="form-control" placeholder="1" OnTextChanged="tbxCantidad_TextChanged" />
                                            </div>--%>
                                                <div class="col-6 text-end">
                                                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" CommandArgument='<%# Eval("Id") %>' CommandName="IdArticulo" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="container text-end">
                                            <div class="row">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <hr style="width: 90%; margin-inline: 10%;" />
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="text-start">
                <div class="container" id="containerResumenCompra">
                    <div class="row">
                        <div class="col">
                            <h4>Resumen del pedido</h4>
                            <div>
                                <asp:Label ID="lblSubTotal" runat="server" Text="Subtotal: xxxx" CssClass="p" />
                            </div>
                            <div>
                                <asp:Label ID="lblEnvio" runat="server" Text="Envio: xxxx" CssClass="p" />
                            </div>
                            <div>
                                <asp:Label ID="lblTotalCompra" runat="server" Text="Total: $xxxx" CssClass="h4" />
                            </div>

                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <asp:Button ID="btnComprar" runat="server" Text="Comprar" CssClass="btn btn-success w-75" OnClick="btnFinalizarCompra_Click" />
                        </div>
                        <div class="col">
                            <asp:Button ID="btnContinuarComprando" runat="server" Text="Continuar comprando" CssClass="btn btn-primary w-75" OnClick="btnContinuarComprando_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <%   }
            else
            { %>
        <div class="container" id="containerCarritoVacio">
            <div class="row">
                <div class="col">
                    <h3>Lista de productos</h3>
                    <p>No hay productos en el carrito de momento, no te quedes con las ganas!</p>
                    <div class="container">
                        <div class="row">
                            <div class="col">
                                <div class="container text-end">
                                    <div class="row">
                                        <div class="col">
                                            <asp:Button ID="Button2" runat="server" Text="Continuar comprando" CssClass="btn btn-primary" OnClick="btnContinuarComprando_Click" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <% }
        %>
    </div>
</asp:Content>
