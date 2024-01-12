<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="proyecto_albumes.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <div class="col">
                    <div class="card">
                        <div class="card-img-top d-flex justify-content-center">
                            <img src="<%#Eval("ImagenUrl") %>" class="img-fluid" alt="<%#Eval("Nombre") %>">
                        </div>
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nombre") %></h5>
                            <p class="card-img-top">$<%#Eval("Precio") %></p>
                            <a href="DetalleAlbum.aspx?id=<%#Eval("Id") %>">Ver Detalle</a>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
