using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CFuelCorboLib.dominio;
using CFuelCorboLib.dao;

namespace CFuelWeb
{
    public partial class pgAbastecimento : System.Web.UI.Page, IPaginaCadPadrao
    {
        private Abastecimento abastecimento;
        private DAOAbastecimento daoAbastecimento;
        private DAOPosto daoPosto;
        private DAOCombustivel daoCombustivel;
        private Double vdouble = 0;
        private Int32 vint = 0;
        private String arquivo = @"G:\App\VSCNET\Web\CFuelWeb\App_Data\";

        #region IPaginaCadPadrao Members

        public void setDados()
        {
            getSession();
            abastecimento.data_abastec = DateTime.Parse(txtData.Text);
            abastecimento.hora_abastec = DateTime.Parse(txtHora.Text);
            abastecimento.combustivel.ID = Int32.Parse(ddCombustivel.SelectedValue);
            
            Int32.TryParse(txtKM.Text, out vint);
            abastecimento.km = vint;
            
            Double.TryParse(txtLitragem.Text, out vdouble);
            abastecimento.litragem = vdouble;
            abastecimento.calcularKmLitro(); // Preenche o campo KM_Litro

            Double.TryParse(txtValorUnit.Text, out vdouble);
            abastecimento.valor_unit = vdouble;
            abastecimento.calcularValorTotal(); // Preenche o campo valor total;
            
            abastecimento.posto.ID = Int32.Parse(ddPosto.SelectedValue);
            abastecimento.observacao = txtObservacao.Text;
            setSession();
        }

        public void getDados()
        {
            getSession();
            txtData.Text = abastecimento.data_abastec.ToString("dd/MM/yyyy");
            txtHora.Text = abastecimento.hora_abastec.ToString("hh:mm");
            ddCombustivel.SelectedValue = abastecimento.combustivel.ID.ToString();
            txtKM.Text = abastecimento.km.ToString();
            txtLitragem.Text = abastecimento.litragem.ToString();
            txtValorUnit.Text = abastecimento.valor_unit.ToString();
            lbValor_total.Text = abastecimento.valor_total.ToString();
            ddPosto.SelectedValue = abastecimento.posto.ID.ToString();          
            txtObservacao.Text = abastecimento.observacao;
        }

        public void habilitarCtrl(bool ativar)
        {
            throw new NotImplementedException();
        }

        #endregion
        private void listaCombustivel()
        {
            daoCombustivel = new DAOCombustivel();
            ddCombustivel.DataSource = daoCombustivel.listar();
            ddCombustivel.DataBind();
        }
        private void listaPosto()
        {
            daoPosto = new DAOPosto(arquivo);
            ddPosto.DataSource = daoPosto.listar();
            ddPosto.DataBind();
        }

        private void getSession()
        {
            abastecimento = (Session["abastecimento"] as Abastecimento);
        }

        private void setSession()
        {
            Session["abastecimento"] = abastecimento;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Op I - É incluir
             * Op A - É alterar
             */

            if (!IsPostBack)
            {
                /***********************************************************/
                abastecimento = new Abastecimento();
                abastecimento.novo();
                setSession();
                /***********************************************************/
                listaCombustivel();
                ddCombustivel.Items.Add(new ListItem("Selecione", "0", true));
                ddCombustivel.Items.FindByValue("0").Selected = true;
                /***********************************************************/
                listaPosto();
                ddPosto.Items.Add(new ListItem("Selecione", "0", true));
                ddPosto.Items.FindByValue("0").Selected = true;
                /***********************************************************/
                if (Request.QueryString["op"] == "A")
                {
                    daoAbastecimento = new DAOAbastecimento(arquivo);
                    abastecimento.ID = Int32.Parse(Request.QueryString["id"]);
                    daoAbastecimento.buscarID(abastecimento);
                    getDados();
                    abastecimento.editar();
                    setSession();
                }
            }
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            setDados();
            try
            {
                abastecimento.aplicar(new DAOAbastecimento(arquivo));
                //Session["prox_pagina"] = "pesqVeiculo.aspx";
                Response.Redirect("default.aspx");
            }
            catch (Exception Ex)
            {
                lblMsgErro.Visible = true;
                lblMsgErro.Text = Ex.Message;
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            abastecimento = (Session["abastecimento"] as Abastecimento);
            abastecimento.deletar();
            try
            {
                abastecimento.aplicar(new DAOAbastecimento(arquivo));
                Response.Redirect("default.aspx");
            }
            catch (Exception Ex)
            {
                lblMsgErro.Visible = true;
                lblMsgErro.Text = Ex.Message;
            }

        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void txtLitragem_TextChanged(object sender, EventArgs e)
        {
            setDados();
            lbKmLitro.Text = abastecimento.km_litro.ToString();
        }

        protected void txtValorUnit_TextChanged(object sender, EventArgs e)
        {
            setDados();
            lbValor_total.Text = abastecimento.valor_total.ToString();
        }
    }
}
