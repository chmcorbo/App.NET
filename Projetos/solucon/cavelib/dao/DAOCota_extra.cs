/// <summary>
/// Persistência de Cota de extra
/// </summary>


namespace Cave.DAO.Abastecimento
{
    using Solucon.Dominio;
    using Solucon.DAO;
    using Sigleton.Conexao;
    using System;
    using System.Data.SqlClient;
    using System.Text;
    using Cave.Dominio.Abastecimento;
    using Cave.Dominio.RH;

    public class DAOCota_extra : DAOBase
    {
        private SqlCommand command;
        private StringBuilder vsql;

        public DAOCota_extra()
        {
            command = new SqlCommand();
            vsql = new StringBuilder();
        }


        public override bool alterar(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("UPDATE COTA_EXTRA ");
                vsql.Append("SET ID_FUNCIONARIO = " + ((Cota_extra)obj).Funcionario.ID.ToString());
                vsql.Append(",DATA = " + ((Cota_extra)obj).Dt_autoriz.ToString("MM/dd/yyyy"));
                vsql.Append(",QUANTIDADE = " + ((Cota_extra)obj).Quantidade.ToString());
                vsql.Append(",JUSTIFICATIVA = " + ((Cota_extra)obj).Justificativa);
                vsql.Append("WHERE ID=" + ((Cota_mensal)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar a cota extra do funcionário. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;

        }

        public override bool excluir(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("DELETE FROM COTA_EXTRA WHERE ID=" + ((Cota_extra)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir a cota extra desse funcionário. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;

        }

        public override bool inserir(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("INSERT INTO COTA_EXTRA ");
                vsql.Append("(ID_FUNCIONARIO,");
                vsql.Append("DATA,");
                vsql.Append("QUANTIDADE,");
                vsql.Append("JUSTIFICATIVA)");
                vsql.Append("VALUES ");
                vsql.Append("(" + ((Cota_extra)obj).Funcionario.ID.ToString() + ",");
                vsql.Append("'" + ((Cota_extra)obj).Dt_autoriz.ToString("MM/dd/yyyy") + "',");
                vsql.Append(((Cota_extra)obj).Quantidade.ToString() + ",");
                vsql.Append("'"+((Cota_extra)obj).Justificativa + "')");
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir a cota mensal do funcionário. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;
        }
        public override bool buscarID(ClasseBase obj)
        {
            SqlDataReader reader;
            bool erro = true;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                vsql.Append("SELECT ID,ID_VEICULO,ID_FUNCIONARIO,DATA,QUANTIDADE,JUSTIFICATIVA FROM COTA_EXTRA ");
                vsql.Append(" WHERE ID=" + ((Cota_extra)obj).ID.ToString());
                command.CommandText = command.CommandText + vsql.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Cota_extra)obj).Veiculo.ID = Convert.ToInt32(reader["ID_VEICULO"]);
                    ((Cota_extra)obj).Funcionario.ID = Convert.ToInt32(reader["ID_FUNCIONARIO"]);
                    ((Cota_extra)obj).Dt_autoriz = Convert.ToDateTime(reader["DATA"]);
                    ((Cota_extra)obj).Quantidade = Convert.ToInt32(reader["QUANTIDADE"]);
                    ((Cota_extra)obj).Justificativa = reader["JUSTIFICATIVA"].ToString();
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

        public Int32 verifCotaextra(Funcionario obj, Int32 pmes, Int32 pano)
        {
            SqlDataReader reader;
            Int32 resultado = 0;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                vsql.Append("SELECT SUM(QUANTIDADE) as QUANTIDADE FROM COTA_EXTRA ");
                vsql.Append(" WHERE ID_FUNCIONARIO=" + obj.ID.ToString());
                vsql.Append(" AND MONTH(DATA)=" + pmes);
                vsql.Append(" AND YEAR(DATA)=" + pano);
                command.CommandText = command.CommandText + vsql.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    resultado = Convert.ToInt32(((reader["QUANTIDADE"].ToString()=="")?0:reader["QUANTIDADE"]));
                }
                else
                {
                    resultado = 0;
                }
            }
            finally
            {
                command.Connection.Close();
            }
            return resultado;
        }
    }
}