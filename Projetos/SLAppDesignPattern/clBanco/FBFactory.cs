using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clBanco
{
    public class FBFactory:IDBFactory
    {
        #region IDBFactory Members

        public System.Data.IDbConnection GetConnection()
        {
            throw new NotImplementedException();
        }

        public System.Data.IDbCommand GetCommand()
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
