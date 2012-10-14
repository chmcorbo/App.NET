namespace CFuelWeb.Facade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using CFuelCorboLib.dominio;
    using CFuelCorboLib.dao;

    public class DAOFacadeAbastecimento
    {
        DAOAbastecimento daoAbastecimento;

        public DAOFacadeAbastecimento()
        {
            daoAbastecimento = new DAOAbastecimento(@"G:\App\VSCNET\Web\CFuelWeb\App_Data\");
        }
        public List<Abastecimento> getList()
        {
            return daoAbastecimento.listar();
        }
    }

}
