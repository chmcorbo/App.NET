using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Viena.Conexao;

namespace WebFBDDEX
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                Label1.Visible = true;
                FB.Open(this);
                Label1.Text = "Conexão realizada com sucesso";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
            finally
            {
                FB.Close(this);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}
