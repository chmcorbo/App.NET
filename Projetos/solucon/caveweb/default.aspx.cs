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
using Cave.Dominio.Seguranca;
using Cave.DAO.Seguranca;

namespace CaveWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txbLogin.Focus();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            int erro = 0;
            Usuario usuario = new Usuario();
            DAOUsuario daoUsuario = new DAOUsuario();
            DAOPerfilUsuario daoPerfilUsuario = new DAOPerfilUsuario();
            usuario.Login = txbLogin.Text.ToUpper();
            usuario.Senha = txbSenha.Text;
            erro = daoUsuario.validarLogin(usuario);
            if (erro > 0)
            {
                lbMsgErro.Visible = true;

                switch (erro)
                {
                    case 1:
                        lbMsgErro.Text = "Login não informado";
                        break;
                    case 2:
                        lbMsgErro.Text = "Senha não informada";
                        break;
                    case 3:
                        lbMsgErro.Text = "Senha inválida";
                        break;
                    case 4:
                        lbMsgErro.Text = "Usuário desativado";
                        break;
                    case 5:
                        lbMsgErro.Text = "Login de usuário não encontrado";
                        break;
                }
            }
            else
            {
                daoPerfilUsuario.buscarID(usuario.perfil);
                Session["USUARIO_LOGADO"] = usuario;
                Session.Timeout = 60;
                FormsAuthentication.RedirectFromLoginPage(usuario.Login, false);
                Response.Redirect("principal.aspx");
            }
        }
    }
}

