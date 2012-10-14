﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDataBinds
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(DateTime.Now.Date.ToString("hh:mm:ss"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ObjectDataSource1;
            GridView1.DataBind();
        }
    }
}
