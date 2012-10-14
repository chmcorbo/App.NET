using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cave.Dominio.RH;
using Cave.DAO.RH;

namespace CaveWeb
{
    public partial class relFuncionarioAbastecimento : System.Web.UI.Page
    {
        private Funcionario funcionario;
        private DAOFuncionario daoFuncionario;

        private void getFuncionario()
        {
            funcionario = (Session["funcionario"] as Funcionario);
            funcionario.Matricula = txbMatricula.Text;
            if (funcionario.Matricula != "")
            {
                daoFuncionario = new DAOFuncionario();
                daoFuncionario.buscarMatricula(funcionario);
            }
            else
                funcionario.Nome = "";
            Session["funcionario"] = funcionario;
        }
        private void setFuncionario()
        {
            txbNomeFunc.Text = funcionario.Nome;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                funcionario = new Funcionario();
                Session["funcionario"] = funcionario;
            }

            if (Session["buscaFunc"] != null)
            {
                txbMatricula.Text = (Session["buscaFunc"] as Funcionario).Matricula;
                txbMatricula_TextChanged(sender, e);
                Session.Remove("buscaFunc");
            }

        }

        protected void ibtVisualizar_Click(object sender, ImageClickEventArgs e)
        {
            Session["matricula"] = txbMatricula.Text;
            Session["ano"] = ddlANo.SelectedValue;
            Session["mes"] = ddlMes.SelectedValue;
            Literal1.Text = "<script type=text/javascript> window.open('AbastecimentoFuncionario.aspx') </script>";
        }

        protected void txbMatricula_TextChanged(object sender, EventArgs e)
        {
            getFuncionario();
            setFuncionario();
        }
    }
}
