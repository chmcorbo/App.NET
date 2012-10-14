using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using Telerik.Web.UI;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Cave.Dominio;
using Cave.Dominio.Seguranca;
using Cave.DAO;

namespace CaveWeb
{
    public partial class menu : System.Web.UI.UserControl
    {
        private Usuario usuarioLogado;
        private DAOOpcoes_menu_perfil daoOpcoes_menu_perfil;
        private DataSet dsOpcoesMenu;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                usuarioLogado=(Usuario)Session["USUARIO_LOGADO"];
                daoOpcoes_menu_perfil = new DAOOpcoes_menu_perfil();
                dsOpcoesMenu = daoOpcoes_menu_perfil.ListaMenuPerfilDS(usuarioLogado);
                RadMmPrincipal.DataSource = dsOpcoesMenu.Tables[0];
                RadMmPrincipal.DataTextField = "Nome";
                RadMmPrincipal.DataFieldID = "ID";
                RadMmPrincipal.DataFieldParentID = "Parent";
                RadMmPrincipal.DataNavigateUrlField = "Url";
                RadMmPrincipal.DataBind();
            }
        }

        protected void RadMmPrincipal_ItemClick(object sender, Telerik.Web.UI.RadMenuEventArgs e)
        {
        }
    }
}