using System;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Conexão com o MsSQLServer
/// </summary>

namespace CorboLibUtils.Conexao.BD.MsSQL
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
        static public SqlConnection getNewConexao()
        {
            getStrWebConfig();
            sqlConexao = new SqlConnection(strcnx);
            return sqlConexao;
        }
    }
}
