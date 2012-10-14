using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CaveWeb
{
    public partial class sair : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ibtSim_Click(object sender, ImageClickEventArgs e)
        {
            Session.Abandon();
            System.Web.Security.FormsAuthentication.SignOut();
            Response.Redirect("default.aspx");
        }

        protected void ibtNao_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("principal.aspx");
        }
    }
}
