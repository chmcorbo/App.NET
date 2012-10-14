using System;

namespace CaveWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            /*Session["ERRO"] = Server.GetLastError().InnerException.Message + "<br />" + 
                Server.GetLastError().GetBaseException().Source;
            Session["URLERRO"] = Request.Url;

            Session["STACKTRACE"] = Server.GetLastError().Source + "<br />" +
                Server.GetLastError().StackTrace.ToString();
            Response.Redirect("Erro.aspx");*/
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}