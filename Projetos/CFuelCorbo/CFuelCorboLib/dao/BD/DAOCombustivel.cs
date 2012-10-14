namespace CFuelCorboLib.dao.BD.combustivel
{
    using System;
    using MySql.Data.MySqlClient;
    using System.Text;
    using System.Collections.Generic;
    using CorboLibUtils.Conexao.BD.MySQL;
    using CFuelCorboLib.dominio.combustivel;
    using CFuelCorboLib.dao;
    using CorboLibUtils.State;
    using CorboLibUtils.DAO;


    public class DAOCombustivel : DAOBase
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

        public DAOCombustivel()
        {
            conexao = MySQL.getNewConexao();
            CriarObjetosPadrao();
        }

        public DAOCombustivel(MySqlConnection pConexao)
        {
            conexao = pConexao;
            CriarObjetosPadrao();
        }


        public override bool inserir(CorboLibUtils.Dominio.ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("INSERT INTO TB_COMBUSTIVEL ");
                vsql.Append("(DESCRICAO)");
                vsql.Append("VALUES ");
                vsql.Append("('" + ((Combustivel)obj).descricao + "')");
                
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir o combustível. " + e.Message);
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
                vsql.Append("UPDATE TB_COMBUSTIVEL ");
                vsql.Append("SET DESCRICAO = '" + ((Combustivel)obj).descricao + "'");
                vsql.Append("WHERE ID=" + ((Combustivel)obj).ID);
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar o combustível. " + e.Message);
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
                vsql.Append("DELETE FROM COMBUSTIVEL WHERE ID=" + ((Combustivel)obj).ID);
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir o combustível. " + e.Message);
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
                vsql.Append("SELECT ID,DESCRICAO FROM TB_COMBUSTIVEL ");
                vsql.Append("WHERE ID=" + ((Combustivel)obj).ID.ToString());
                command.CommandText = command.CommandText + vsql.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Combustivel)obj).descricao = reader["DESCRICAO"].ToString();
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

        public List<Combustivel> listar()
        {
            List<Combustivel> lista = new List<Combustivel>();
            System.Data.DataSet ds = new System.Data.DataSet();
            Int32 x = 0;

            try
            {
                MySqlDataReader reader;
                command.Connection.Open();
                vsql.Append("SELECT ID, DESCRICAO FROM COMBUSTIVEL ");
                vsql.Append("ORDER BY DESCRICAO ");
                command.CommandText = vsql.ToString();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Combustivel());
                    lista[x].ID = Convert.ToInt32(reader["ID"]);
                    lista[x].descricao = reader["DESCRICAO"].ToString();
                    x++;
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao montar a lista de combustível. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
        }


    }
}
