using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.DAO.Veiculo;

namespace CaveWeb
{
    public partial class pesqModelo : System.Web.UI.Page
    {
        private DAOMarca daoMarca;
        private void getDados()
        {
            Boolean primeiraLinha = false;
            String conteudo;
            SqlDataSource1.SelectCommand = "SELECT A.ID, A.DESCRICAO, A.ID_MARCA, B.DESCRICAO as DESC_MARCA FROM MODELO A "+
                "INNER JOIN MARCA B ON (B.ID=A.ID_MARCA) ";

            if (txbDescricao.Text != "")
            {
                conteudo = "%" + txbDescricao.Text.ToUpper() + "%";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE (A.DESCRICAO LIKE '" + conteudo + "')";
                primeiraLinha = true;
            }
            if (ddMarca.SelectedValue != "0")
            {
                conteudo = ddMarca.SelectedValue;

                if (primeiraLinha)
                    SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " AND ";
                else
                    SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " WHERE ";

                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " (A.ID_MARCA = " + conteudo + ")";
                primeiraLinha = true;
            }

            SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  ORDER BY A.DESCRICAO ";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.ConnectionString = Sigleton.Conexao.MsSQL.Strcnx;
            getDados();
            if (!IsPostBack)
            {
                daoMarca = new DAOMarca();
                Solucon.RadControls.RadFormat.formatarGrid(RadGrid1);
                ddMarca.DataSource = daoMarca.listar();
                ddMarca.DataBind();
                Solucon.WebControls.WebFormat.addItemDefault(ddMarca, new ListItem("Todas", "0", true));
            }

        }
        protected void ibtBuscar_Click(object sender, ImageClickEventArgs e)
        {
            RadGrid1.DataSourceID = "SqlDataSource1";
            RadGrid1.DataBind();
        }

        protected void ibtNovo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("cadModelo.aspx?id=0");
        }

        protected void ibtVoltar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("principal.aspx");
        }

        protected void RadGrid1_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {
            Solucon.RadControls.RadFormat.itemDataBound(sender, e, "cadModelo.aspx?id=", "ID");
        }
    }
}
