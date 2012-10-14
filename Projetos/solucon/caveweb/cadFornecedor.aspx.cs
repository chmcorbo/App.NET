using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.Dominio.Financeiro;
using Cave.DAO.Financeiro; 


namespace CaveWeb
{
    public partial class cadFornecedor : System.Web.UI.Page, IPaginaCadPadrao
    {
        private Fornecedor fornecedor; 
        private DAOFornecedor  daoFornecedor;


        public void habilitarCtrl(bool ativar)
        {
            txbCNPJ.Enabled = ativar;
            txbInscEstadual.Enabled = ativar;
            txbInscMunicipal.Enabled = ativar;
            txbRazaoSocial.Enabled = ativar;
            
            ibtAlterar.Visible = !ativar;
            ibtGravar.Visible = ativar;
            ibtExcluir.Visible = !ativar;
            if (ativar)
            {
                txbCNPJ.CssClass = "textbox";
                txbInscEstadual.CssClass = "textbox";
                txbInscMunicipal.CssClass = "textbox";
                txbRazaoSocial.CssClass = "textbox";
                
            }
            else
            {
                txbCNPJ.CssClass = "textbox_desabilitado";
                txbInscEstadual.CssClass = "textbox_desabilitado";
                txbInscMunicipal.CssClass = "textbox_desabilitado";
                txbRazaoSocial.CssClass = "textbox_desabilitado";
            }
        }

        public void getDados()
        {
            txbCNPJ.Text = fornecedor.Cnpj;
            txbInscMunicipal.Text = fornecedor.Insc_municipal;
            txbInscEstadual.Text = fornecedor.Insc_estadual;
            txbRazaoSocial.Text  = fornecedor.Razao_social;
            
        }

        public void setDados()
        {                          
           
            
            fornecedor.Cnpj = txbCNPJ.Text;
            fornecedor.Insc_municipal = txbInscMunicipal.Text;
            fornecedor.Insc_estadual=txbInscEstadual.Text;
            fornecedor.Razao_social= txbRazaoSocial.Text;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fornecedor = new Fornecedor();
                fornecedor.ID = int.Parse(Request.QueryString["ID"]);
                
                if (fornecedor.ID != 0)
                {
                    daoFornecedor = new DAOFornecedor();
                    daoFornecedor.buscarID(fornecedor);
                    getDados();
                    habilitarCtrl(false);
                    fornecedor.editar();
                }
                else
                    habilitarCtrl(true);

                Session["FORNECEDOR"] = fornecedor;
            }

        }

        protected void ibtAlterar_Click(object sender, ImageClickEventArgs e)
        {
            habilitarCtrl(true);
        }

        protected void ibtGravar_Click(object sender, ImageClickEventArgs e)
        {
            fornecedor = (Session["FORNECEDOR"] as Fornecedor);
            daoFornecedor = new DAOFornecedor();
            setDados();
            try
            {
                fornecedor.aplicar(daoFornecedor);
                Session["prox_pagina"] = "PesqFornecedor.aspx";
                Response.Redirect("OperacaoRealizada.aspx");
            }
            catch (Exception Ex)
            {
                lbMsgErro.Visible = true;
                lbMsgErro.Text = Ex.Message;
            }
        }

        protected void ibtCancelar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("pesqFornecedor.aspx");
        }

        protected void ibtExcluir_Click(object sender, ImageClickEventArgs e)
        {
            fornecedor = (Session["FORNECEDOR"] as Fornecedor);
            fornecedor.deletar();
            daoFornecedor = new DAOFornecedor();
            fornecedor.aplicar(daoFornecedor);
            Response.Redirect("PesqFornecedor.aspx");
        }
    }
}
