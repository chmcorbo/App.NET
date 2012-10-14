using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.Dominio.Abastecimento;
using Cave.DAO.Abastecimento;
using Cave.DAO.RH;
using Cave.DAO.Veiculo;
using Cave.DAO.Financeiro;
using Cave.Dominio.RH;
using Cave.Dominio.Veiculo;
using Cave.Dominio.Financeiro;

namespace CaveWeb.Lancamento
{
    public partial class AbastecAvulso : System.Web.UI.Page, IPaginaCadPadrao
    {
        private Abastecimento abastecimento;
        private DAOCombustivel daoCombustivel;
        private DAOVeiculo daoVeiculo;
        private DAOMarca daoMarca;
        private DAOModelo daoModelo;
        private DAOFuncionario daoFuncionario;
        private DAOFuncao daoFuncao;
        private DAOFornecedor daoFornecedor;
        private Double saldo_funcionario;
        private Double valor_total;

        #region métodos customizados 
        public void setDados()
        {
            abastecimento.Veiculo.Placa = txbPlaca.Text;
            abastecimento.Funcionario.Matricula = txbMatricula.Text;
            abastecimento.Fornecedor.ID = Int32.Parse(txbID_Fornecedor.Text);
            abastecimento.Dt_abastec = Convert.ToDateTime(txbData.Text);
            abastecimento.Km = Convert.ToInt32(txbKM.Text);
            abastecimento.Quantidade = txbQtdeLitros.Value.Value;
            abastecimento.Preco = txbPreco.Value.Value;
            abastecimento.Tipo_Combustivel.ID = Int32.Parse(ddTipoCombustivel.SelectedValue);
            Session["abastecimento"] = abastecimento;
        }

        public void getDados()
        {
            throw new NotImplementedException();
        }

        public void habilitarCtrl(bool ativar)
        {
            throw new NotImplementedException();
        }
        public void limparCtrl()
        {
            txbPlaca.Text = "";
            txbModelo.Text = "";
            txbMarca.Text = "";
            txbMatricula.Text = "";
            txbNomeFunc.Text = "";
            txbID_Fornecedor.Text = "";
            txbRazaoSocial.Text = "";
            txbKM.Text = "0";
            txbData.Text = "";
            txbSaldo.Value = 0;
            ddTipoCombustivel.SelectedValue = "0";
            txbPreco.Value = 0;
            txbQtdeLitros.Value = 0;
            txbTotal.Value = 0;
        }

        private void getVeiculo()
        {
            abastecimento = (Session["abastecimento"] as Abastecimento);
            abastecimento.Veiculo.Placa = txbPlaca.Text;
            if (abastecimento.Veiculo.Placa != "")
            {
                daoVeiculo = new DAOVeiculo();
                daoVeiculo.buscarPlaca(abastecimento.Veiculo);
                daoModelo = new DAOModelo();
                daoModelo.buscarID(abastecimento.Veiculo.Modelo);
                daoMarca = new DAOMarca();
                daoMarca.buscarID(abastecimento.Veiculo.Modelo.Marca);
            }
            Session["abastecimento"] = abastecimento;
        }

        private void getFuncionario()
        {
            abastecimento = (Session["abastecimento"] as Abastecimento);
            abastecimento.Funcionario.Matricula = txbMatricula.Text;
            if (abastecimento.Funcionario.Matricula != "")
            {
                daoFuncionario = new DAOFuncionario();
                daoFuncionario.buscarMatricula(abastecimento.Funcionario);
                daoFuncao = new DAOFuncao();
                daoFuncao.buscarID(abastecimento.Funcionario.Funcao);
            }
            Session["abastecimento"] = abastecimento;
        }

        private void getFornecedor()
        {
            abastecimento = (Session["abastecimento"] as Abastecimento);
            abastecimento.Fornecedor.ID = Int32.Parse(txbID_Fornecedor.Text);
            if (abastecimento.Fornecedor.ID != 0)
            {
                daoFornecedor = new DAOFornecedor();
                daoFornecedor.buscarID(abastecimento.Fornecedor);
            }
            Session["abastecimento"] = abastecimento;
        }

