using System;
using System.Web.UI;
using Sigleton.Conexao;

namespace CaveWeb{

    public partial class PesqUsuario : System.Web.UI.Page, IPaginaPesqPadrao
    {
        #region IPaginaPesqPadrao Members
        public void getDados()
        {
            String conteudo;
            Boolean primeiraLinha = false;
            SqlDataSource1.SelectCommand = "SELECT A.ID, A.LOGIN, A.NOME, B.NOME AS NOME_PERFIL FROM USUARIO A "
                                  + "LEFT OUTER JOIN PERFIL_USUARIO B ON (B.ID = A.ID_PERFIL) ";
            if (txbNome.Text != "")
            {
                conteudo = "%" + txbNome.Text.ToUpper() + "%";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE (A.NOME LIKE '" + conteudo + "')";
                primeiraLinha = true;
            }
            if (txbLogin.Text != "")
            {
                conteudo = "%" + txbLogin.Text.ToUpper() + "%";
                if (primeiraLinha)
                    SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " AND ";
                else
                    SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE ";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  (A.LOGIN LIKE '" + conteudo + "')";
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
            Response.Redirect("cadUsuario.aspx?id=0");
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
            Solucon.RadControls.RadFormat.itemDataBound(sender, e, "cadUsuario.aspx?id=", "ID");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
