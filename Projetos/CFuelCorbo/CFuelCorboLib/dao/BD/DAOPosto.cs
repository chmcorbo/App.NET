namespace CFuelCorboLib.dao.BD.abastecimento
{
    using System;
    using MySql.Data.MySqlClient;
    using System.Text;
    using System.Collections.Generic;
    using CorboLibUtils.Conexao.BD.MySQL;
    using CFuelCorboLib.dominio.abastecimento;
    using CFuelCorboLib.dao;
    using CorboLibUtils.State;
    using CorboLibUtils.DAO;

    public class DAOPosto : DAOBase
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

        public DAOPosto()
        {
            conexao = MySQL.getNewConexao();
            CriarObjetosPadrao();
        }


        public DAOPosto(MySqlConnection pConexao)
        {
            conexao = pConexao;
            CriarObjetosPadrao();
        }


        public override bool inserir(CorboLibUtils.Dominio.ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("INSERT INTO TB_POSTO ");
                vsql.Append("(NOME,");
                vsql.Append("BAIRRO,");
                vsql.Append("CIDADE,");
                vsql.Append("UF)");
                vsql.Append("VALUES ");
                vsql.Append("('");
                vsql.Append(((Posto)obj).nome + "','");
                vsql.Append(((Posto)obj).bairro + "','");
                vsql.Append(((Posto)obj).cidade + "','");
                vsql.Append(((Posto)obj).uf + "')");
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir o posto. " + e.Message);

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
                vsql.Append("UPDATE TB_POSTO ");
                vsql.Append("SET NOME = '" + ((Posto)obj).nome + "'");
                vsql.Append(",BAIRRO = '" + ((Posto)obj).bairro + "'");
                vsql.Append(",CIDADE = '" + ((Posto)obj).cidade + "'");
                vsql.Append(",UF = '" + ((Posto)obj).uf + "'");
                vsql.Append("WHERE ID=" + ((Posto)obj).ID);
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar o posto. " + e.Message);
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
                vsql.Append("DELETE FROM TB_POSTO WHERE ID=" + ((Posto)obj).ID);
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir o posto. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;

        }

        public override bool buscarID(CorboLibUtils.Dominio.ClasseBase obj)
        {
            MySqlDataReader reader;
            bool erro = true;
            try
            {
                command.Connection.Open();
                vsql.Append("SELECT ID,NOME,BAIRRO,CIDADE,UF FROM TB_POSTO ");
                vsql.Append("WHERE ID=" + ((Posto)obj).ID.ToString());
                command.CommandText = command.CommandText + vsql.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Posto)obj).nome = reader["NOME"].ToString();
                    ((Posto)obj).bairro = reader["BAIRRO"].ToString();
                    ((Posto)obj).cidade = reader["CIDADE"].ToString();
                    ((Posto)obj).uf = reader["UF"].ToString();
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

        public List<Posto> listar()
        {
            List<Posto> lista = new List<Posto>();
            Posto posto;
            MySqlDataReader reader;

            try
            {
                command.Connection.Open();
                vsql.Append("SELECT ID,NOME,BAIRRO,CIDADE,UF FROM TB_POSTO ");
                vsql.Append("SELECT NOME ");

                command.CommandText = vsql.ToString();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    posto = new Posto();
                    posto.ID = Convert.ToInt32(reader["ID"].ToString());
                    posto.nome = reader["NOME"].ToString();
                    posto.bairro = reader["BAIRRO"].ToString();
                    posto.cidade = reader["CIDADE"].ToString();
                    posto.uf = reader["UF"].ToString();
                    lista.Add(posto);
                }
            }
            finally
            {
                command.Connection.Close();
            }

            return lista;
        }

    }
}
