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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnEntrar_Click(object sender, EventArgs e)
    {
        if ((tbxUsuario.Text.ToLower() == "cave") && (tbxSenha.Text.ToLower() == "cave"))
        {
            FormsAuthentication.RedirectFromLoginPage("cave", false);
        }
        else
        {
            lblErro.Visible = true;
            lblErro.Text = "Login / senha inválidos";
        }

        /*int erro;
        Usuario usuario = new Usuario();
        DAOUsuario daousuario = new DAOUsuario();
        usuario.Login = tbxUsuario.Text;
        usuario.Senha = tbxSenha.Text;
        erro = daousuario.validarLogin(usuario);
        switch (erro)
        {
            case 0:
                FormsAuthentication.RedirectFromLoginPage(usuario.Login, false);
                break;
            case 3:
                lblErro.Visible = true;
                lblErro.Text = "Senha inválida";
                break;
            case 4:
                lblErro.Visible = true;
                lblErro.Text = "Usuário desativado";
                break;
            case 5:
                lblErro.Visible = true;
                lblErro.Text = "Login não encontrado";
                break;
        }*/
    }
}
