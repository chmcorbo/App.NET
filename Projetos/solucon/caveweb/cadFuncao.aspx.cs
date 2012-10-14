using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using Solucon.Dominio;
using Cave.Dominio.RH;
using Cave.DAO.RH;

namespace CaveWeb
{
    public partial class cadFuncao : System.Web.UI.Page
    {
        private Funcao funcao;
        private DAOFuncao daoFuncao;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                funcao = new Funcao();
                funcao.ID = int.Parse(Request.QueryString["ID"]);
                if (funcao.ID != 0)
                {
                    daoFuncao = new DAOFuncao();
                    daoFuncao.buscarID(funcao);
                    getDados();
                    habilitarCtrl(false);
                    funcao.editar();
                }
                else
                    habilitarCtrl(true);
                Session["FUNCAO"] = funcao;
            }
        }
        private void getDados()
        {
            lbID.Text = funcao.ID.ToString();
            txbNome.Text = funcao.Nome;
        }

        private void setDados()
        {
            funcao.Nome = txbNome.Text;
        }

        private void habilitarCtrl(bool ativar)
        {
            txbNome.Enabled = ativar;
            ibtAlterar.Visible = !ativar;
            ibtGravar.Visible = ativar;
            ibtExcluir.Visible = !ativar;
            if (ativar)
                txbNome.CssClass = "textbox";
            else
                txbNome.CssClass = "textbox_desabilitado";
        }

        protected void ibtAlterar_Click(object sender, ImageClickEventArgs e)
        {
            habilitarCtrl(true);
        }
        protected void ibtExcluir_Click(object sender, ImageClickEventArgs e)
        {
            funcao = (Session["FUNCAO"] as Funcao);
            funcao.deletar();
            try
            {
                funcao.aplicar(new DAOFuncao());
                Response.Redirect("pesqFuncao.aspx");
            }
            catch (Exception Ex)
            {
                lbMsgErro.Visible = true;
                lbMsgErro.Text = Ex.Message;
            }
        }

        protected void ibtCancelar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("pesqFuncao.aspx");
        }

        protected void ibtGravar_Click(object sender, ImageClickEventArgs e)
        {
            funcao = (Session["FUNCAO"] as Funcao);
            setDados();
            try
            {
                funcao.aplicar(new DAOFuncao());
                Session["prox_pagina"] = "pesqFuncao.aspx";
                Response.Redirect("OperacaoRealizada.aspx");
            }
            catch (Exception Ex)
            {
                lbMsgErro.Visible = true;
                lbMsgErro.Text = Ex.Message;
            }
        }
    }
}