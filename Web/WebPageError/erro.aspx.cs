using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPageError
{
    public partial class erro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = Session["erro_messagem"].ToString();
            lblSource.Text=Session["erro_source"].ToString();
            lblStackTrace.Text=Session["erro_stacktrace"].ToString();
            lblTargetSite.Text=Session["erro_targetsite"].ToString();
            lblURL.Text = Session["urlErro"].ToString();
            Session.Remove("erro_messagem");
            Session.Remove("erro_source");
            Session.Remove("erro_stacktrace");
            Session.Remove("erro_targetsite");
            Session.Remove("urlErro");
        }
    }
}
