using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sigleton.Conexao;

namespace CaveWeb
{
    public partial class pesqFrentista : System.Web.UI.Page, IPaginaPesqPadrao
    {
        #region IPaginaPesqPadrao Members

        public void getDados()
        {
            String conteudo;
            SqlDataSource1.SelectCommand = 
                "SELECT A.ID, A.LOGIN, A.NOME, B.RAZAO_SOCIAL, C.NOME as NOME_PERFIL FROM USUARIO A "
                + "LEFT OUTER JOIN FORNECEDOR B ON (B.ID = A.ID_FORNECEDOR) "
                + "LEFT OUTER JOIN PERFIL_USUARIO C ON (C.ID = A.ID_PERFIL) "
                + "WHERE (NOT ID_FORNECEDOR IS NULL) ";

            if (txbNome.Text != "")
            {
                conteudo = "%" + txbNome.Text.ToUpper() + "%";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " and (A.NOME LIKE '" + conteudo + "')";
            }
            if (txbRazao_social.Text != "")
            {
                conteudo = "%" + txbRazao_social.Text.ToUpper() + "%";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " AND (B.RAZAO_SOCIAL LIKE '" + conteudo + "')";
            }
            SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  ORDER BY A.NOME ";
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.ConnectionString = MsSQL.Strcnx;
            getDados();
            if (!IsPostBack)
            {
                Solucon.RadControls.RadFormat.formatarGrid(RadGrid1);
            }
        }

        protected void ibtNovo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("cadFrentista.aspx?id=0");
        }

        protected void ibtBuscar_Click(object sender, ImageClickEventArgs e)
        {
            RadGrid1.DataSourceID = "SqlDataSource1";
            RadGrid1.DataBind();
        }

        protected void ibtVoltar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("principal.aspx");
        }

        protected void RadGrid1_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {
            Solucon.RadControls.RadFormat.itemDataBound(sender, e, "cadFrentista.aspx?id=", "ID");
        }

    }
}
