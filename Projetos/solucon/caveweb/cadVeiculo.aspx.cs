using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.Dominio.Veiculo;
using Cave.DAO.Veiculo;

namespace CaveWeb
{
    public partial class CadVeiculo : System.Web.UI.Page, IPaginaCadPadrao
    {
        private Veiculo veiculo;
        private DAOVeiculo daoVeiculo;
        private DAOModelo daoModelo;
        private DAOMarca daoMarca;

        #region IPaginaCadPadrao Members
        public void setDados()
        {
            veiculo.Placa = txbPlaca.Text;
            veiculo.Modelo.Marca.ID = int.Parse(ddMarca.SelectedValue);
            veiculo.Modelo.ID = int.Parse(ddModelo.SelectedValue);
            veiculo.Num_chassi = txbNumChassi.Text;
            veiculo.Cod_renavam = txbCodRenavam.Text;
            veiculo.Cor = txbCor.Text;
            veiculo.Ano_fab = Convert.ToInt16((ddAnoFab.SelectedValue));
            veiculo.Ano_mod = Convert.ToInt16((ddAnoMod.SelectedValue));
            veiculo.Cidade = txbCidade.Text;
            veiculo.UF = ddUF.SelectedValue;
            veiculo.Num_portas = Convert.ToInt16(txbNumPortas.Text);
            veiculo.Litros_tanque = Convert.ToInt16(txbLitrosTanque.Text);
        }

        public void getDados()
        {
            lbID.Text = veiculo.ID.ToString();
            txbPlaca.Text = veiculo.Placa;
            if (veiculo.Modelo.ID != 0)
            {
                daoModelo = new DAOModelo();
                daoModelo.buscarID(veiculo.Modelo);
                ddMarca.SelectedValue = veiculo.Modelo.Marca.ID.ToString();
                carregaListaModelo();
                ddModelo.SelectedValue = veiculo.Modelo.ID.ToString();
            }

            txbNumChassi.Text = veiculo.Num_chassi;
            txbCodRenavam.Text = veiculo.Cod_renavam;
            txbCor.Text = veiculo.Cor;
            ddAnoFab.SelectedValue = veiculo.Ano_fab.ToString();
            ddAnoMod.SelectedValue = veiculo.Ano_mod.ToString();
            txbCidade.Text = veiculo.Cidade;
            ddUF.SelectedValue = veiculo.UF;
            txbNumPortas.Text = veiculo.Num_portas.ToString();
            txbLitrosTanque.Text = veiculo.Litros_tanque.ToString();
        }

        public void habilitarCtrl(bool ativar)
        {
            ibtAlterar.Visible = !ativar;
            ibtGravar.Visible = ativar;
            ibtExcluir.Visible = !ativar;

            txbPlaca.Enabled = ativar;
            ddMarca.Enabled = ativar;
            ddModelo.Enabled = ativar;
            txbNumChassi.Enabled = ativar;
            txbCodRenavam.Enabled = ativar;
            txbCor.Enabled = ativar;
            ddAnoFab.Enabled = ativar;
            ddAnoMod.Enabled = ativar;
            txbCidade.Enabled = ativar;
            ddUF.Enabled = ativar;
            txbNumPortas.Enabled = ativar;
            txbLitrosTanque.Enabled = ativar;
        }
        #endregion

        private void carregaListaModelo()
        {
            if (ddMarca.SelectedValue != "0")
            {
                ddModelo.Items.Clear();
                veiculo.Modelo.Marca.ID = int.Parse(ddMarca.SelectedValue);
                daoModelo = new DAOModelo();
                ddModelo.DataSource = daoModelo.listar(veiculo.Modelo.Marca);
                ddModelo.DataBind();
                /************ Item vazio *****************/
                ddModelo.Items.Add(new ListItem("Selecione","0",true));
                ddModelo.Items.FindByValue("0").Selected = true;
                ddModelo.Enabled = true;
                /*****************************************/
            }
            else
            {
                ddModelo.Items.Clear();
                ddModelo.Enabled = false;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                veiculo = new Veiculo();
                daoMarca = new DAOMarca();
                ddMarca.DataSource = daoMarca.listar();
                ddMarca.DataBind();
                /*********************** Item vazio ****************************/
                ddMarca.Items.Add(new ListItem("Selecione", "0", true));
                ddMarca.Items.FindByValue("0").Selected = true;
                /*********************** Item vazio ****************************/
                veiculo.ID = int.Parse(Request.QueryString["ID"]);
                if (veiculo.ID != 0)
                {
                    daoVeiculo = new DAOVeiculo();
                    daoVeiculo.buscarID(veiculo);
                    getDados();
                    habilitarCtrl(false);
                    veiculo.editar();
                }
                else
                    habilitarCtrl(true);

                Session["VEICULO"] = veiculo;
            }
        }

        protected void ibtAlterar_Click(object sender, ImageClickEventArgs e)
        {
            habilitarCtrl(true);
        }

        protected void ibtExcluir_Click(object sender, ImageClickEventArgs e)
        {
            veiculo = (Session["VEICULO"] as Veiculo);
            veiculo.deletar();
            try
            {
                veiculo.aplicar(new DAOVeiculo());
                Response.Redirect("pesqVeiculo.aspx");
            }
            catch (Exception Ex)
            {
                lbMsgErro.Visible = true;
                lbMsgErro.Text = Ex.Message;
            }
        }

        protected void ibtCancelar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("pesqVeiculo.aspx");
        }

        protected void ibtGravar_Click(object sender, ImageClickEventArgs e)
        {
            veiculo = (Session["VEICULO"] as Veiculo);
            setDados();
            try
            {
                veiculo.aplicar(new DAOVeiculo());
                Session["prox_pagina"] = "pesqVeiculo.aspx";
                Response.Redirect("OperacaoRealizada.aspx");
            }
            catch (Exception Ex)
            {
                lbMsgErro.Visible = true;
                lbMsgErro.Text = Ex.Message;
            }
        }

        protected void ddMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            veiculo = (Session["VEICULO"] as Veiculo);
            carregaListaModelo();
        }
    }
}
