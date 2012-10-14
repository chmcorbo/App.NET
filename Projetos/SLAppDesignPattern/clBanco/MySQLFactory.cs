using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace clBanco
{
    public class MySQLFactory:IDBFactory
    {

        #region IDBFactory Members

        public System.Data.IDbConnection GetConnection()
        {
            return new MySqlConnection();
        }

        public System.Data.IDbCommand GetCommand()
        {
            return new MySqlCommand();
        }

        #endregion
    }
}