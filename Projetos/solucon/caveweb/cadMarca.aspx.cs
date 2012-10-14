using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using Solucon.Dominio;
using Cave.Dominio.Veiculo;
using Cave.DAO.Veiculo;


namespace CaveWeb
{
    public partial class cadMarca : System.Web.UI.Page
    {
        private Marca marca;
        private DAOMarca daoMarca;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                marca = new Marca();
                marca.ID = int.Parse(Request.QueryString["ID"]);
                if (marca.ID != 0)
                {
                    daoMarca = new DAOMarca();
                    daoMarca.buscarID(marca);
                    getDados();
                    habilitarCtrl(false);
                    marca.editar();
                }
                else
                    habilitarCtrl(true);
                Session["MARCA"] = marca;
            }
        }
        private void getDados()
        {
            lbID.Text = marca.ID.ToString();
            txbDescricao.Text = marca.Descricao;
        }

        private void setDados()
        {
            marca.Descricao = txbDescricao.Text;
        }

        private void habilitarCtrl(bool ativar)
        {
            txbDescricao.Enabled = ativar;
            ibtAlterar.Visible = !ativar;
            ibtGravar.Visible = ativar;
            ibtExcluir.Visible = !ativar;
            if (ativar)
                txbDescricao.CssClass = "textbox";
            else
                txbDescricao.CssClass = "textbox_desabilitado";

        }

        protected void ibtAlterar_Click(object sender, ImageClickEventArgs e)
        {
            habilitarCtrl(true);
        }

        protected void ibtExcluir_Click(object sender, ImageClickEventArgs e)
        {
            marca = (Session["MARCA"] as Marca);
            marca.deletar();
            try
            {
                marca.aplicar(new DAOMarca());
                Response.Redirect("pesqMarca.aspx");
            }
            catch (Exception Ex)
            {
                lbMsgErro.Visible = true;
                lbMsgErro.Text = Ex.Message;
            }
        }

        protected void ibtCancelar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("pesqMarca.aspx");
        }

        protected void ibtGravar_Click(object sender, ImageClickEventArgs e)
        {
            marca = (Session["MARCA"] as Marca);
            setDados();
            try
            {
                marca.aplicar(new DAOMarca());
                Session["prox_pagina"] = "pesqMarca.aspx";
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
