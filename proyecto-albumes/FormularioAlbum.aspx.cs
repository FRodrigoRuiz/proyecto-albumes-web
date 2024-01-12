using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace proyecto_albumes
{
    public partial class FormularioAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;

            try
            {
                //Configuracion inicial de la pantalla
                if (!IsPostBack)
                {
                    AutorNegocio negocioAutor = new AutorNegocio();
                    List<Autor> listaAutor = negocioAutor.listar();

                    GeneroNegocio negocioGenero = new GeneroNegocio();
                    List<Genero> listaGenero = negocioGenero.listar();

                    ddlAutor.DataSource = listaAutor;
                    ddlAutor.DataValueField = "Id";
                    ddlAutor.DataTextField = "Descripcion";
                    ddlAutor.DataBind();

                    ddlGenero.DataSource = listaGenero;
                    ddlGenero.DataValueField = "Id";
                    ddlGenero.DataTextField = "Descripcion";
                    ddlGenero.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Validate();
                if (!Page.IsValid)
                    return;

                Album nuevo = new Album();
                AlbumNegocio negocio = new AlbumNegocio();

                nuevo.Nombre = txtNombre.Text;
                nuevo.Canciones = txtCanciones.Text;
                nuevo.FechaCreacion = int.Parse(txtFechaLanzamiento.Text);
                nuevo.ImagenUrl = txtImagenUrl.Text;
                nuevo.Precio = int.Parse(txtPrecio.Text);

                nuevo.Autor = new Autor();
                nuevo.Autor.Id = int.Parse(ddlAutor.SelectedValue);
                nuevo.Genero = new Genero();
                nuevo.Genero.Id = int.Parse(ddlGenero.SelectedValue);

                if(Request.QueryString["Id"] != null)
                {
                    nuevo.Id = int.Parse(txtId.Text);
                    negocio.modificar(nuevo);
                }
                else
                {
                    negocio.agregar(nuevo);
                }

                Response.Redirect("ListaAlbumes.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        protected void txtImagenUrl_TextChanged(object sender, EventArgs e)
        {
            imgAlbum.ImageUrl = txtImagenUrl.Text;
        }
    }
}