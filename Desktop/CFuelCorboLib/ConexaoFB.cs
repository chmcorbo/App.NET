using System;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;

namespace Conexao.BD
{
    static class Firebird
    {
        #region campos
        //fields;
        static private FbConnection fbConexao;
        static private FbTransaction fbTransaction;
        static private String strcnx;
        #endregion 

        #region propriedades;
        public static String Strcnx
        {
            get { return Firebird.strcnx; }
            set { Firebird.strcnx = value; }
        }
        //Métodos;
        public static void carregaStrcnx()
        {
            strcnx = ConfigurationSettings.AppSettings["FbConnection.ConnectionString"];
        }
        public static FbConnection getConexao()
        {
            if (fbConexao != null)
            {
                return fbConexao;
            }
            else
            {
                fbConexao = getNewConexao();
            }
            return fbConexao;
        }

        public static FbConnection getNewConexao()
        {
            return new FbConnection(strcnx);
        }

        public static void setTransacao(FbTransaction pfbTransaction)
        {
            fbTransaction = pfbTransaction;
        }

        public static FbTransaction getTransacao()
        {
            if (fbTransaction != null)
                return fbTransaction;
            else
                return null;
        }

        /// <summary>
        /// Método que retorna o objeto FbConection que está associado ao fbTransaction
        /// </summary>
        /// <returns>
        /// FbConection
        /// </returns>
        public static FbConnection getConexaoTransacao()
        {
            if (fbTransaction == null || fbTransaction.Connection == null)
                return null;
            else
                return fbTransaction.Connection;
        }

        #endregion
    }
}
