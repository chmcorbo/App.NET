using System;

namespace CaveWeb
{
    public partial class erro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbErro.Text = Session["ERRO"].ToString();
                lbURLErro.Text = Session["URLERRO"].ToString();
                lbStackTrace.Text = Session["STACKTRACE"].ToString();
            }
        }
    }
}
