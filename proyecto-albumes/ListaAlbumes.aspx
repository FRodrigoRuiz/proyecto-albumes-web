<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ListaAlbumes.aspx.cs" Inherits="proyecto_albumes.ListaAlbumes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="dgvAlbumes" runat="server" DataKeyNames="Id"
        CssClass="table" AutoGenerateColumns="false"
        OnSelectedIndexChanged="dgvAlbumes_SelectedIndexChanged"
        OnPageIndexChanging="dgvAlbumes_PageIndexChanging"
        AllowPaging="true" PageSize="5">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Fecha de creación" DataField="FechaCreacion" />
            <asp:BoundField HeaderText="Autor" DataField="Autor.Descripcion" />
            <asp:BoundField HeaderText="Genero" DataField="Genero.Descripcion" />
            <asp:BoundField HeaderText="Precio" DataField="Precio" />
            <asp:CommandField HeaderText="Accion" ShowSelectButton="true" SelectText="✍" />
        </Columns>
    </asp:GridView>

    <a href="FormularioAlbum.aspx" class="btn btn-primary">Agregar</a>

</asp:Content>
