using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.Dominio.Financeiro;
using Cave.Dominio.Seguranca;
using Cave.DAO.Financeiro;
using Cave.DAO.Seguranca;

namespace CaveWeb
{
    public partial class associaFrentista : System.Web.UI.Page, IPaginaCadPadrao
    {
        private Frentista frentista;
        private DAOFornecedor daoFornecedor;
        private DAOFrentista daoFrentista;

        #region Métodos Customizados
        private void atualizaEstadoFrentista(Frentista obj)
        {
            if (Int32.Parse(Request.QueryString["ID"]) == 0)
                obj.novo();
            else
                obj.editar();
        }

        private void getUsuario()
        {
            frentista = (Session["frentista"] as Frentista);
            frentista.Login = txbUsuario.Text;
            if (frentista.Login != "")
            {
                daoFrentista = new DAOFrentista();
                daoFrentista.buscarLogin(frentista);
                atualizaEstadoFrentista(frentista);
            }
            Session["frentista"] = frentista;
        }
        
        private void getFornecedor()
        {
            frentista = (Session["frentista"] as Frentista);
            frentista.Fornecedor.ID = Int32.Parse(txbId_fornecedor.Text);
            if (frentista.Fornecedor.ID != 0)
            {
                daoFornecedor = new DAOFornecedor();
                daoFornecedor.buscarID(frentista.Fornecedor);
            }
            Session["frentista"] = frentista;
        }

        private void setFornecedor()
        {
            txbRazaoSocial.Text = frentista.Fornecedor.Razao_social;
        }
        private void setUsuairo()
        {
            txbNomeUsuario.Text = frentista.Nome;
        }
        #endregion

        #region IPaginaCadPadrao Members

        public void setDados()
        {
            frentista.Login = txbUsuario.Text;
            frentista.Nome = txbNomeUsuario.Text;
            frentista.Fornecedor.ID = Int32.Parse(txbId_fornecedor.Text);
        }

        public void getDados()
        {
            daoFrentista = new DAOFrentista();
            daoFornecedor = new DAOFornecedor();
            txbUsuario.Text = frentista.Login;
            daoFrentista.buscarFrentista(frentista);
            txbNomeUsuario.Text = frentista.Nome;

            txbId_fornecedor.Text = frentista.Fornecedor.ID.ToString();
            daoFornecedor.buscarID(frentista.Fornecedor);
            txbRazaoSocial.Text = frentista.Fornecedor.Razao_social;
        }

        public void habilitarCtrl(bool ativar)
        {
            if (frentista==null)
                frentista = (Session["frentista"] as Frentista);

            ibtAlterar.Visible = !ativar;
            ibtGravar.Visible = ativar;
            ibtExcluir.Visible = !ativar;
            txbId_fornecedor.Enabled = ativar;
            btnBuscarFornec.Visible = ativar;

            if (ativar && frentista.Estado == Solucon.State.Stateobj.stNovo)
            {
                txbUsuario.Enabled = ativar;
                btnBuscarUsuario.Visible = ativar;
            }
            else
            {
                txbUsuario.Enabled = false;
                btnBuscarUsuario.Visible = false;
            }

            if (txbUsuario.Enabled)
                txbUsuario.CssClass = "input_peq";
            else
                txbUsuario.CssClass = "textbox_desabilitado";

            if (txbId_fornecedor.Enabled)
                txbId_fornecedor.CssClass = "input_peq";
            else
                txbId_fornecedor.CssClass = "textbox_desabilitado";
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                frentista = new Frentista();
                frentista.ID = Int32.Parse(Request.QueryString["ID"]);
                Session["frentista"] = frentista;
                if (frentista.ID != 0)
                {
                    daoFrentista = new DAOFrentista();
                    daoFrentista.buscarID(frentista);
                    getDados();
                    habilitarCtrl(false);
                    frentista.editar();
                }
                else
                {
                    frentista.novo();
                    habilitarCtrl(true);
                }
            }

            if (Session["buscaFornec"] != null)
            {
                txbId_fornecedor.Text = (Session["buscaFornec"] as Fornecedor).ID.ToString();
                txbId_fornecedor_TextChanged(sender, e);
                Session.Remove("buscaFornec");
            }

            if (Session["buscaUsuario"] != null)
            {
                txbUsuario.Text = (Session["buscaUsuario"] as Usuario).Login;
                txbUsuario_TextChanged(sender, e);
                Session.Remove("buscaUsuario");
            }
        }

        protected void ibtExcluir_Click(object sender, ImageClickEventArgs e)
        {
            frentista = (Session["frentista"] as Frentista);
            frentista.deletar();
            daoFrentista = new DAOFrentista();
            frentista.aplicar(daoFrentista);
            Response.Redirect("PesqFrentista.aspx");
        }

        protected void ibtVoltar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("pesqFrentista.aspx");
        }

        protected void ibtGravar_Click(object sender, ImageClickEventArgs e)
        {
            frentista = (Session["frentista"] as Frentista);
            setDados();
            try
            {
                frentista.aplicar(new DAOFrentista());
                Session["prox_pagina"] = "PesqFrentista.aspx";
                Response.Redirect("OperacaoRealizada.aspx");
            }
            catch (Exception Ex)
            {
                lbMsgErro.Visible = true;
                lbMsgErro.Text = Ex.Message;
            }
        }

        protected void txbId_fornecedor_TextChanged(object sender, EventArgs e)
        {
            getFornecedor();
            setFornecedor();
        }

        protected void txbUsuario_TextChanged(object sender, EventArgs e)
        {
            getUsuario();
            setUsuairo();
            txbId_fornecedor.Focus();
        }

        protected void ibtAlterar_Click(object sender, ImageClickEventArgs e)
        {
            habilitarCtrl(true);
        }

        protected void ibtCancelar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("pesqFrentista.aspx");
        }
    }
}
