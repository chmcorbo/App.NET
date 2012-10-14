using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CFuelCorboLib.dominio;
using CFuelCorboLib.dao;

namespace CFuelWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void BtnNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("pgAbastecimento.aspx?op=I&id=0");

        }
    }
}
