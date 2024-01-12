using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace proyecto_albumes
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AlbumNegocio negocio = new AlbumNegocio();
                Session.Add("listaAlbumes", negocio.listar());
                repetidor.DataSource = Session["listaAlbumes"];
                repetidor.DataBind();
            }
        }
    }
}