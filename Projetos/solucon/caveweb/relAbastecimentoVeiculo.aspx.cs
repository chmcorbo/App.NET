using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using Cave.Dominio.Veiculo;
using Cave.Dominio.Financeiro;
using Cave.Dominio.RH;
using Cave.DAO.Veiculo;
using Cave.DAO.Financeiro;
using Cave.DAO.RH;

namespace CaveWeb
{
    public partial class relAbastecimentoVeiculo : System.Web.UI.Page
    {
        private Veiculo veiculo;
        private Fornecedor fornecedor;
        private Funcionario funcionario;
        private DAOVeiculo daoVeiculo;
        private DAOMarca daoMarca;
        private DAOModelo daoModelo;
        private DAOFuncionario daoFuncionario;
        private DAOFornecedor daoFornecedor;


        #region métodos customizados
        private void getVeiculo()
        {
            veiculo = (Session["veiculo"] as Veiculo);
            veiculo.Placa = txbPlaca.Text;
            if (veiculo.Placa != "")
            {
                daoVeiculo = new DAOVeiculo();
                daoVeiculo.buscarPlaca(veiculo);
                daoModelo = new DAOModelo();
                daoModelo.buscarID(veiculo.Modelo);
                daoMarca = new DAOMarca();
                daoMarca.buscarID(veiculo.Modelo.Marca);
            }
            else
            {
                veiculo.Modelo.Descricao = "";
                veiculo.Modelo.Marca.Descricao = "";
            }

            Session["veiculo"] = veiculo;
        }

        private void getFuncionario()
        {
            funcionario = (Session["funcionario"] as Funcionario);
            funcionario.Matricula = txbMatricula.Text;
            if (funcionario.Matricula != "")
            {
                daoFuncionario = new DAOFuncionario();
                daoFuncionario.buscarMatricula(funcionario);
            }
            else
            {
                funcionario.Nome = "";
            }
            Session["funcionario"] = funcionario;
        }

        private void getFornecedor()
        {
            Int32 id = 0;
            
            fornecedor = (Session["fornec"] as Fornecedor);

            if (Int32.TryParse(txbID_Fornecedor.Text, out id))
            {
                fornecedor.ID = id;
                if (fornecedor.ID != 0)
                {
                    daoFornecedor = new DAOFornecedor();
                    daoFornecedor.buscarID(fornecedor);
                }
                else
                {
                    txbRazaoSocial.Text = "";
                }
            }
            else
            {
                txbRazaoSocial.Text = "";
            }
            Session["fornec"] = fornecedor;
        }


        private void setVeiculo()
        {
            txbModelo.Text = veiculo.Modelo.Descricao;
            txbMarca.Text = veiculo.Modelo.Marca.Descricao;
        }

        private void setFuncionario()
        {
            txbNomeFunc.Text = funcionario.Nome;
        }

        private void setFornecedor()
        {
            txbRazaoSocial.Text = fornecedor.Razao_social;
        }

        #endregion

        /******************************************************************************/

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                veiculo = new Veiculo();
                funcionario = new Funcionario();
                fornecedor = new Fornecedor();
                Session["veiculo"] = veiculo;
                Session["funcionario"] = funcionario;
                Session["fornec"] = fornecedor;
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


        protected void ibtVisualizar_Click(object sender, ImageClickEventArgs e)
        {
            Session["dtInicial"] = txbDtInicial.Text;
            Session["dtFinal"] = txbDtFinal.Text;
            Session["nome"] = txbNomeFunc.Text;
            Session["placa"] = txbPlaca.Text;
            Session["fornecedor"] = txbID_Fornecedor.Text;

            Literal1.Text = "<script type=text/javascript> window.open('AbastecimentoVeiculo.aspx') </script>";
        }

        protected void txbMatricula_TextChanged(object sender, EventArgs e)
        {
            getFuncionario();
            setFuncionario();
            txbPlaca.Focus();
        }

        protected void txbPlaca_TextChanged(object sender, EventArgs e)
        {
            getVeiculo();
            setVeiculo();
            txbID_Fornecedor.Focus();
        }

        protected void txbID_Fornecedor_TextChanged(object sender, EventArgs e)
        {
            getFornecedor();
            setFornecedor();
            txbID_Fornecedor.Focus();
        }
    }
}
