using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.Dominio.Veiculo;
using Cave.DAO.Veiculo;


namespace CaveWeb
{
    public partial class relModeloAbastecimento : System.Web.UI.Page
    {
        private Veiculo veiculo;
        private DAOVeiculo daoVeiculo;
        private DAOModelo daoModelo;
        private DAOMarca daoMarca;

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
        private void setVeiculo()
        {
            txbModelo.Text = veiculo.Modelo.Descricao;
            txbMarca.Text = veiculo.Modelo.Marca.Descricao;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                veiculo = new Veiculo();
                
                Session["veiculo"] = veiculo;
                txbPlaca.Focus();
            }
            if (Session["buscaVeiculo"] != null)
            {
                txbPlaca.Text = (Session["buscaVeiculo"] as Veiculo).Placa;
                txbPlaca_TextChanged(sender, e);
                Session.Remove("buscaVeiculo");
            }
        }

        protected void ibtVisualizar_Click(object sender, ImageClickEventArgs e)
        {
            Session["dtInicial"] = txbDtInicial.Text;
            Session["dtFinal"] = txbDtFinal.Text;
            Session["placa"] = txbPlaca.Text;
            Literal1.Text = "<script type=text/javascript> window.open('AbastecimentoModelo.aspx') </script>";

        }

        protected void txbPlaca_TextChanged(object sender, EventArgs e)
        {
            getVeiculo();
            setVeiculo();
            txbDtInicial.Focus();

        }
    }
}
