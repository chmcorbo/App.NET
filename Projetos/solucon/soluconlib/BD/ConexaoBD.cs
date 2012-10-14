using System;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for ConexaoSQLServer
/// </summary>

namespace Sigleton.Conexao
{
    static public class MsSQL
    {
        //fields;
        static private SqlConnection sqlConexao;
        static private String strcnx;
        //Properties;
        public static String Strcnx
        {
            get { return MsSQL.strcnx; }
            set { MsSQL.strcnx = value; }
        }
        //Métodos;
        static public void getStrWebConfig()
        {
            strcnx = ConfigurationSettings.AppSettings["SqlConnection.ConnectionString"];
        }
        static public SqlConnection getConexao()
        {
            if (sqlConexao == null)
            {
                getStrWebConfig();
                sqlConexao = new SqlConnection(strcnx);
            }
            return sqlConexao;
        }
    }
}
