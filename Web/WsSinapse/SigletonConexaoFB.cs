﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;

namespace Sigleton.Conexao
{
    static class SigletonConexaoFB
    {
        //fields;
        static private FbConnection fbConexao;
        static private String strcnx;
        //Properties;
        public static String Strcnx
        {
            get { return SigletonConexaoFB.strcnx; }
            set { SigletonConexaoFB.strcnx = value; }
        }
        //Métodos;
        static public void carregaStrcnx()
        {
            strcnx = ConfigurationSettings.AppSettings["FbConnection.ConnectionString"];
        }
        static public FbConnection getConexao()
        {
            if (fbConexao == null)
            {
                fbConexao = new FbConnection(strcnx);
            }
            return fbConexao;
        }
    }
}