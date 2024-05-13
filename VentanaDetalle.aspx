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
                <img src="https://via.placeholder.com/300" alt="Imagen del producto" class="img-fluid">
            </div>
            <div class="col-md-6">
                <div class="container">
                    <h1>Nombre del producto</h1>
                    <h2>Precio xxxx</h2>
                </div>             
                <div class="container">
                    <p>Descripción del producto sin limites, aca se tiene que colocar un textBox</p>
                    <p>Categoría del producto</p>
                    <p>Marca del producto</p>
                    <p>Stock del producto</p>
                </div>
                <div class="container text-end">
                    <button type="button" class="btn btn-primary">Comprar ahora</button>
                    <button type="button" class="btn btn-primary">Agregar al carrito</button>
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
                        <label for="formGroupExampleInput" class="form-label">Nombre</label>
                        <input type="text" class="form-control" id="formGroupExampleInput" placeholder="Nombre">
                    </div>
                    <div class="mb-3">
                        <label for="formGroupExampleInput2" class="form-label">Email</label>
                        <input type="text" class="form-control" id="formGroupExampleInput2" placeholder="Email">
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="mb-3">
                        <label for="formGroupExampleInput" class="form-label">Consulta</label>
                        <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
                        <button type="button" class="btn btn-primary">Enviar consulta</button>
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
