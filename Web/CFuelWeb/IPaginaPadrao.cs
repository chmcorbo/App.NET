using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFuelWeb
{
    interface IPaginaCadPadrao
    {
        void setDados();
        void getDados();
        void habilitarCtrl(Boolean ativar);
    }

    interface IPaginaPesqPadrao
    {
        void getDados();
    }

}
