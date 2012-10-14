namespace CFuelCorboLib.dao.BD.veiculo
{
    using System;
    using MySql.Data.MySqlClient;
    using System.Text;
    using System.Collections.Generic;
    using CorboLibUtils.Conexao.BD.MySQL;
    using CFuelCorboLib.dominio.veiculo;
    using CFuelCorboLib.dao;
    using CorboLibUtils.State;
    using CorboLibUtils.DAO;
    
    enum CampoBusca
    {
        ID,
        Placa,
    }

    public class DAOVeiculo : DAOBase
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
        
        public DAOVeiculo()
        {
            conexao = MySQL.getNewConexao();
            CriarObjetosPadrao();
        }

        public DAOVeiculo(MySqlConnection pConexao)
        {
            conexao = pConexao;
            CriarObjetosPadrao();
        }


        private void bind(MySqlDataReader reader, Veiculo obj)
        {
            obj.ID = Convert.ToInt32(reader["ID"].ToString());
            obj.placa = reader["PLACA"].ToString();
            obj.marca = reader["MARCA"].ToString();
            obj.modelo = reader["MODELO"].ToString();
            obj.cor = reader["COR"].ToString();
            obj.renavan = reader["RENAVAM"].ToString();
        }

        private void SelectPadrao()
        {
            vsql.Remove(0, vsql.Length);
            vsql.Append("SELECT ID");
            vsql.Append(",PLACA");
            vsql.Append(",MARCA");
            vsql.Append(",MODELO");
            vsql.Append(",COR");
            vsql.Append(",RENAVAM");
            vsql.Append("FROM TB_VEICULO ");
            command.CommandText = vsql.ToString();
        }

        public override bool inserir(CorboLibUtils.Dominio.ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("INSERT INTO VEICULO ");
                vsql.Append("(PLACA,");
                vsql.Append("MARCA,");
                vsql.Append("MODELO,");
                vsql.Append("COR,");
                vsql.Append("RENAVAM)");
                vsql.Append("VALUES ");
                vsql.Append("('");
                vsql.Append(((Veiculo)obj).placa + "','");
                vsql.Append(((Veiculo)obj).marca + "','");
                vsql.Append(((Veiculo)obj).modelo + "','");
                vsql.Append(((Veiculo)obj).cor + "','");
                vsql.Append(((Veiculo)obj).renavan + ")");
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir o veículo. " + e.Message);

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
                vsql.Append("UPDATE VEICULO ");
                vsql.Append("SET PLACA = '" + ((Veiculo)obj).placa + "'");
                vsql.Append(",MARCA = '" + ((Veiculo)obj).marca + "'");
                vsql.Append(",MODELO = '" + ((Veiculo)obj).modelo + "'");
                vsql.Append(",COR = '" + ((Veiculo)obj).cor + "'");
                vsql.Append(",RENAVAM = '" + ((Veiculo)obj).renavan + "'");
                vsql.Append("WHERE ID=" + ((Veiculo)obj).ID);
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar o veículo. " + e.Message);
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
                vsql.Append("DELETE FROM VEICULO WHERE ID=" + ((Veiculo)obj).ID);
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir o veículo. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;
        }

        private bool buscar(Veiculo pVeiculo, CampoBusca pCampoBusca)
        {
            MySqlDataReader reader;
            Veiculo veiculo;
            bool erro = true;
            try
            {
                command.Connection.Open();
                SelectPadrao();

                if (pCampoBusca==CampoBusca.ID)
                    vsql.Append("WHERE ID=" + pVeiculo.ID.ToString());
                else if (pCampoBusca == CampoBusca.Placa)
                   vsql.Append("WHERE PLACA='" + pVeiculo.placa.ToString());
                
                command.CommandText = vsql.ToString();
                
                reader = command.ExecuteReader();
                
                veiculo = pVeiculo;
                
                if (reader.Read())
                {
                    bind(reader, veiculo);
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

        public override bool buscarID(CorboLibUtils.Dominio.ClasseBase obj)
        {
            return buscar((Veiculo)obj, CampoBusca.ID); ;
        }

        public bool buscarPlaca(CorboLibUtils.Dominio.ClasseBase obj)
        {
            return buscar((Veiculo)obj, CampoBusca.Placa); ;
        }

        public List<Veiculo> listar()
        {
            List<Veiculo> lista = new List<Veiculo>();
            Veiculo veiculo;

            try
            {
                MySqlDataReader reader;
                command.Connection.Open();
                SelectPadrao();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    veiculo = new Veiculo();
                    bind(reader, veiculo);
                    lista.Add(veiculo);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao montar a lista de veiculo. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }

            return lista;
        }

    }
}
