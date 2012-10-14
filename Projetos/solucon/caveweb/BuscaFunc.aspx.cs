using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sigleton.Conexao;
using Cave.Dominio.RH;

namespace CaveWeb
{
    public partial class BuscaFunc : System.Web.UI.Page, IPaginaPesqPadrao
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.ConnectionString = Sigleton.Conexao.MsSQL.Strcnx;
            getDados();
            if (!IsPostBack)
            {
                Solucon.RadControls.RadFormat.formatarGrid(RadGrid1);
                if (Session["buscaFunc"] == null)
                    Session.Add("buscaFunc", new Funcionario());
            }
        }

        #region IPaginaPesqPadrao Members
        public void getDados()
        {

            SqlDataSource1.SelectCommand = "SELECT A.ID, A.MATRICULA, A.NOME, B.NOME AS NOME_FUNCAO FROM FUNCIONARIO A "
                                  + "LEFT OUTER JOIN FUNCAO B ON (B.ID = A.ID_FUNCAO) ";
            if (txbNome.Text != "")
            {
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE (A.NOME LIKE '%" + txbNome.Text + "%')";
            }
            SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  ORDER BY A.NOME ";
            txbNome.Focus();
        }

        #endregion

        protected void ibtConsultar_Click(object sender, ImageClickEventArgs e)
        {
            RadGrid1.DataSourceID = "SqlDataSource1";
            RadGrid1.DataBind();
        }

        protected void RadGrid1_SelectedIndexChanged(object sender, EventArgs e)
        {
            (Session["buscaFunc"] as Funcionario).ID = Int32.Parse(RadGrid1.SelectedItems[0].Cells[2].Text);
            (Session["buscaFunc"] as Funcionario).Matricula = RadGrid1.SelectedItems[0].Cells[3].Text;
            (Session["buscaFunc"] as Funcionario).Nome = RadGrid1.SelectedItems[0].Cells[5].Text;
        }

        protected void grdBuscaFunc_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {
            Solucon.RadControls.RadFormat.itemDataBound(sender, e);
        }
    }
}
