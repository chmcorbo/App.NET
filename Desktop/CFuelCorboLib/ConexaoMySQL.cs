using System;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Conexao.BD
{
    static class MySQL
    {
        #region campos
        //fields;
        static private MySqlConnection myConexao;
        static private MySqlTransaction myTransaction;
        static private String strcnx;
        #endregion

        #region propriedades;
        public static String Strcnx
        {
            get { return MySQL.strcnx; }
            set { MySQL.strcnx = value; }
        }
        //Métodos;
        public static void carregaStrcnx()
        {
            strcnx = ConfigurationSettings.AppSettings["FbConnection.ConnectionString"];
        }
        public static MySqlConnection getConexao()
        {
            if (myConexao != null)
            {
                return myConexao;
            }
            else
            {
                myConexao = getNewConexao();
            }
            return myConexao;
        }

        public static MySqlConnection getNewConexao()
        {
            return new MySqlConnection(strcnx);
        }

        public static void setTransacao(MySqlTransaction pMyTransaction)
        {
            myTransaction = pMyTransaction;
        }

        public static MySqlTransaction getTransacao()
        {
            if (myTransaction != null)
                return myTransaction;
            else
                return null;
        }

        /// <summary>
        /// Método que retorna o objeto FbConection que está associado ao fbTransaction
        /// </summary>
        /// <returns>
        /// FbConection
        /// </returns>
        public static MySqlConnection getConexaoTransacao()
        {
            if (myTransaction == null || myTransaction.Connection == null)
                return null;
            else
                return myTransaction.Connection;
        }

        #endregion
    }
}
