using System;
using simples;
using WsSinapse.dominio;
using FirebirdSql.Data.FirebirdClient;
using Sigleton.Conexao;

namespace WsSinapse.dao
{
    public class DAOEquipe : DAOBase
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
        public Equipe buscarCod_Equipe(String cod_equipe)
        {
            SigletonConexaoFB.carregaStrcnx();
            Equipe resultado = new Equipe();
            FbCommand command = new FbCommand();
            FbDataReader reader;
            try
            {
                command.Connection = SigletonConexaoFB.getConexao();
                command.CommandText = "SELECT A.EQUIPE,A.NOME,A.COD_PERFIL_EQUIPE,B.NOME as NOME_PERFIL FROM TB_EQUIPE A " +
                    "LEFT OUTER JOIN TB_PERFIL_EQUIPE B ON (B.COD_PERFIL_EQUIPE=A.COD_PERFIL_EQUIPE) WHERE EQUIPE='" + cod_equipe + "'";

                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    resultado.Cod_Equipe = reader["EQUIPE"].ToString();
                    resultado.Nome = reader["NOME"].ToString();
                    resultado.Perfil.Cod_Perfil_Equipe = int.Parse(reader["COD_PERFIL_EQUIPE"].ToString());
                    resultado.Perfil.Nome = reader["NOME_PERFIL"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na busca da equipe pelo código: " + ex.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return resultado;
        }
    }
}
