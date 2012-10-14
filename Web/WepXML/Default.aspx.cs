using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;

namespace WepXML
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Server.MapPath("destinatarios.xml"));

            while (reader.Read())
            {
                if (reader.NodeType==element && reader.Name=="nome")
                Response.Write("<br>");
                Response.Write(reader.Name+"="+reader.Value);
                
            }
            reader.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(Server.MapPath("destinatarios.xml"));

            XPathNavigator nav = xmlDoc.CreateNavigator();
            XPathNodeIterator interator = nav.Select("/destinatarios/destinatario/e-mail");
            while (interator.MoveNext())
            {
                Response.Write("<br>");
                Response.Write(interator.Current.Value.ToString());
            }
        }
    }
}
