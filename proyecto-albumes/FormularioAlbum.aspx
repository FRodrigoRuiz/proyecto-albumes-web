<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="FormularioAlbum.aspx.cs" Inherits="proyecto_albumes.FormularioAlbum" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .validacion {
            color: red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id:</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre:</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
                <asp:RequiredFieldValidator CssClass="validacion" ErrorMessage="Ingrese un nombre" ControlToValidate="txtNombre" runat="server" />
            </div>
            <div class="mb-3">
                <label for="txtFechaLanzamiento" class="form-label">Fecha de Lanzamiento:</label>
                <asp:TextBox runat="server" ID="txtFechaLanzamiento" CssClass="form-control" />
                <asp:RequiredFieldValidator CssClass="validacion" ErrorMessage="Ingrese fecha de lanzamiento" ControlToValidate="txtFechaLanzamiento" runat="server" />
            </div>
            <div class="mb-3">
                <label for="ddlAutor" class="form-label">Autor:</label>
                <asp:DropDownList ID="ddlAutor" CssClass="form-control" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="ddlGenero" class="form-label">Genero:</label>
                <asp:DropDownList ID="ddlGenero" CssClass="form-control" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="txtPrecio" class="form-label">Precio:</label>
                <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control" />
                <asp:RequiredFieldValidator CssClass="validacion" ErrorMessage="Ingrese un precio" ControlToValidate="txtPrecio" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <a href="ListaAlbumes.aspx" class="btn btn-danger">Volver</a>
            </div>
        </div>

        <div class="col-6">
            <div class="mb-3">
                <label for="txtCanciones" class="form-label">Canciones:</label>
                <asp:TextBox runat="server" TextMode="MultiLine" ID="txtCanciones" CssClass="form-control" />
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <label for="txtImagenUrl" class="form-label">Url Imagen</label>
                        <asp:TextBox runat="server" ID="txtImagenUrl" CssClass="form-control"
                            AutoPostBack="true" OnTextChanged="txtImagenUrl_TextChanged" />
                        <asp:RequiredFieldValidator CssClass="validacion" ErrorMessage="Ingrese una imagen" ControlToValidate="txtImagenUrl" runat="server" />
                    </div>
                    <asp:Image ImageUrl="https://grupoact.com.ar/wp-content/uploads/2020/04/placeholder.png"
                        runat="server" ID="imgAlbum" Width="60%" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <%-- <div class="row">
        <div class="col-6">

        </div>
    </div>--%>
</asp:Content>
