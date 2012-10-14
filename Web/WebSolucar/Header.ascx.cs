using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using cave.dominio;
using cave.DAO;

public partial class WebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            /*
             Comentado para enviar para Raphael Pilha 
            Usuario UsuarioLogado = new Usuario();
            DAOOpcoes_menu_perfil daoOpcoes_menu_perfil = new DAOOpcoes_menu_perfil();
            DataSet dsOpcoesMenu;
            UsuarioLogado=Session["USUARIO"] as Usuario;
            dsOpcoesMenu=daoOpcoes_menu_perfil.ListaMenuPerfil(UsuarioLogado);
            RadMenu1.DataSource= dsOpcoesMenu.Tables[0];
            RadMenu1.DataTextField="NOME";
            RadMenu1.DataFieldID="ID";
            RadMenu1.DataFieldParentID="PARENT";
            RadMenu1.DataNavigateUrlField="URL";
            RadMenu1.DataBind();
            */
        }
    }
    protected void RadMenu1_ItemClick(object sender, Telerik.Web.UI.RadMenuEventArgs e)
    {
        if (e.Item.Value == "Logout")
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
            //Response.Redirect("Default.aspx");
        }

    }
}
