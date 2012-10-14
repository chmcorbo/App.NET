using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clBanco
{
    public enum TipoBD{Firebird, SQLServer, MySQL};

    public class DBControlsAbstractFactory
    {
        public static IDBFactory GetDBFactory(TipoBD tipoConexao)
        {            
            switch(tipoConexao)
            {
                case 
                    TipoBD.Firebird:return new FBFactory();
                    break;
                case 
                    TipoBD.MySQL:return new MySqlFactory();
                    break;
                case
                    TipoBD.SQLServer:return new SQLServerFactory();
                    break;
                default:
                    return null;
            }
        }
    }
}
