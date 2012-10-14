using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CaveWeb
{
    public partial class pesqFuncionario : System.Web.UI.Page, IPaginaPesqPadrao
    {
        #region IPaginaPesqPadrao Members

        public void getDados()
        {
            String conteudo;
            Boolean primeiraLinha = false;
            SqlDataSource1.SelectCommand = "SELECT A.ID, A.MATRICULA, A.NOME, B.NOME AS FUNCAO FROM FUNCIONARIO A "
                                  + "LEFT OUTER JOIN FUNCAO B ON (B.ID = A.ID_FUNCAO) ";
            if (txbMatricula.Text != "")
            {
                conteudo = txbMatricula.Text.ToUpper() + "%";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE (A.MATRICULA LIKE '" + conteudo + "')";
                primeiraLinha = true;
            }
            if (txbNome.Text != "")
            {
                conteudo = "%" + txbNome.Text.ToUpper() + "%";
                if (primeiraLinha)
                    SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " AND ";
                else
                    SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE ";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  (A.NOME LIKE '" + conteudo + "')";
            }
            SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  ORDER BY A.NOME ";
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
            Response.Redirect("cadFuncionario.aspx?id=0");
        }

        protected void ibtVoltar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("principal.aspx");
        }

        protected void RadGrid1_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {
            Solucon.RadControls.RadFormat.itemDataBound(sender, e, "cadFuncionario.aspx?id=", "ID");
        }

    }
}
