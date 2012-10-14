namespace CFuelCorboLib.dao.BD.abastecimento
{
    using System;
    using System.Text;
    using MySql.Data.MySqlClient;
    using CFuelCorboLib.dominio.abastecimento;
    using CorboLibUtils.DAO;
    using System.Xml.Linq;
    using System.Collections.Generic;
    using CorboLibUtils.DataHora;
    using CorboLibUtils.Conexao.BD.MySQL;
    using CorboLibUtils.State;
    using CorboLibUtils.Dominio;

    class DAOAbastecimento : DAOBase
    {
        private MySqlConnection conexao;
        private MySqlCommand command;
        private StringBuilder vsql;

        private void CriarObjetosPadrao()
        {
            command = new MySqlCommand();
            command.Connection = conexao;
            vsql = new StringBuilder();
        }
        
        public DAOAbastecimento()
        {
            conexao = MySQL.getNewConexao();
            CriarObjetosPadrao();
        }

        public DAOAbastecimento(MySqlConnection pConexao)
        {
            conexao = pConexao;
            CriarObjetosPadrao();
        }

        public override bool buscarID(CorboLibUtils.Dominio.ClasseBase obj)
        {
            MySqlDataReader reader;
            bool erro = true;
            try
            {
                command.Connection.Open();
                vsql.Append("SELECT ID,ID_VEICULO,ID_POSTO,ID_COMBUSTIVEL,DATA_ABASTEC,HORA_ABASTEC,");
                vsql.Append("KM,LITRAGEM,KM_LITRO,VALOR_UNIT,VALOR_TOTAL,OBSERVACAO FROM TB_ABASTECIMENTO ");
                vsql.Append("WHERE ID=" + ((Abastecimento)obj).ID.ToString());
                command.CommandText = command.CommandText + vsql.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Abastecimento)obj).veiculo.ID = Convert.ToInt32(reader["ID_VEICULO"]);
                    ((Abastecimento)obj).posto.ID = Convert.ToInt32(reader["ID_POSTO"]);
                    ((Abastecimento)obj).combustivel.ID = Convert.ToInt32(reader["ID_COMBUSTIVEL"]);
                    ((Abastecimento)obj).data_abastec = Convert.ToDateTime(reader["DATA_ABASTEC"]);
                    ((Abastecimento)obj).hora_abastec = Convert.ToDateTime(reader["HORA_ABASTEC"]);
                    ((Abastecimento)obj).km = Convert.ToInt32(reader["KM"]);
                    ((Abastecimento)obj).litragem = Convert.ToDouble(reader["LITRAGEM"]);
                    ((Abastecimento)obj).km_litro = Convert.ToDouble(reader["KM_LITRO"]);
                    ((Abastecimento)obj).valor_unit = Convert.ToDouble(reader["VALOR_UNIT"]);
                    ((Abastecimento)obj).valor_total = Convert.ToDouble(reader["VALOR_TOTAL"]);
                    ((Abastecimento)obj).observacao = reader["OBSERVACAO"].ToString();
                }
                else
                {
                    erro = false;
                }
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;
        }

        public override bool inserir(CorboLibUtils.Dominio.ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("INSERT INTO TB_ABASTECIMENTO ");
                vsql.Append("(ID_VEICULO,");
                vsql.Append("ID_POSTO,");
                vsql.Append("ID_COMBUSTIVEL,");
                vsql.Append("DATA_ABASTEC,");
                vsql.Append("HORA_ABASTEC,");
                vsql.Append("KM,");
                vsql.Append("LITRAGEM,");
                vsql.Append("KM_LITRO,");
                vsql.Append("VALOR_UNIT,");
                vsql.Append("VALOR_TOTAL,");
                vsql.Append("OBSERVACAO)");
                vsql.Append("VALUES ( ");
                vsql.Append(((Abastecimento)obj).veiculo.ID.ToString() + ",");
                vsql.Append(((Abastecimento)obj).posto.ID.ToString() + ",");
                vsql.Append(((Abastecimento)obj).combustivel.ID.ToString() + ",'");
                vsql.Append(((Abastecimento)obj).data_abastec.ToString("MM/dd/yyyy") + "','");
                vsql.Append(((Abastecimento)obj).hora_abastec.ToString("hh:mm") + "',");
                vsql.Append(((Abastecimento)obj).km.ToString() + ",");
                vsql.Append(((Abastecimento)obj).litragem.ToString() + ",");
                vsql.Append(((Abastecimento)obj).km_litro.ToString() + ",");
                vsql.Append(((Abastecimento)obj).valor_unit.ToString().Replace(',', '.') + ",");
                vsql.Append(((Abastecimento)obj).valor_total.ToString().Replace(',', '.') + ",");
                vsql.Append(((Abastecimento)obj).observacao.ToString() + ")");
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir o lançamento de abastecimento. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;

        }

        public override bool alterar(CorboLibUtils.Dominio.ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("UPDATE TB_ABASTECIMENTO ");
                vsql.Append("SET ID_VEICULO = " + ((Abastecimento)obj).veiculo.ID.ToString());
                vsql.Append(",ID_POSTO = " + ((Abastecimento)obj).posto.ID.ToString());
                vsql.Append(",ID_COMBUSTIVEL = " + ((Abastecimento)obj).combustivel.ID.ToString());
                vsql.Append(",DATA_ABASTEC = '" + ((Abastecimento)obj).data_abastec.ToString());
                vsql.Append(",HORA_ABASTEC = '" + ((Abastecimento)obj).hora_abastec.ToString());
                vsql.Append("',KM = " + ((Abastecimento)obj).km.ToString());
                vsql.Append(",LITRAGEM = " + ((Abastecimento)obj).litragem.ToString());
                vsql.Append("',KM_LITRO = " + ((Abastecimento)obj).km_litro.ToString());
                vsql.Append(",VALOR_UNIT = " + ((Abastecimento)obj).valor_unit.ToString().Replace(',', '.'));
                vsql.Append(",VALOR_TOTAL = " + ((Abastecimento)obj).valor_total.ToString().Replace(',', '.'));
                vsql.Append(",OBSERVACAO = " + ((Abastecimento)obj).observacao.ToString());
                vsql.Append(" WHERE ID=" + ((Abastecimento)obj).ID);
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar o lançamento do abastecimento. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;

        }

        public override bool excluir(CorboLibUtils.Dominio.ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("DELETE FROM TB_ABASTECIMENTO WHERE ID=" + ((Abastecimento)obj).ID);
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir a lançamento de abastecimento. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;

        }

        public override bool validarDAO(ClasseBase obj)
        {
            bool result = false;
            return result;
        }

    }
}
