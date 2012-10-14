/// <summary>
/// Persistência de função
/// </summary>
///


namespace Cave.DAO.RH
{
    using Solucon.Dominio;
    using Solucon.DAO;
    using Cave.Dominio.RH;
    using Sigleton.Conexao;
    using System.Collections.Generic;
    using System;
    using System.Data.SqlClient;
    using System.Text;

    public class DAOFuncao : DAOBase
    {
        private SqlCommand command;
        private StringBuilder vsql;

        public DAOFuncao()
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
                vsql.Remove(0, vsql.Length);
                vsql.Append("UPDATE FUNCAO SET NOME='" + ((Funcao)obj).Nome.ToUpper() + "' " +
                    " WHERE ID=" + ((Funcao)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar a função. " + e.Message);
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
                vsql.Remove(0, vsql.Length);
                vsql.Append("DELETE FROM FUNCAO WHERE ID=" + ((Funcao)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir a função. " + e.Message);
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
                vsql.Remove(0, vsql.Length);
                vsql.Append("INSERT INTO FUNCAO ");
                vsql.Append("(NOME) ");
                vsql.Append("VALUES ");
                vsql.Append("('" + ((Funcao)obj).Nome.ToUpper() + "')");
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir a função. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;
        }

        public override bool buscarID(ClasseBase obj)
        {
            bool erro = true;
            SqlDataReader reader;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT ID,NOME FROM FUNCAO " +
                    "WHERE ID=" + ((Funcao)obj).ID.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Funcao)obj).Nome = reader["NOME"].ToString();
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

        #endregion

        public List<Funcao> listar()
        {
            List<Funcao> lista = new List<Funcao>();
            System.Data.DataSet ds = new System.Data.DataSet();
            Int32 x = 0;

            try
            {
                SqlDataReader reader;
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                vsql.Remove(0, vsql.Length);
                vsql.Append("SELECT ID, NOME FROM FUNCAO ");
                vsql.Append("ORDER BY NOME");
                command.CommandText = vsql.ToString();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Funcao());
                    lista[x].ID = Convert.ToInt32(reader["ID"]);
                    lista[x].Nome = reader["NOME"].ToString();
                    x++;
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao montar a lista de Funcao. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public bool verifNome(Funcao obj)
        {
            bool resultado = false;
            Int32 co;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT COUNT(NOME) AS CO FROM FUNCAO " +
                    "WHERE NOME='" + ((Funcao)obj).Nome+"' and ID="+((Funcao)obj).ID.ToString();
                co =(Int32)command.ExecuteScalar();
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
                if (verifNome((Funcao)obj))
                    throw new EInvalidObjectDAOBase("Função já cadastrada");

                result = true;
            }
            else
                result = base.validarDAO(obj);
            return result;
        }

    }
}