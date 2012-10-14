using System;
using simples;
using WsSinapse.dominio;
using FirebirdSql.Data.FirebirdClient;
using Sigleton.Conexao;

namespace WsSinapse.dao
{
    public class DAOProduto : DAOBase
    {

        public override void inserir(ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override void excluir(ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override void alterar(ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override bool buscarID(ClasseBase obj)
        {
            throw new NotImplementedException();
        }
        public Produto buscarCodmat(String codmat)
        {
            SigletonConexaoFB.carregaStrcnx();
            Produto resultado = new Produto();
            FbCommand command = new FbCommand();
            FbDataReader reader;
            try
            {
                command.Connection = SigletonConexaoFB.getConexao();
                command.CommandText = "SELECT CODMAT,DESCRICAO,UNID FROM TB_MATERIAL " +
                    "WHERE CODMAT='" + codmat + "'";

                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    resultado.Codmat = reader["CODMAT"].ToString();
                    resultado.Descricao = reader["DESCRICAO"].ToString();
                    resultado.Unid = reader["UNID"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na busca de produto pelo código: " + ex.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return resultado;
        }
    }
}
