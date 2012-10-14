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
using Cave.Dominio.Veiculo;
using Cave.DAO.Veiculo;

namespace CaveWeb
{
    public partial class cadModelo : System.Web.UI.Page
    {
        private Modelo modelo;
        private DAOModelo daoModelo;
        private DAOMarca daoMarca;

        private void getDados()
        {
            lbID.Text = modelo.ID.ToString();
            txbDescricao.Text = modelo.Descricao;
            ddMarca.SelectedValue = modelo.Marca.ID.ToString();
        }

        private void setDados()
        {
            modelo.Descricao = txbDescricao.Text;
            modelo.Marca.ID = int.Parse(ddMarca.SelectedValue);
        }

        private void habilitarCtrl(bool ativar)
        {
            txbDescricao.Enabled = ativar;
            ddMarca.Enabled = ativar;
            ibtAlterar.Visible = !ativar;
            ibtGravar.Visible = ativar;
            ibtExcluir.Visible = !ativar;
            if (ativar)
            {
                txbDescricao.CssClass = "textbox";
                ddMarca.CssClass = "combo_box_med";
            }
            else
            {
                txbDescricao.CssClass = "textbox_desabilitado";
                ddMarca.CssClass = "textbox_desabilitado";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                modelo = new Modelo();
                daoMarca = new DAOMarca();
                ddMarca.DataSource = daoMarca.listar();
                ddMarca.DataBind();
                modelo.ID = int.Parse(Request.QueryString["ID"]);
                if (modelo.ID != 0)
                {
                    daoModelo = new DAOModelo();
                    daoModelo.buscarID(modelo);
                    getDados();
                    habilitarCtrl(false);
                    modelo.editar();
                }
                else
                    habilitarCtrl(true);
                Session["MODELO"] = modelo;
            }
        }

        protected void ibtAlterar_Click(object sender, ImageClickEventArgs e)
        {
            habilitarCtrl(true);
        }

        protected void ibtExcluir_Click(object sender, ImageClickEventArgs e)
        {
            modelo = (Session["MODELO"] as Modelo);
            modelo.deletar();
            try
            {
                modelo.aplicar(new DAOModelo());
                Response.Redirect("pesqModelo.aspx");
            }
            catch (Exception Ex)
            {
                lbMsgErro.Visible = true;
                lbMsgErro.Text = Ex.Message;
            }

        }

        protected void ibtCancelar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("pesqModelo.aspx");
        }

        protected void ibtGravar_Click(object sender, ImageClickEventArgs e)
        {
            modelo = (Session["MODELO"] as Modelo);
            setDados();
            try
            {
                modelo.aplicar(new DAOModelo());
                Session["prox_pagina"] = "pesqModelo.aspx";
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
