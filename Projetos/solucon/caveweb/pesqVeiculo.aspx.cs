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
    public partial class pesqVeiculo : System.Web.UI.Page, IPaginaPesqPadrao
    {
        private DAOMarca daoMarca;
        private DAOModelo daoModelo;

        #region IPaginaPesqPadrao Members
        public void getDados()
        {
            Boolean primeiraLinha = false;
            String conteudo;
            SqlDataSource1.SelectCommand = "SELECT A.ID, A.PLACA, C.DESCRICAO AS MARCA, " +
                "B.DESCRICAO AS MODELO FROM VEICULO A " +
                "LEFT OUTER JOIN MODELO B ON (B.ID=A.ID_MODELO) " +
                "LEFT OUTER JOIN MARCA C ON (C.ID=B.ID_MARCA) ";

            if (txbPlaca.Text != "")
            {
                conteudo = "%" + txbPlaca.Text.ToUpper() + "%";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE (A.PLACA LIKE '" + conteudo + "')";
                primeiraLinha = true;
            }

            if (ddMarca.SelectedValue != "0")
            {
                conteudo = ddMarca.SelectedValue;

                if (primeiraLinha)
                    SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " AND ";
                else
                    SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE ";

                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " (B.ID_MARCA = " + conteudo + ")";
                primeiraLinha = true;
            }

            if (ddModelo.SelectedValue != "0" && ddModelo.SelectedValue != "")
            {
                conteudo = ddModelo.SelectedValue;

                if (primeiraLinha)
                    SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " AND ";
                else
                    SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE ";

                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " (A.ID_MODELO = " + conteudo + ")";
            }

            SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  ORDER BY A.PLACA ";
        }
        #endregion
        
        private void carregaListaModelo()
        {
            if (ddMarca.SelectedValue != "0")
            {
                Marca marca = new Marca();
                marca.ID = int.Parse(ddMarca.SelectedValue);
                daoModelo = new DAOModelo();
                ddModelo.DataSource = daoModelo.listar(marca);
                ddModelo.DataBind();
                Solucon.WebControls.WebFormat.addItemDefault(ddModelo, new ListItem("Todos", "0", true));
                ddModelo.Enabled = true;
            }
            else
            {
                ddModelo.Items.Clear();
                ddModelo.Enabled = false;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.ConnectionString = Sigleton.Conexao.MsSQL.Strcnx;
            if (!IsPostBack)
            {
                daoMarca = new DAOMarca();
                Solucon.RadControls.RadFormat.formatarGrid(RadGrid1);
                ddMarca.DataSource = daoMarca.listar();
                ddMarca.DataBind();
                Solucon.WebControls.WebFormat.addItemDefault(ddMarca, new ListItem("Todas", "0", true));
                //***************************************
                ddModelo.Enabled = false;
            }
            getDados();
        }

        protected void ibtBuscar_Click(object sender, ImageClickEventArgs e)
        {
            RadGrid1.DataSourceID = "SqlDataSource1";
            RadGrid1.DataBind();
        }

        protected void ibtNovo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("cadVeiculo.aspx?id=0");
        }

        protected void ibtVoltar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("principal.aspx");
        }

        protected void ddMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaListaModelo();
        }

        protected void RadGrid1_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {
            Solucon.RadControls.RadFormat.itemDataBound(sender, e, "cadVeiculo.aspx?id=", "ID");
        }
    }
}
