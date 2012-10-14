using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using simples;
using WsSinapse.dominio;
using FirebirdSql.Data.FirebirdClient;
using Sigleton.Conexao;

namespace WsSinapse.dao
{
    public class DAOLicenca_cliente : DAOBase 
    {

        public override void inserir(ClasseBase obj)
        {
            throw new Exception("Método Inserir da Classe DAOLicenca_cliente sem implementação");
        }
        public override void excluir(ClasseBase obj)
        {
            throw new Exception("Método Excluir da Classe DAOLicenca_cliente sem implementação");
        }
        public override void alterar(ClasseBase obj)
        {
            throw new Exception("Método Alterar da Classe DAOLicenca_cliente sem implementação");
        }
        public override bool buscarID(ClasseBase obj)
        {
            bool resultado = false;
            SigletonConexaoFB.carregaStrcnx();
            FbCommand command = new FbCommand();
            FbDataReader reader;

            try
            {
                command.Connection = SigletonConexaoFB.getConexao();
                command.CommandText = "SELECT ID,COD_CLIENTE,DATA_VENDA,DATA_CRIACAO_BD, " +
                    "SITUACAO FROM TB_LICENCA_CLIENTE WHERE ID=" + ((Licenca_cliente)obj).Id;
                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Licenca_cliente)obj).Cliente.Cod_cliente = int.Parse(reader["COD_CLIENTE"].ToString());
                    ((Licenca_cliente)obj).Data_venda = DateTime.Parse(reader["DATA_VENDA"].ToString());
                    ((Licenca_cliente)obj).Data_criacao_bd = DateTime.Parse(reader["DATA_CRIACAO_BD"].ToString());
                    if (!reader.IsDBNull(reader.GetOrdinal("SITUACAO")))
                    {
                        ((Licenca_cliente)obj).Situacao = int.Parse(reader["SITUACAO"].ToString());
                    }
                }
                reader.Close();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar dados do cliente: " + ex.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return resultado;
        }
        public bool buscarAtualizCliente(ClasseBase obj)
        {
            throw new Exception("Método BuscarID da Classe DAOCliente sem implementação");
        }


    }
}
