using System;
using System.Web.UI;
using Cave.Dominio.Seguranca;
using Cave.DAO.Seguranca;

namespace CaveWeb
{
    public partial class alterarSenha : System.Web.UI.Page
    {
        private Usuario usuario;
        private DAOUsuario daoUsuario;

        private void getDados()
        {
            usuario = (Session["USUARIO_LOGADO"] as Usuario);
            lbLogin.Text = usuario.Login;
            lbNome.Text = usuario.Nome;
            lbPerfil.Text = usuario.perfil.Nome;
        }

        private void setDados()
        {
            usuario = (Session["USUARIO_LOGADO"] as Usuario);
            usuario.Senha = txbSenha.Text;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getDados();
                usuario.editar();
            }               

        }

        protected void ibtGravar_Click(object sender, ImageClickEventArgs e)
        {
            setDados();
            daoUsuario = new DAOUsuario();
            usuario.aplicar(daoUsuario);
            Session["USUARIO_LOGADO"] = usuario;
            Response.Redirect("principal.aspx");
        }

        protected void ibtCancelar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("principal.aspx");
        }

    }
}
