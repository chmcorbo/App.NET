using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.Dominio.Abastecimento;
using Cave.Dominio.RH;
using Cave.DAO.Abastecimento;
using Cave.DAO.RH;

namespace CaveWeb
{
    public partial class CotaExtra : System.Web.UI.Page, IPaginaCadPadrao
    {
        private Cota_extra cota_extra;
        private DAOFuncionario daoFuncionario;
        private DAOFuncao daoFuncao;

        protected void txbQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        #region IPaginaCadPadrao Members

        public void setDados()
        {
            cota_extra.Funcionario.Matricula = txbMatricula.Text;
            cota_extra.Dt_autoriz = DateTime.Parse(txbData.Text);
            cota_extra.Quantidade = Int32.Parse(txbQuantidade.Text);
            cota_extra.Justificativa = txbJustificativa.Text;
        }

        public void getDados()
        {
            throw new NotImplementedException();
        }

        public void habilitarCtrl(bool ativar)
        {
            throw new NotImplementedException();
        }

        #endregion
        public void limparCtrl()
        {
            txbMatricula.Text = "";
            txbNomeFunc.Text = "";
            txbFuncao.Text = "";
            txbData.Text="";
            txbQuantidade.Text = "0";
            txbJustificativa.Text = "";
        }
        private void getFuncionario()
        {
            cota_extra = (Session["cota_extra"] as Cota_extra);
            cota_extra.Funcionario.Matricula = txbMatricula.Text;
            if (cota_extra.Funcionario.Matricula != "")
            {
                daoFuncionario = new DAOFuncionario();
                daoFuncionario.buscarMatricula(cota_extra.Funcionario);
                daoFuncao = new DAOFuncao();
                daoFuncao.buscarID(cota_extra.Funcionario.Funcao);
            }
            Session["cota_extra"] = cota_extra;
        }
        private void setFuncionario()
        {
            txbNomeFunc.Text = cota_extra.Funcionario.Nome;
            txbFuncao.Text = cota_extra.Funcionario.Funcao.Nome;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cota_extra = new Cota_extra();
                limparCtrl();
                Session["cota_extra"] = cota_extra;
                txbMatricula.Focus();
            }
            if (Session["buscaFunc"] != null)
            {
                txbMatricula.Text = (Session["buscaFunc"] as Funcionario).Matricula;
                txbMatricula_TextChanged(sender, e);
                Session.Remove("buscaFunc");
            }
        }

        protected void ibtGravar_Click(object sender, ImageClickEventArgs e)
        {
            cota_extra = (Session["cota_extra"] as Cota_extra);
            setDados();
            try
            {
                cota_extra.aplicar(new DAOCota_extra());
                Response.Redirect("cotaExtra.aspx");

            }
            catch (Exception Ex)
            {
                lbMsgErro.Visible = true;
                lbMsgErro.Text = Ex.Message;
            }

        }

        protected void ibtLimpar_Click(object sender, ImageClickEventArgs e)
        {
            limparCtrl();
        }

        protected void txbMatricula_TextChanged(object sender, EventArgs e)
        {
            getFuncionario();
            setFuncionario();
            txbData.Focus();

        }

    
    }
}
