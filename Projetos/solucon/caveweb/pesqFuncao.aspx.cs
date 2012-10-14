using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CaveWeb
{
    public partial class pesqFuncao : System.Web.UI.Page, IPaginaPesqPadrao
    {
        #region IPaginaPesqPadrao Members

        public void getDados()
        {
            String conteudo;
            SqlDataSource1.SelectCommand = "SELECT ID, NOME FROM FUNCAO  ";

            if (txbDescricao.Text != "")
            {
                conteudo = "%" + txbDescricao.Text.ToUpper() + "%";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE (NOME LIKE '" + conteudo + "')";
            }

            SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  ORDER BY NOME ";
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
            Response.Redirect("cadFuncao.aspx?id=0");
        }

        protected void ibtVoltar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("principal.aspx");
        }

        protected void RadGrid1_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {
            Solucon.RadControls.RadFormat.itemDataBound(sender, e, "cadFuncao.aspx?id=", "ID");
        }

    }
}
