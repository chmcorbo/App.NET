using System;
using System.Web.UI;
using Cave.Dominio.Seguranca;
using Cave.DAO.Seguranca;

namespace CaveWeb
{
    public partial class cadUsuario : System.Web.UI.Page, IPaginaCadPadrao
    {
        private Usuario usuario;
        private DAOUsuario daoUsuario;
        private DAOPerfilUsuario daoPerfilUsuario = new DAOPerfilUsuario();

        #region IPaginaCadPadrao Members

        public void setDados()
        {
            usuario.Login = txbLogin.Text;
            usuario.Nome = txbNome.Text;
            if (txbSenha.Text != "")
                usuario.Senha = txbSenha.Text;
            usuario.perfil.ID = int.Parse(ddPerfil.SelectedValue);
            usuario.Ativo = ddAtivo.SelectedValue;
        }

        public void getDados()
        {
            txbLogin.Text = usuario.Login;
            txbNome.Text = usuario.Nome;
            txbSenha.Text = usuario.Senha;
            ddPerfil.SelectedValue = usuario.perfil.ID.ToString();
            ddAtivo.SelectedValue = usuario.Ativo;
        }

        public void habilitarCtrl(bool ativar)
        {
            txbLogin.Enabled = ativar;
            txbNome.Enabled = ativar;
            txbSenha.Enabled = ativar;
            txbConfSenha.Enabled = ativar;
            ddPerfil.Enabled = ativar;
            ddAtivo.Enabled = ativar;
            ibtAlterar.Visible = !ativar;
            ibtGravar.Visible = ativar;
            ibtExcluir.Visible = !ativar;
            if (ativar)
            {
                txbLogin.CssClass = "textbox";
                txbNome.CssClass = "textbox";
                txbSenha.CssClass = "textbox";
                txbConfSenha.CssClass = "textbox";
                ddPerfil.CssClass = "textbox";
                ddAtivo.CssClass = "textbox";
            }
            else
            {
                txbLogin.CssClass = "textbox_desabilitado";
                txbNome.CssClass = "textbox_desabilitado";
                txbSenha.CssClass = "textbox_desabilitado";
                txbConfSenha.CssClass = "textbox_desabilitado";
                ddPerfil.CssClass = "textbox_desabilitado";
                ddAtivo.CssClass = "textbox_desabilitado";
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            //ibtExcluir.Attributes.Add("onclick", "javascript:confirm('Tem certeza (s/n)?')");

            if (!IsPostBack)
            {
                usuario = new Usuario();
                usuario.ID=int.Parse(Request.QueryString["ID"]);
                ddPerfil.DataSource=daoPerfilUsuario.listar();
                ddPerfil.DataBind();
                if (usuario.ID!= 0)
                {
                    daoUsuario = new DAOUsuario();
                    daoUsuario.buscarID(usuario);
                    getDados();
                    habilitarCtrl(false);
                    usuario.editar();
                }
                else
                    habilitarCtrl(true);

                Session["USUARIO"] = usuario;
            }
        }

        protected void ibtGravar_Click(object sender, ImageClickEventArgs e)
        {
            usuario = (Session["USUARIO"] as Usuario);
            daoUsuario = new DAOUsuario();
            setDados();
            try
            {
                usuario.aplicar(daoUsuario);
                if (usuario.ID == ((Usuario)Session["USUARIO_LOGADO"]).ID)
                {
                    daoPerfilUsuario = new DAOPerfilUsuario();
                    daoPerfilUsuario.buscarID(usuario.perfil);
                    Session["USUARIO_LOGADO"] = usuario;
                }
                Session["prox_pagina"] = "PesqUsuario.aspx";
                Response.Redirect("OperacaoRealizada.aspx");
            }
            catch (Exception Ex)
            {
                lbMsgErro.Visible = true;
                lbMsgErro.Text = Ex.Message;
            }
        }

        protected void ibtExcluir_Click(object sender, ImageClickEventArgs e)
        {
            usuario = (Session["USUARIO"] as Usuario);
            usuario.deletar();
            daoUsuario = new DAOUsuario();
            usuario.aplicar(daoUsuario);
            Response.Redirect("PesqUsuario.aspx");
        }

        protected void ibtCancelar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("pesqUsuario.aspx");
        }

        protected void ibtAlterar_Click(object sender, ImageClickEventArgs e)
        {
            habilitarCtrl(true);
        }
    }
}
