using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.Dominio.Financeiro;

namespace CaveWeb
{
    public partial class BuscarFornec : System.Web.UI.Page, IPaginaPesqPadrao
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.ConnectionString = Sigleton.Conexao.MsSQL.Strcnx;
            getDados();
            if (!IsPostBack)
            {
                Solucon.RadControls.RadFormat.formatarGrid(RadGrid1);
                if (Session["buscaFornec"] == null)
                    Session.Add("buscaFornec", new Fornecedor());
            }
        }

        #region IPaginaPesqPadrao Members

        public void getDados()
        {
            SqlDataSource1.SelectCommand = "SELECT A.ID, A.RAZAO_SOCIAL FROM FORNECEDOR A ";
            if (txbRazao_Social.Text != "")
            {
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE (A.RAZAO_SOCIAL LIKE '%" + txbRazao_Social.Text.ToUpper() + "%')";
            }
            SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  ORDER BY A.RAZAO_SOCIAL ";
        }

        #endregion

        protected void RadGrid1_SelectedIndexChanged(object sender, EventArgs e)
        {
            (Session["buscaFornec"] as Fornecedor).ID = Int32.Parse(RadGrid1.SelectedItems[0].Cells[2].Text);
            (Session["buscaFornec"] as Fornecedor).Razao_social = RadGrid1.SelectedItems[0].Cells[3].Text;
        }

        protected void ibtConsultar_Click(object sender, ImageClickEventArgs e)
        {
            RadGrid1.DataSourceID = "SqlDataSource1";
            RadGrid1.DataBind();
        }

        protected void RadGrid1_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {

        }
    }
}
