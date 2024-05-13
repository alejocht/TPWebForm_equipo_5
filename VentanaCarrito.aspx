<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="VentanaCarrito.aspx.cs" Inherits="TPWebForm_equipo_5.VentanaCarrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
            <h2>Carrito de Compras</h2>
        </div>

        <div class="container">
            <div class="row">
                <div class="col-8">
                    <h4>Lista de productos</h4>
                    <div class="container">
                        <div class="row">
                            <div class="col-3">
                                <img src="imagenes/imagenxxx.jpg" class="img-fluid" alt="Responsive image">
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
                                        <div class="col">
                                            <p>Cantidad</p>
                                        </div>
                                        <div class="col-6">
                                            <input type="number" value="1" min="1" max="100">
                                        </div>
                                        <div class="col-3 text-end">
                                            <button type="button" class="btn btn-danger">Eliminar</button>                                           
                                        </div>
                                    </div>
                                </div>
                                <div class="container text-end">
                                    <div class="row">
                                        <div class="col">
                                            <button type="button" class="btn btn-primary">Continuar comprando</button>
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
                                <button type="button" class="btn btn-success">Comprar</button>
                            </div>
                        </div>
                </div>
            </div>       
        </div>
</asp:Content>
