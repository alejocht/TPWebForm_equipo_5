﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="VentanaCarrito.aspx.cs" Inherits="TPWebForm_equipo_5.VentanaCarrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
            <h2>Carrito de Compras</h2>
        </div>

        <div class="container">
            <div class="row">
                <div class="col-9">
                    <h4>Lista de productos</h4>
                    <div class="container">
                        <div class="row">
                            <div class="col-4">
                                <img src="https://via.placeholder.com/200" class="img-fluid" alt="Responsive image">
                            </div>
                            <div class="col">
                                <div class="container">
                                    <div class="row">
                                        <div class="col">
                                            <h5>Nombre del producto</h5>
                                            <p>Descripcion del producto</p>
                                        </div>
                                        <div class="col-3 text-end">
                                            <p>Precio: xxxx</p>
                                        </div>
                                    </div>
                                </div>
                                <div class="container">
                                    <div class="row">
                                        <div class="col-2">
                                            <p>Cantidad</p>
                                        </div>
                                        <div class="col">
                                            <asp:TextBox ID="tbxCantidad" runat="server" TextMode="Number" CssClass="form-control" placeholder="1" />
                                        </div>
                                        <div class="col-6 text-end">
                                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
                                        </div>
                                    </div>
                                </div>
                                <div class="container text-end">
                                    <div class="row">
                                        <div class="col">
                                            <asp:Button ID="btnContinuarComprando" runat="server" Text="Continuar comprando" CssClass="btn btn-primary" OnClick="btnContinuarComprando_Click"/>
                                        </div>
                                    </div>
                                </div>
                            </div>      
                        </div>
                    </div>
                </div>
                <div class="col">
                     <h4>Resumen del pedido</h4>
                     <div class="container">
                         <div class="row">
                             <div class="col">
                                 <p>Subtotal: xxxx</p>
                                 <p>Envio: xxxx</p>
                                 <h4>Total: xxxx</h4>
                             </div>
                         </div>
                         <div class="row">
                             <asp:Button ID="btnComprar" runat="server" Text="Comprar" CssClass="btn btn-success" OnClick="btnFinalizarCompra_Click" />
                         </div>
                     </div>
                </div>
            </div>       
        </div>
</asp:Content>
