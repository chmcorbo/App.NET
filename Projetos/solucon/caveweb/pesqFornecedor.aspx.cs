using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CaveWeb
{
    public partial class pesqFornecedor : System.Web.UI.Page, IPaginaPesqPadrao
    {
        #region IPaginaPesqPadrao Members
        public void getDados()
        {
            String conteudo;
            Boolean primeiraLinha = false;
            SqlDataSource1.SelectCommand = "SELECT A.ID, A.RAZAO_SOCIAL FROM FORNECEDOR A ";
            if (txbRazao_social.Text != "")
            {
                conteudo = "%" + txbRazao_social.Text.ToUpper() + "%";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE (A.RAZAO_SOCIAL LIKE '" + conteudo + "')";
                primeiraLinha = true;
            }
            if (txbCNPJ.Text != "")
            {
                conteudo = txbCNPJ.Text.ToUpper() + "%";
                if (primeiraLinha)
                    SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " AND ";
                else
                    SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE ";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  (A.CNPJ LIKE '" + conteudo + "')";
            }
            SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  ORDER BY A.RAZAO_SOCIAL ";
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.ConnectionString = Sigleton.Conexao.MsSQL.Strcnx;
            getDados();
            if (!IsPostBack)
            {
                Solucon.RadControls.RadFormat.formatarGrid(RadGrid1);
            }
        }

        protected void ibtBuscar_Click(object sender, ImageClickEventArgs e)
        {
            RadGrid1.DataSourceID = "SqlDataSource1";
            RadGrid1.DataBind();
        }

        protected void ibtNovo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("cadFornecedor.aspx?id=0");
        }

        protected void ibtVoltar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("principal.aspx");
        }

        protected void RadGrid1_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {
            Solucon.RadControls.RadFormat.itemDataBound(sender, e, "cadFornecedor.aspx?id=", "ID");
        }
    }
}
