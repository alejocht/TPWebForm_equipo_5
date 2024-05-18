<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="VentanaDetalle.aspx.cs" Inherits="TPWebForm_equipo_5.VentanaDetalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-5">
                <div id="carouselExample" class="carousel slide">
                    <div class="carousel-inner">
                        <%if (listaImagenes.Count() > 1)
                            { %>
                        <div class="carousel-item active">
                            <img src="..." class="d-block w-100" alt="Imagen">
                        </div>
                        <% foreach (var item in listaImagenes)
                            { %>
                        <div class="carousel-item">
                            <img src="<% //COLOCAR URL IMAGEN %>" class="d-block w-100" alt="...">
                        </div>
                        <% }
                            }
                            else
                            { %>
                        <div class="carousel-item active">
                            <img src="..." class="d-block w-100" alt="Imagen">
                        </div>
                        <% }
                        %>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                    </button>
                </div>
            </div>
            <div class="col-md-7">
                <div class="container">
                    <div>
                        <asp:Label ID="lblNombreArticulo" runat="server" Text="Articulo Detalle SuperMax" CssClass="h1" />
                    </div>
                    <div>
                        <asp:Label ID="lblPrecio" runat="server" Text="Precio Detalle" CssClass="h3" />
                    </div>
                </div>
                <div class="container">
                    <div>
                        <asp:Label ID="lblDescripcion" runat="server" Text="Descripción Detalle" CssClass="p" />
                    </div>
                    <div>
                        <asp:Label ID="lblCategoria" runat="server" Text="Categoría Detalle" CssClass="h5" />
                    </div>
                    <div>
                        <asp:Label ID="lblMarca" runat="server" Text="Marca Detalle" CssClass="h5" />
                    </div>
                    <div>
                        <br />
                    </div>
                    <div>
                        <p>Unidades a comprar:</p>
                    </div>
                </div>
                <div class="container text-end">
                    <div class="row">
                        <div class="col-4">
                            <asp:TextBox ID="tbxCantidad" runat="server" TextMode="Number" CssClass="form-control" placeholder="1" />
                        </div>
                        <div class="col">
                            <asp:Button ID="btnComprarAhora" runat="server" Text="Comprar ahora" CssClass="btn btn-primary" OnClick="btnComprarAhora_Click" />
                            <asp:Button ID="btnAgregarCarrito" runat="server" Text="Agregar al carrito" CssClass="btn btn-primary" OnClick="btnAgregarCarrito_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="container text-center">
            <h3>¿Requiere más información?</h3>
            <p>Complete el siguiente formulario y nos pondremos en contacto con usted en el menor tiempo posible.</p>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <div class="mb-3">
                        <h5>Formulario de contacto</h5>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre" />
                    </div>
                    <div class="mb-3">
                        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-control" placeholder="Email" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="mb-3">
                        <h5>Consulta</h5>
                        <asp:TextBox ID="txtConsulta" TextMode="MultiLine" runat="server" CssClass="form-control" placeholder="Escriba su consulta aquí" Rows="3" />
                        <div class="container text-end">
                            <asp:Button ID="btnEnviarConsulta" runat="server" Text="Enviar consulta" CssClass="btn btn-primary" OnClick="btnEnviarConsulta_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div>
        <div class="container text-center">
            <p>Política de Devoluciones y Garantías</p>
            <p>
                En el nombre de la tienda, nos comprometemos a ofrecer productos de alta calidad y a garantizar la satisfacción
                de nuestros clientes. En caso de que no estés completamente satisfecho con tu compra, te ofrecemos una política de devoluciones
                y garantías que te permite devolver o cambiar el producto de acuerdo a las condiciones establecidas en este documento.
            </p>
        </div>
    </div>

</asp:Content>
