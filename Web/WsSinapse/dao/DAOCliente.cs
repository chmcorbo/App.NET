using System;
using simples;
using WsSinapse.dominio;
using FirebirdSql.Data.FirebirdClient;
using Sigleton.Conexao;

namespace WsSinapse.dao
{
    public class DAOCliente : DAOBase
    {
        public override void inserir(ClasseBase obj)
        {
            throw new Exception("Método Inserir da Classe DAOCliente sem implementação");
        }
        public override void excluir(ClasseBase obj)
        {
            throw new Exception("Método Excluir da Classe DAOCliente sem implementação");
        }
        public override void alterar(ClasseBase obj)
        {
            throw new Exception("Método Alterar da Classe DAOCliente sem implementação");
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
                command.CommandText = "SELECT COD_CLIENTE,FANTASIA,RAZAO_SOCIAL,SITUACAO " +
                    "FROM TB_CLIENTE WHERE COD_CLIENTE=" + ((Cliente)obj).Cod_cliente;
                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Cliente)obj).Fantasia = reader["FANTASIA"].ToString();
                    ((Cliente)obj).Razao_social = reader["RAZAO_SOCIAL"].ToString();
                    ((Cliente)obj).Situacao = int.Parse(reader["SITUACAO"].ToString());
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
