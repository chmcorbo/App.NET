using System;
using simples;
using WsSinapse.dominio;
using FirebirdSql.Data.FirebirdClient;
using Sigleton.Conexao;


/// <summary>
/// Summary description for DAOHistAtualizReg
/// </summary>
/// 

namespace WsSinapse.dao
{

    public class DAOHistAtualizReg : DAOBase
    {
        public DAOHistAtualizReg()
        {

        }
        public override void inserir(ClasseBase obj)
        {
            throw new Exception("Método Inserir da Classe DAOHistAtualizReg sem implementação");
        }
        public override void excluir(ClasseBase obj)
        {
            throw new Exception("Método Excluir da Classe DAOHistAtualizReg sem implementação");
        }
        public override void alterar(ClasseBase obj)
        {
            throw new Exception("Método Alterar da Classe DAOHistAtualizReg sem implementação");
        }
        public override bool buscarID(ClasseBase obj)
        {
            throw new Exception("Método BuscarID da Classe DAOHistAtualizReg sem implementação");
        }
        public HistAtualizReg buscarAtualizLicenca(int id_licenca_cliente)
        {
            SigletonConexaoFB.carregaStrcnx();
            HistAtualizReg resultado = new HistAtualizReg();
            FbCommand command = new FbCommand();
            FbDataReader reader;
            try
            {
                command.Connection = SigletonConexaoFB.getConexao();
                command.CommandText = "SELECT ID,ID_LICENCA_CLIENTE,DATA_ENVIO,QTDE_LICENCA,LIBERADO_ATE,VERSAO_ANIEL " +
                    "FROM TB_ATUALIZ_REG_ANIEL WHERE ID_LICENCA_CLIENTE=" + id_licenca_cliente.ToString() +
                    " AND LIBERADO_CLIENTE='" + 'S' + "'";
                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    resultado.Id = int.Parse(reader["ID"].ToString());
                    resultado.Licenca_cliente.Id = int.Parse(reader["ID_LICENCA_CLIENTE"].ToString());
                    resultado.Data_envio = DateTime.Parse(reader["DATA_ENVIO"].ToString());
                    resultado.Qtde_licenca = int.Parse(reader["QTDE_LICENCA"].ToString());
                    resultado.Liberado_ate = DateTime.Parse(reader["LIBERADO_ATE"].ToString());
                    resultado.Versao_aniel = reader["VERSAO_ANIEL"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar dados do registro do Aniel: " + ex.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return resultado;
        }
        public bool AtualizHistRegAniel(int id_atualiz_reg, String usuario)
        {
            bool resultado = false;
            SigletonConexaoFB.carregaStrcnx();
            FbCommand command = new FbCommand();
            try
            {
                command.Connection = SigletonConexaoFB.getConexao();
                command.CommandText = "UPDATE TB_ATUALIZ_REG_ANIEL SET LIBERADO_CLIENTE='" + 'N' + "'," +
                    " USUARIO_ATUALIZ='" + usuario + "'," +
                    " DATA_ATUALIZ=CURRENT_DATE," +
                    " HORA_ATUALIZ=CURRENT_TIME" +
                    " WHERE ID=" + id_atualiz_reg.ToString();
                command.Connection.Open();
                command.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao registrar a atualização de registro do Aniel: " + ex.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return resultado;
        }
        //
        // TODO: Add constructor logic here
        //

    }
}
