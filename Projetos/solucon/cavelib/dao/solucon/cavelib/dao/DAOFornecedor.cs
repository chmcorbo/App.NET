/// <summary>
/// Persistência de Fornecedor
/// </summary>

namespace Cave.DAO.Financeiro
{
    using Solucon.Dominio;
    using Solucon.DAO;
    using Sigleton.Conexao;
    using System;
    using System.Data.SqlClient;
    using System.Text;
    using Cave.Dominio.Financeiro;
 
    public class DAOFornecedor : DAOBase
    {
        private SqlCommand command;
        private StringBuilder vsql;

        public DAOFornecedor()
        {
            command = new SqlCommand(); ;
            vsql = new StringBuilder();
        }

        public override bool alterar(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("UPDATE FORNECEDOR SET ");
                vsql.Append(" RAZAO_SOCIAL='" + ((Fornecedor)obj).Razao_social + "', ");
                vsql.Append(" CNPJ='" + ((Fornecedor)obj).Cnpj + "', ");
                vsql.Append(" INSC_ESTADUAL='" + ((Fornecedor)obj).Insc_estadual + "', ");
                vsql.Append(" INSC_MUNICIPAL='" + ((Fornecedor)obj).Insc_municipal + "'");
                vsql.Append(" WHERE ID=" + ((Fornecedor)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar o fornecedor. " + e.Message);
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
                command.CommandText = "SELECT ID,RAZAO_SOCIAL,CNPJ,INSC_ESTADUAL,INSC_MUNICIPAL " +
                    " FROM FORNECEDOR WHERE ID=" + ((Fornecedor)obj).ID.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Fornecedor)obj).Razao_social = reader["RAZAO_SOCIAL"].ToString();
                    ((Fornecedor)obj).Cnpj = reader["CNPJ"].ToString();
                    ((Fornecedor)obj).Insc_estadual = reader["INSC_ESTADUAL"].ToString();
                    ((Fornecedor)obj).Insc_municipal = reader["INSC_MUNICIPAL"].ToString();
                    reader.Close();
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

        public override bool excluir(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("DELETE FROM FORNECEDOR WHERE ID=" + ((Fornecedor)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir o fornecedor. " + e.Message);
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
                vsql.Append("INSERT INTO FORNECEDOR ");
                vsql.Append("(RAZAO_SOCIAL, ");
                vsql.Append("CNPJ, ");
                vsql.Append("INSC_ESTADUAL, ");
                vsql.Append("INSC_MUNICIPAL) ");
                vsql.Append("VALUES ");
                vsql.Append("('" + ((Fornecedor)obj).Razao_social + "',");
                vsql.Append("'" + ((Fornecedor)obj).Cnpj + "',");
                vsql.Append("'" + ((Fornecedor)obj).Insc_estadual + "',");
                vsql.Append("'" + ((Fornecedor)obj).Insc_municipal + "')");


                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir o fornecedor. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;
        }

        public bool verifCnpj(String cnpj)
        {
            Int32 co;
            bool resultado = false;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT COUNT(ID) AS CO FROM FORNECEDOR " +
                    "WHERE CNPJ='" + cnpj+"'";
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

            if ((obj.Estado == Solucon.State.Stateobj.stNovo))
            {
                if (verifCnpj(((Fornecedor)obj).Cnpj))
                    throw new EInvalidObjectDAOBase("CNPJ já cadastrado");

                result = true;
            }
            else
                result = base.validarDAO(obj);
            return result;
        }
    }
}