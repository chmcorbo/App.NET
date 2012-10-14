using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.Dominio.Veiculo;

namespace CaveWeb
{
    public partial class BuscaVeiculo : System.Web.UI.Page, IPaginaPesqPadrao
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Solucon.RadControls.RadFormat.formatarGrid(RadGrid1);
            SqlDataSource1.ConnectionString = Sigleton.Conexao.MsSQL.Strcnx;
            getDados();
            if (!IsPostBack)
            {
                Solucon.RadControls.RadFormat.formatarGrid(RadGrid1);
                if (Session["buscaVeiculo"] == null)
                    Session.Add("buscaVeiculo", new Veiculo());
            }
            txbPlaca.Focus();
        }

        #region IPaginaPesqPadrao Members

        public void getDados()
        {
            SqlDataSource1.SelectCommand = "SELECT A.ID, A.PLACA, C.DESCRICAO AS MARCA, " +
                "B.DESCRICAO AS MODELO FROM VEICULO A " +
                "LEFT OUTER JOIN MODELO B ON (B.ID=A.ID_MODELO) " +
                "LEFT OUTER JOIN MARCA C ON (C.ID=B.ID_MARCA) ";
            if (txbPlaca.Text != "")
            {
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE (A.PLACA LIKE '%" + txbPlaca.Text + "%')";
            }
            SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  ORDER BY A.PLACA ";
        }

        #endregion

        protected void ibtConsultar_Click(object sender, ImageClickEventArgs e)
        {
            RadGrid1.DataSourceID = "SqlDataSource1";
            RadGrid1.DataBind();
        }

        protected void RadGrid1_SelectedIndexChanged(object sender, EventArgs e)
        {
            (Session["buscaVeiculo"] as Veiculo).ID = Int32.Parse(RadGrid1.SelectedItems[0].Cells[2].Text);
            (Session["buscaVeiculo"] as Veiculo).Placa= RadGrid1.SelectedItems[0].Cells[4].Text;
        }

        protected void RadGrid1_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {
            Solucon.RadControls.RadFormat.itemDataBound(sender, e);
        }
    }
}
