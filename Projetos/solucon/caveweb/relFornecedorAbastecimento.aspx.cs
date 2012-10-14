using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.Dominio.Financeiro;
using Cave.DAO.Veiculo;
using Cave.DAO.Financeiro;


namespace CaveWeb
{
    public partial class relFornecedorAbastecimento : System.Web.UI.Page
    {
        DAOFornecedor daoFornecedor;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["fornecedor"] = new Fornecedor();
                DAOCombustivel daoCombustivel = new DAOCombustivel();
                ddCombustivel.DataSource = daoCombustivel.listar();
            }
            if (Session["buscaFornec"] != null)
            {
                txbID_Fornecedor.Text = (Session["buscaFornec"] as Fornecedor).ID.ToString();
                txbID_Fornecedor_TextChanged(sender, e);
                Session.Remove("buscaFornec");
            }

        }
        #region métodos customizados
        private void setFornecedor()
        {
            txbRazaoSocial.Text = (Session["fornecedor"] as Fornecedor).Razao_social;
        }

        private void getFornecedor()
        {
            (Session["fornecedor"] as Fornecedor).ID = Int32.Parse(txbID_Fornecedor.Text);
            if ((Session["fornecedor"] as Fornecedor).ID != 0)
            {
                daoFornecedor = new DAOFornecedor();
                daoFornecedor.buscarID((Session["fornecedor"] as Fornecedor));
            }
            else
                txbRazaoSocial.Text = "";
        }
        #endregion

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Session["dtInicial"] = txbDtInicial.Text;
            Session["dtFinal"] = txbDtFinal.Text;
            Session["combustivel"] = ddCombustivel.SelectedValue;
            Session["fornecedor"] = txbID_Fornecedor.Text;

            Literal1.Text = "<script type=text/javascript> window.open('AbastecimentoFornecedor.aspx') </script>";
        }

        protected void txbID_Fornecedor_TextChanged(object sender, EventArgs e)
        {
            getFornecedor();
            setFornecedor();
            txbDtInicial.Focus();
        }
    }
}
