using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.DAO.RH;
using Cave.Dominio.RH; 

namespace CaveWeb
{
    public partial class cadFuncionario : System.Web.UI.Page, IPaginaCadPadrao
    {
        private Funcionario funcionario;
        private DAOFuncionario daoFuncionario;
        private DAOFuncao daoFuncao;
       
        public void setDados()
        {

            funcionario.Matricula = txtMatricula.Text;
            funcionario.Nome = txtNome.Text;
            
            if (txtDataAdmicao.Text.ToString().Length < 10)
                funcionario.Data_admissao = Solucon.DataHora.DataLib.EmptyDate();
            else
                funcionario.Data_admissao = Convert.ToDateTime(txtDataAdmicao.Text);
            
            if (txtDataDemissao.Text.ToString().Length < 10)
                funcionario.Data_demissao = Solucon.DataHora.DataLib.EmptyDate();
            else
                funcionario.Data_demissao = Convert.ToDateTime(txtDataDemissao.Text);

            funcionario.Num_CNH = txtNumCNH.Text;
            funcionario.Classe_CNH = ddClasseCNH.SelectedValue;

            if (txtVencCNH.Text.ToString().Length < 10)
                funcionario.Vencto_CNH = Solucon.DataHora.DataLib.EmptyDate();
            else
                funcionario.Vencto_CNH = Convert.ToDateTime(txtVencCNH.Text);
            
            funcionario.Funcao.ID = int.Parse(ddFuncao.SelectedValue); 
        }

        public void getDados()
        {

            txtMatricula.Text = funcionario.Matricula;
            txtNome.Text = funcionario.Nome;
            txtDataAdmicao.Text = Solucon.DataHora.DataLib.DateToText(funcionario.Data_admissao);
            txtDataDemissao.Text = Solucon.DataHora.DataLib.DateToText(funcionario.Data_demissao);
            txtNumCNH.Text = funcionario.Num_CNH;
            ddClasseCNH.SelectedValue = funcionario.Classe_CNH;
            txtVencCNH.Text = Solucon.DataHora.DataLib.DateToText(funcionario.Vencto_CNH);
            ddFuncao.SelectedValue = funcionario.Funcao.ID.ToString();
        }

        public void habilitarCtrl(bool ativar)
        {
            ibtAlterar.Visible = !ativar;
            ibtGravar.Visible = ativar;
            ibtExcluir.Visible = !ativar;

            txtMatricula.Enabled = ativar;
            txtNome.Enabled = ativar;
            txtDataAdmicao.Enabled = ativar;
            ibtCalendar1.Enabled = ativar;
            txtDataDemissao.Enabled = ativar;
            ibtCalendar2.Enabled = ativar;
            txtNumCNH.Enabled = ativar;
            ddClasseCNH.Enabled = ativar;
            ddFuncao.Enabled = ativar; 
            txtVencCNH.Enabled = ativar;
            ibtCalendar3.Enabled = ativar;
        }
        private void carregaListaFuncao()
        {
            if (ddFuncao.SelectedValue != "0")
            {
                ddFuncao.Items.Clear();
                
                daoFuncao = new DAOFuncao();
                ddFuncao.DataSource = daoFuncao.listar();
                ddFuncao.DataBind();
                /************ Item vazio *****************/
                ddFuncao.Items.Add(new ListItem("Selecione", "0", true));
                ddFuncao.Items.FindByValue("0").Selected = true;
                ddFuncao.Enabled = true;
                /*****************************************/
            }
            else
            {
                ddFuncao.Items.Clear();
                ddFuncao.Enabled = false;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                carregaListaFuncao();

                funcionario = new Funcionario();
                funcionario.ID = int.Parse(Request.QueryString["ID"]);
                if (funcionario.ID != 0)
                {
                    daoFuncionario = new DAOFuncionario();
                    daoFuncionario.buscarID(funcionario);
                    
                    getDados();
                    habilitarCtrl(false);
                    funcionario.editar();
                }
                else
                    habilitarCtrl(true);
                Session["funcionario"] = funcionario;
            }
        }

        protected void ibtAlterar_Click(object sender, ImageClickEventArgs e)
        {
            habilitarCtrl(true);
        }

        protected void ibtGravar_Click(object sender, ImageClickEventArgs e)
        {
            funcionario = (Session["funcionario"] as Funcionario);
            setDados();
            try
            {
                funcionario.aplicar(new DAOFuncionario());
                Session["prox_pagina"] = "pesqFuncionario.aspx";
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
            funcionario = (Session["funcionario"] as Funcionario);
            funcionario.deletar();
            try
            {
                funcionario.aplicar(new DAOFuncionario());
                Response.Redirect("pesqFuncionario.aspx");
            }
            catch (Exception Ex)
            {
                lbMsgErro.Visible = true;
                lbMsgErro.Text = Ex.Message;
            }
        }

        protected void ibtCancelar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("pesqFuncionario.aspx");
        }
    }
}
