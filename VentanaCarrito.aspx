<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="VentanaCarrito.aspx.cs" Inherits="TPWebForm_equipo_5.VentanaCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height:800px">
    <div class="container">
        <h2>Carrito de Compras</h2>
    </div>

    <% if (listaLecturaArticulos.Count>0)
        { %>
    <div class="container">
        <div class="row">
            <asp:Repeater runat="server" ID="repCarrito">
                <ItemTemplate>
                    <div class="col-9">
                        <h4>Lista de productos</h4>
                        <div class="container">
                            <div class="row">
                                <div class="col-4">
                                    <img src="https://via.placeholder.com/200" ID="imgCarrito" class="img-fluid" alt="Responsive image">
                                </div>
                                <div class="col">
                                    <div class="container">
                                        <div class="row">
                                            <div class="col">
                                                <div>
                                                    <asp:Label ID="lblArticulo" runat="server" Text="Articulo" CssClass="h5" />
                                                </div>
                                                <div>
                                                    <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion" CssClass="p" />
                                                </div>
                                            </div>
                                            <div class="col-3 text-end">
                                                <asp:Label ID="lblPrecio" runat="server" Text="Precio" CssClass="p" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class="container">
                                        <div class="row">
                                            <div class="col-2">
                                                <p>Cantidad</p>
                                            </div>
                                            <div class="col">
                                                <asp:TextBox ID="tbxCantidad" runat="server" TextMode="Number" CssClass="form-control" placeholder="1" OnTextChanged="tbxCantidad_TextChanged" />
                                            </div>
                                            <div class="col-6 text-end">
                                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar"  CssClass="btn btn-danger" OnClick="btnEliminar_Click" CommandArgument='<%# Eval("Id") %>' CommandName="IdArticulo" AutoPostBack="true"/>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="container text-end">
                                        <div class="row">
                                            <div class="col">
                                                <asp:Button ID="btnContinuarComprando" runat="server" Text="Continuar comprando" CssClass="btn btn-primary" OnClick="btnContinuarComprando_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

            <div class="col">
                <h4>Resumen del pedido</h4>
                <div class="container">
                    <div class="row">
                        <div class="col">
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
                        <asp:Button ID="btnComprar" runat="server" Text="Comprar" CssClass="btn btn-success" OnClick="btnFinalizarCompra_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <% }
        else
        { %>
    <div class="container">
        <div class="row">
            <div class="col-9">
                <h4>Lista de productos</h4>
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
            <div class="col">
                <h4>Resumen del pedido</h4>
            </div>
        </div>
    </div>
    <% } %>
    </div>
</asp:Content>
