using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using Cave.Dominio.RH;
using Cave.DAO.Abastecimento;
using Cave.DAO.RH;

namespace CaveWeb
{
    public partial class CotaMensal : System.Web.UI.Page, IPaginaPesqPadrao
    {
        private List<Funcionario> lstfuncCotaMens;
        private Funcionario funcCota;
        private DAOCota_mensal daoCota_Mensal;
        private DAOFuncao daoFuncao;
        private DAOFuncionario daoFuncionario;

        protected void Page_Load(object sender, EventArgs e)
        {
            // SqlDataSource1.ConnectionString = Sigleton.Conexao.MsSQL.Strcnx;
            // getDados();
            if (!IsPostBack)
            {
                daoFuncao = new DAOFuncao();
                ddMes.DataSource = Solucon.DataHora.DataLib.Months(1,12);
                ddMes.DataValueField = "Num";
                ddMes.DataTextField = "Name";
                ddMes.DataBind();
                ddAno.DataSource = Solucon.DataHora.DataLib.Years(2008,2009);
                ddAno.DataBind();
                ddMes.SelectedValue = DateTime.Now.Month.ToString();
                ddAno.SelectedValue = DateTime.Now.Year.ToString();
                
                txbMatricula.Text = "";
                txbNome.Text = "";
                ddFuncao.DataSource = daoFuncao.listar();
                ddFuncao.DataBind();
                Solucon.WebControls.WebFormat.addItemDefault(ddFuncao, new ListItem("Todas", "0", true));
                Solucon.RadControls.RadFormat.formatarGrid(RadGrid1);
                lstfuncCotaMens = new List<Funcionario>();
                Session["selectFuncCotaMens"] = lstfuncCotaMens;
            }
        }

        #region IPaginaPesqPadrao Members

        public void getDados()
        {
            /*String conteudo;

            SqlDataSource1.SelectCommand = "SELECT A.ID,A.MATRICULA,A.NOME,A.ID_FUNCAO,B.NOME as NOME_FUNCAO FROM FUNCIONARIO A "
                + "LEFT OUTER JOIN FUNCAO B ON (B.ID=A.ID_FUNCAO) "
                + "WHERE A.ID NOT IN (SELECT C.ID_FUNCIONARIO FROM COTA_MENSAL C "
                + "WHERE C.ID_FUNCIONARIO=A.ID AND C.MES="+ddMes.SelectedValue+" AND C.ANO="+ddAno.SelectedValue+") " 
                + " and A.DATA_DEMISSAO IS NULL ";
        

            if (txbNome.Text != "")
            {
                conteudo = "%"+ txbNome.Text.ToUpper() + "%";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " and (A.NOME LIKE '" + conteudo + "')";

            }
            if (txbNomeFuncao.Text != "")
            {
                conteudo = "%" + txbNomeFuncao.Text.ToUpper() + "%";
                SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + " and (B.NOME LIKE '" + conteudo + "')";
            }
            SqlDataSource1.SelectCommand = SqlDataSource1.SelectCommand + "  ORDER BY A.NOME ";*/
        }

        #endregion

        #region ObjectDataSource
        public void atualizaSecao()
        {
            funcCota = new Funcionario();
            daoCota_Mensal = new DAOCota_mensal();
            funcCota.Matricula = txbMatricula.Text;
            funcCota.Nome=txbNome.Text;
            funcCota.ID=Int32.Parse(ddFuncao.SelectedValue);
            Session["lstFuncCotaMens"] = daoCota_Mensal.listFuncCota(funcCota, Int16.Parse(ddMes.SelectedValue), Int16.Parse(ddAno.SelectedValue));
            (Session["selectFuncCotaMens"] as List<Funcionario>).Clear();
        }

        public List<Funcionario> getListFuncCota()
        {
            return (Session["lstFuncCotaMens"] as List<Funcionario>);
        }

        public void excluirItemSecao(Funcionario obj)
        {
            foreach (Funcionario f in (Session["lstFuncCotaMens"] as List<Funcionario>))
            {
                if (f.ID == obj.ID)
                {
                    (Session["lstFuncCotaMens"] as List<Funcionario>).Remove(f);
                    break;
                }
            }
        }

        #endregion 

        protected void ibtBuscar_Click(object sender, ImageClickEventArgs e)
        {
            atualizaSecao();
            RadGrid1.DataSourceID = "ObjectDataSource1";
            RadGrid1.DataBind();
            ibtAdicionar.Visible = (RadGrid1.Items.Count > 0);
            ibtProximo.Visible = (RadGrid1.Items.Count > 0);
        }

        protected void ibtVoltar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("principal.aspx");
        }

        protected void ibtAdicionar_Click(object sender, ImageClickEventArgs e)
        {
            lstfuncCotaMens = (Session["selectFuncCotaMens"] as List<Funcionario>);
            bool itemSelecionado = false;
            daoFuncao = new DAOFuncao();
            daoFuncionario = new DAOFuncionario();
            foreach (GridDataItem dataItem in RadGrid1.Items)
            {
                if ((dataItem.FindControl("cbSelecao") as CheckBox).Checked)
                {
                    itemSelecionado = true;
                    funcCota = new Funcionario();
                    funcCota.ID = int.Parse(dataItem.Cells[3].Text);
                    daoFuncionario.buscarID(funcCota);
                    daoFuncao.buscarID(funcCota.Funcao);
                    lstfuncCotaMens.Add(funcCota);
                    excluirItemSecao(funcCota);
                }
            }
            if (itemSelecionado)
            {
                Session["selectFuncCotaMens"] = lstfuncCotaMens;
                RadGrid1.DataBind();
            }
            else
            {
                lbMens.Visible = true;
                lbMens.Text = "Nenhum item selecionado";
            }
        }

        protected void ibtProximo_Click(object sender, ImageClickEventArgs e)
        {
            if ((Session["selectFuncCotaMens"] as List<Funcionario>).Count == 0)
            {
                lbMens.Visible = true;
                lbMens.Text = "Nenhum item selecionado";
            }
            else
            {
                Session.Add("mes", int.Parse(ddMes.SelectedValue));
                Session.Add("ano", int.Parse(ddAno.SelectedValue));
                Session.Remove("lstFuncCotaMens");
                Response.Redirect("ConfiLstFuncCotaMensal.aspx");
            }
        }

        protected void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (GridDataItem dataItem in RadGrid1.Items)
            {
                (dataItem.FindControl("cbSelecao") as CheckBox).Checked = (sender as CheckBox).Checked;
            }
        }
    }
}
