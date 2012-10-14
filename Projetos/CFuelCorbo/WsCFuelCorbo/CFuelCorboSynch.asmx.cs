﻿using System.Web.Services;

namespace WsCFuelCorbo
{
    /// <summary>
    /// Descrição da classe DataSynch
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DataSynch : System.Web.Services.WebService
    {

        [WebMethod]
        public string About()
        {
            return "WebService de sincronismo do CFuelCorbo";
        }
    }
}
