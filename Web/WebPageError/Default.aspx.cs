using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPageError
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LbResultado.Visible = false;
        }

        protected void Page_Error(System.Object sender, EventArgs e)
        {
            Session["erro_messagem"] = Server.GetLastError().Message.ToString();
            Session["erro_source"] = Server.GetLastError().Source;
            Session["erro_stacktrace"] = Server.GetLastError().StackTrace;
            Session["erro_targetsite"] = Server.GetLastError().TargetSite;
            Session["urlErro"] = Request.Url;
            Response.Redirect("erro.aspx?erro_menssagem=" + Server.GetLastError().Message);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Double valor1 = 0;
            Double valor2 = 0;
            Double resultado = 0;
            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);
            switch (ddpOperacao.SelectedValue)
            {
                case "somar":
                    resultado = valor1 + valor2;
                    break;
                case "substrair":
                    resultado = valor1 - valor2;
                    break;
                case "multiplicar":
                    resultado = valor1 * valor2;
                    break;
                case "dividir":
                    resultado = valor1 / valor2;
                    break;
            }
            LbResultado.Visible = true;
            LbResultado.Text = resultado.ToString();
        }
    }
}
