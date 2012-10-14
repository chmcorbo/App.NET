using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.Dominio.Seguranca;

namespace CaveWeb
{
    public partial class buscaUsuario : System.Web.UI.Page, IPaginaPesqPadrao
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.ConnectionString = Sigleton.Conexao.MsSQL.Strcnx;
            getDados();
            if (!IsPostBack)
            {
                Solucon.RadControls.RadFormat.formatarGrid(RadGrid1);
                if (Session["buscaUsuario"] == null)
                    Session.Add("buscaUsuario", new Usuario());
            }
        }

        #region IPaginaPesqPadrao Members

        public void getDados()
        {
            SqlDataSource1.SelectCommand = "SELECT A.ID, A.LOGIN, A.NOME, B.NOME AS NOME_PERFIL FROM USUARIO A "
                                  + "LEFT OUTER JOIN PERFIL_USUARIO B ON (B.ID = A.ID_PERFIL) ";
            if (txbNome.Text != "")
            {
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE (A.NOME LIKE '%" + txbNome.Text.ToUpper() + "%')";
            }
            SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  ORDER BY A.NOME ";
        }

        #endregion

        protected void ibtConsultar_Click(object sender, ImageClickEventArgs e)
        {
            RadGrid1.DataSourceID = "SqlDataSource1";
            RadGrid1.DataBind();
        }

        protected void RadGrid1_SelectedIndexChanged(object sender, EventArgs e)
        {
            (Session["buscaUsuario"] as Usuario).ID = Int32.Parse(RadGrid1.SelectedItems[0].Cells[2].Text);
            (Session["buscaUsuario"] as Usuario).Login = RadGrid1.SelectedItems[0].Cells[3].Text;
        }
    }
}
