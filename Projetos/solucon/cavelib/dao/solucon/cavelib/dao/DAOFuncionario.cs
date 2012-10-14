/// <summary>
/// Persistência Funcionário
/// </summary>
///


namespace Cave.DAO.RH
{
    using Solucon.Dominio;
    using Solucon.DAO;
    using Cave.Dominio.RH;
    using Sigleton.Conexao;
    using System;
    using System.Data.SqlClient;
    using System.Text;

    public class DAOFuncionario : DAOBase
    {
        private SqlCommand command;
        private StringBuilder vsql;

        public DAOFuncionario()
        {
            command = new SqlCommand();
            vsql = new StringBuilder();
        }

        #region IDAOBase Members

        public override bool alterar(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("UPDATE FUNCIONARIO SET "); 
                vsql.Append(" MATRICULA='" + ((Funcionario)obj).Matricula + "', ");
                vsql.Append(" NOME='" + ((Funcionario)obj).Nome + "', ");
                vsql.Append(" DATA_ADMISSAO='" + ((Funcionario)obj).Data_admissao.ToString("MM/dd/yyyy") + "', ");
                vsql.Append(" DATA_DEMISSAO='" + ((Funcionario)obj).Data_demissao.ToString("MM/dd/yyyy") + "', ");
                vsql.Append(" NUM_CNH='" + ((Funcionario)obj).Num_CNH + "', ");
                vsql.Append(" CLASSE_CNH='" + ((Funcionario)obj).Classe_CNH + "', ");
                vsql.Append(" VENCTO_CNH='" + ((Funcionario)obj).Vencto_CNH.ToString("MM/dd/yyyy") + "', ");
                if (((Funcionario)obj).Funcao.ID==0)
                   vsql.Append(" ID_FUNCAO=Null");
                else
                   vsql.Append(" ID_FUNCAO="+((Funcionario)obj).Funcao.ID.ToString());
                vsql.Append(" WHERE ID=" +((Funcionario)obj).ID.ToString());
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar o funcionário. " + e.Message);
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
                vsql.Append("DELETE FROM FUNCIONARIO WHERE ID=" + ((Funcionario)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir o funcionário. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;

        }

        public override bool inserir(ClasseBase obj)
        {
            SqlCommand command = new SqlCommand();
            StringBuilder vsql = new StringBuilder();
            bool erro = true;
            try
            {
                vsql.Append("INSERT INTO FUNCIONARIO ");
                vsql.Append("(MATRICULA, ");
                vsql.Append("NOME, ");
                vsql.Append("DATA_ADMISSAO, ");
                vsql.Append("DATA_DEMISSAO, ");
                vsql.Append("NUM_CNH, ");
                vsql.Append("CLASSE_CNH, ");
                vsql.Append("VENCTO_CNH, ");
                vsql.Append("ID_FUNCAO)");
                vsql.Append("VALUES ");
                vsql.Append("('" + ((Funcionario)obj).Matricula + "',");
                vsql.Append("'" + ((Funcionario)obj).Nome + "',");
                vsql.Append("'" + ((Funcionario)obj).Data_admissao.ToString("MM/dd/yyyy") + "',");
                vsql.Append("'" + ((Funcionario)obj).Data_demissao.ToString("MM/dd/yyyy") + "',");
                vsql.Append("'" + ((Funcionario)obj).Num_CNH + "',");
                vsql.Append("'" + ((Funcionario)obj).Classe_CNH + "',");
                vsql.Append("'" + ((Funcionario)obj).Vencto_CNH.ToString("MM/dd/yyyy") + "',");
                if (((Funcionario)obj).Funcao.ID == 0)
                    vsql.Append("Null)");
                else
                    vsql.Append(((Funcionario)obj).Funcao.ID.ToString() + ")");

                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir o funcionário. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;
        }

        public override bool buscarID(ClasseBase obj)
        {
            return buscar(obj, 1);
        }

        private bool buscar(ClasseBase obj, int i)
        {
            // 1 para ID;
            // 2 Para Matrícula;
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            bool erro = true;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT ID,MATRICULA,NOME,DATA_ADMISSAO,ISNULL(DATA_DEMISSAO,'') as DATA_DEMISSAO,NUM_CNH,CLASSE_CNH," +
                    "VENCTO_CNH,ID_FUNCAO FROM FUNCIONARIO ";
                if (i == 1)
                    command.CommandText = command.CommandText + " WHERE ID=" + ((Funcionario)obj).ID.ToString();
                else
                    command.CommandText = command.CommandText + " WHERE MATRICULA='" + ((Funcionario)obj).Nome + "'";

                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Funcionario)obj).ID = Convert.ToInt32(reader["ID"]);
                    ((Funcionario)obj).Matricula = reader["MATRICULA"].ToString();
                    ((Funcionario)obj).Nome = reader["NOME"].ToString();
                    ((Funcionario)obj).Data_admissao = Convert.ToDateTime(reader["DATA_ADMISSAO"]);
                    ((Funcionario)obj).Data_demissao = Convert.ToDateTime(reader["DATA_DEMISSAO"]);
                    ((Funcionario)obj).Num_CNH = reader["NUM_CNH"].ToString();
                    ((Funcionario)obj).Classe_CNH = reader["CLASSE_CNH"].ToString();
                    ((Funcionario)obj).Vencto_CNH = Convert.ToDateTime(reader["VENCTO_CNH"]);
                    ((Funcionario)obj).Funcao.ID = Convert.ToInt32(reader["ID_FUNCAO"]);
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

        public bool buscarMatricula(ClasseBase obj, int p)
        {
            return buscar(obj, 2);
        }

        #endregion

        public bool verifNome(Funcionario obj)
        {
            SqlCommand command = new SqlCommand();
            Int32 co;
            bool resultado = false;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT COUNT(NOME) AS CO FROM FUNCIONARIO " +
                    "WHERE NOME='" + ((Funcionario)obj).Nome + "' and ID<>" + ((Funcionario)obj).ID.ToString();
                co = (int)command.ExecuteScalar();
                resultado = (co > 0);
            }
            finally
            {
                command.Connection.Close();
            }
            return resultado;
        }
        public bool verifMatricula(Funcionario obj)
        {
            SqlCommand command = new SqlCommand();
            Int32 co;
            bool resultado = false;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT COUNT(NOME) AS CO FROM FUNCIONARIO " +
                    "WHERE MATRICULA='" + ((Funcionario)obj).Matricula + "' and ID<>" + ((Funcionario)obj).ID.ToString();
                co = (int)command.ExecuteScalar();
                resultado = (co > 0);
            }
            finally
            {
                command.Connection.Close();
            }
            return resultado;
        }
        public override bool validarDAO(ClasseBase obj)
        {
            bool result = false;

            if ((obj.Estado == Solucon.State.Stateobj.stNovo || obj.Estado == Solucon.State.Stateobj.stEditar))
            {
                if (verifMatricula((Funcionario)obj))
                    throw new EInvalidObjectDAOBase("Matrícula já cadastrada");

                result = true;
            }
            else
                result = base.validarDAO(obj);
            return result;
        }

    }
}