        private void getSaldo()
        {
            if (txbData.Text.Length==10 &&
                Solucon.DataHora.DataLib.DateValid(txbData.Text))
            {
                abastecimento = (Session["abastecimento"] as Abastecimento);
                DAOAbastecimento daoAbastecimento = new DAOAbastecimento();
                saldo_funcionario=daoAbastecimento.verifSaldo(abastecimento.Funcionario, 
                    DateTime.Parse(txbData.Text).Month, DateTime.Parse(txbData.Text).Year);
            }
        }

        private void getTotal()
        {
            valor_total = txbQtdeLitros.Value.Value * txbPreco.Value.Value;
        }

        private void setVeiculo()
        {
            txbModelo.Text = abastecimento.Veiculo.Modelo.Descricao;
            txbMarca.Text = abastecimento.Veiculo.Modelo.Marca.Descricao;
        }

        private void setFuncionario()
        {
            txbNomeFunc.Text = abastecimento.Funcionario.Nome;
            txbFuncao.Text = abastecimento.Funcionario.Funcao.Nome;
            txbKM.Focus();
        }

        private void setFornecedor()
        {
            txbRazaoSocial.Text = abastecimento.Fornecedor.Razao_social;
        }

        private void setSaldo()
        {
            txbSaldo.Value = saldo_funcionario;
        }

        private void setTotal()
        {
            txbTotal.Value = valor_total;
        }
        #endregion 
        
        /******************************************************************************/

        #region eventos do webforms ou webcontrols
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                abastecimento = new Abastecimento();
                daoCombustivel = new DAOCombustivel();
                ddTipoCombustivel.DataSource = daoCombustivel.listar();
                ddTipoCombustivel.DataBind();
                ddTipoCombustivel.Items[0].Selected = false;
                /*********************** Item vazio ****************************/
                Solucon.WebControls.WebFormat.addItemDefault(ddTipoCombustivel, new ListItem("Selecione", "0", true));
                ddTipoCombustivel.Enabled = true;
                /***************************************************************/

                limparCtrl();
                Session["abastecimento"] = abastecimento;
            }
            if (Session["buscaFornec"] != null)
            {
                txbID_Fornecedor.Text = (Session["buscaFornec"] as Fornecedor).ID.ToString();
                txbID_Fornecedor_TextChanged(sender, e);
                Session.Remove("buscaFornec");
            }

            if (Session["buscaVeiculo"] != null)
            {
                txbPlaca.Text = (Session["buscaVeiculo"] as Veiculo).Placa;
                txbPlaca_TextChanged(sender, e);
                Session.Remove("buscaVeiculo");
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
            abastecimento = (Session["abastecimento"] as Abastecimento);
            setDados();
            try
            {
                abastecimento.aplicar(new DAOAbastecimento());
                Response.Redirect("lancaAbastecAvulso.aspx");

            }
            catch (Exception Ex)
            {
                lbMsgErro.Visible = true;
                lbMsgErro.Text = Ex.Message;
            }
        }

        protected void ibtCancelar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("principal.aspx");
        }

        protected void ibtLimpar_Click(object sender, ImageClickEventArgs e)
        {
            limparCtrl();
        }

        protected void txbMatricula_TextChanged(object sender, EventArgs e)
        {
            getFuncionario();
            setFuncionario();
            txbID_Fornecedor.Focus();
        }

        protected void txbID_Fornecedor_TextChanged(object sender, EventArgs e)
        {
            getFornecedor();
            setFornecedor();
            txbPlaca.Focus();
        }
        protected void txbPlaca_TextChanged(object sender, EventArgs e)
        {
            getVeiculo();
            setVeiculo();
            txbMatricula.Focus();
        }

        #endregion

        protected void txbData_TextChanged(object sender, EventArgs e)
        {
            getSaldo();
            setSaldo();
            ddTipoCombustivel.Focus();
        }

        protected void txbQtdeLitros_TextChanged(object sender, EventArgs e)
        {
            getTotal();
            setTotal();
            ibtGravar.Focus();
        }

        protected void ibtBuscarFornec_Click(object sender, ImageClickEventArgs e)
        {

        }


    }
}
