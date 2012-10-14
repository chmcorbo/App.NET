using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sigleton.Conexao;

namespace CaveWeb
{
    public partial class pesqMarca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.ConnectionString = MsSQL.Strcnx;
            getDados();
            if (!IsPostBack)
            {
                Solucon.RadControls.RadFormat.formatarGrid(RadGrid1);
            }
        }
        private void getDados()
        {
            String conteudo;
            SqlDataSource1.SelectCommand = "SELECT ID, DESCRICAO FROM MARCA  ";

            if (txbDescricao.Text != "")
            {
                conteudo = "%" + txbDescricao.Text.ToUpper() + "%";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE (DESCRICAO LIKE '" + conteudo + "')";
            }

            SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  ORDER BY DESCRICAO ";
        }

        protected void ibtNovo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("cadMarca.aspx?id=0");
        }

        protected void ibtVoltar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("principal.aspx");
        }

        protected void ibtBuscar_Click(object sender, ImageClickEventArgs e)
        {
            RadGrid1.DataSourceID = "SqlDataSource1";
            RadGrid1.DataBind();
        }

        protected void RadGrid1_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {
            Solucon.RadControls.RadFormat.itemDataBound(sender, e, "cadMarca.aspx?id=", "ID");
        }

    }
}
