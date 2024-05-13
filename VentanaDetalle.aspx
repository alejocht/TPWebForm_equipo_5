<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="VentanaDetalle.aspx.cs" Inherits="TPWebForm_equipo_5.VentanaDetalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <p>Filtros varios</p>
    </div>

    <div class="container">
         <div class="row">
             <div class="col-md-5">
                 <br/>
                <img src="https://via.placeholder.com/400" alt="Imagen del producto" class="img-fluid">
            </div>
            <div class="col-md-7">
                <div class="container">
                    <h1>Nombre del producto</h1>
                    <h2>Precio xxxx</h2>
                </div>             
                <div class="container">
                    <p>Descripción del producto sin limites, aca se tiene que colocar un textBox</p>
                    <p>Categoría del producto</p>
                    <p>Marca del producto</p>
                    <p>Stock del producto</p>
                    <p>Cantidad</p>
                </div>
                <div class="container text-end">                
                    <div class="row">
                        <div class="col-3">
                        <asp:TextBox ID="tbxCantidad" runat="server" TextMode="Number" CssClass="form-control" placeholder="1" />                        </div>
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
                        <asp:TextBox ID="txtConsulta" TextMode="MultiLine" runat="server" CssClass="form-control" rows="3" />
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
