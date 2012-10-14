using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.Dominio.RH;
using Cave.Dominio.Abastecimento;
using Cave.DAO.Abastecimento;

namespace CaveWeb
{
    public partial class ConfiLstFuncCotaMensal : System.Web.UI.Page
    {
        public List<Funcionario> getFuncCotaMens()
        {
            return (Session["selectFuncCotaMens"] as List<Funcionario>);
        }


        public void excluir(Funcionario obj)
        {
            (Session["selectFuncCotaMens"] as List<Funcionario>).Remove(obj);
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Solucon.RadControls.RadFormat.formatarGrid(RadGrid1);
                txbMes.Text = Solucon.DataHora.DataLib.extractMonth(Int16.Parse(Session["mes"].ToString())).Name;
                txbAno.Text = Session["ano"].ToString();
                txbQuantidade.Focus();
            }
        }

        protected void RadGrid1_DeleteCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
        {
            string t = e.Item.Cells[0].Text;
        }

        protected void ibtGravar_Click(object sender, ImageClickEventArgs e)
        {
            List<Funcionario> lstfuncCotaMens = (Session["selectFuncCotaMens"] as List<Funcionario>);
            DAOCota_mensal daoCota_mensal = new DAOCota_mensal();
            Cota_mensal cota_Mensal = new Cota_mensal();
            foreach (Funcionario func in lstfuncCotaMens)
            {
                cota_Mensal.novo();
                cota_Mensal.Funcionario.ID = func.ID;
                cota_Mensal.Qtde = Convert.ToInt32(txbQuantidade.Value);
                cota_Mensal.Mes = Int32.Parse(Session["mes"].ToString());
                cota_Mensal.Ano = Int32.Parse(Session["ano"].ToString());
                daoCota_mensal.aplicar(cota_Mensal);
            }
            Session.Remove("selectFuncCotaMens");
            Session.Remove("mes");
            Session.Remove("ano");
            Response.Redirect("principal.aspx");
        }

        protected void txbQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ibtVoltar_Click(object sender, ImageClickEventArgs e)
        {
            
        }
        
    }
}