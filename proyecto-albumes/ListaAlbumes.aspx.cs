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
    public partial class ListaAlbumes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AlbumNegocio negocio = new AlbumNegocio();
            Session.Add("listaAlbumes", negocio.listar());
            dgvAlbumes.DataSource = Session["listaAlbumes"];
            dgvAlbumes.DataBind();
        }

        protected void dgvAlbumes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvAlbumes.SelectedDataKey.Value.ToString();
            Response.Redirect("FormularioAlbum.aspx?id=" + id);
        }

        protected void dgvAlbumes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvAlbumes.PageIndex = e.NewPageIndex;
            dgvAlbumes.DataBind();
        }
    }
}