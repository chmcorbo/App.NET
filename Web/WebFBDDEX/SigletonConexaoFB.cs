using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Configuration;
using FirebirdSql.Data.FirebirdClient;

namespace Viena.Conexao
{
    public static class FB
    {
        //fields;        
        static private String strcnx;
        static private FbConnection fbConexao;        
        static private FbTransaction fbTransaction;
        static private object responsable;
        //Properties;
        public static String Strcnx
        {
            get { 
                if(strcnx.Equals("")){
                    carregaStrcnx();
                }
                return FB.strcnx; }
            set { FB.strcnx = value;
                if (fbConexao != null)
                {
                    fbConexao.ConnectionString = strcnx;
                }
            }
        }
        //Métodos;
        static public void carregaStrcnx()
        {
            strcnx = ConfigurationSettings.AppSettings["FbConnection.ConnectionString"];
        }
        static public FbConnection getConexao()
        {
            carregaStrcnx();            
            if (fbConexao == null)
            {
                fbConexao = new FbConnection(strcnx);
            }            
            return fbConexao;
        }

        static public void Open(object pResponsable)
        {
            getConexao();
            if (responsable == null)
            {
                responsable = pResponsable;
            }
            if (!ConexaoAberta())
            {
                getConexao().Open();
            }
        }

        static public void Close(object pResponsable)
        {
            if (!EmTransacao())
            {
                if (responsable == pResponsable)
                {
                    responsable = null;
                    fbConexao.Close();
                }
            }
        }

        static public FbTransaction getTransacao()
        {
            return fbTransaction;
        }

        static public void IniciarTransacao()
        {
            if (!FB.ConexaoAberta()) { FB.Open(null); }
            fbTransaction = fbConexao.BeginTransaction();          
        }
        static public void SalvarTransacao()
        {
            fbTransaction.Commit();
            fbTransaction = null;
            FB.Close(null);
        }
        static public void CancelarTransacao()
        {
            fbTransaction.Rollback();
            fbTransaction = null;
            FB.Close(null);
        }
        static public Boolean ConexaoAberta()
        {
            return ((fbConexao != null) && (fbConexao.State == System.Data.ConnectionState.Open));            
        }
        static public Boolean EmTransacao()
        {            
            return (fbTransaction != null);
        }


    }
}
