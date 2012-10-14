/// <summary>
/// Persistência de marca veículo
/// </summary>

namespace Cave.DAO.Veiculo
{
    using System;
    using System.Data.SqlClient;
    using System.Text;
    using System.Collections.Generic;
    using Sigleton.Conexao;
    using Solucon.Dominio;
    using Solucon.DAO;
    using Cave.Dominio.Veiculo;

    public class DAOMarca : DAOBase
    {
        private SqlCommand command;
        private StringBuilder vsql;

        public DAOMarca()
        {
            command = new SqlCommand();
            vsql = new StringBuilder();
        }

        public override bool inserir(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("INSERT INTO MARCA ");
                vsql.Append("(DESCRICAO) ");
                vsql.Append("VALUES ");
                vsql.Append("('" + ((Marca)obj).Descricao.ToUpper()+ "')");
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir a marca. " + e.Message);

            }
            finally
            {
                command.Connection.Close();
            }
            return erro;
        }
        public override bool alterar(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("UPDATE MARCA SET DESCRICAO='" + ((Marca)obj).Descricao.ToUpper() +"' "+
                    "WHERE ID=" + ((Marca)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar a marca. " + e.Message);
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
                vsql.Append("DELETE FROM MARCA WHERE ID=" + ((Marca)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir a marca. " + e.Message);
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
            try
            {
                SqlDataReader reader;
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT ID,DESCRICAO FROM MARCA " +
                    "WHERE ID=" + ((Marca)obj).ID.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Marca)obj).Descricao = reader["DESCRICAO"].ToString();
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
        public override bool validarDAO(ClasseBase obj)
        {
            bool result = false;

            if ((obj.Estado == Solucon.State.Stateobj.stNovo || obj.Estado == Solucon.State.Stateobj.stEditar))
            {
                if (verifDescricao((Marca)obj))
                    throw new EInvalidObjectDAOBase("Marca já cadastrada");

                result = true;
            }
            else
                result = base.validarDAO(obj);
            return result;
        }

        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            System.Data.DataSet ds = new System.Data.DataSet();
            Int32 x = 0;

            try
            {
                SqlDataReader reader;
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                vsql.Append("SELECT ID, DESCRICAO FROM MARCA ");
                vsql.Append("ORDER BY DESCRICAO ");
                command.CommandText = vsql.ToString();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Marca());
                    lista[x].ID = Convert.ToInt32(reader["ID"]);
                    lista[x].Descricao = reader["DESCRICAO"].ToString();
                    x++;
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao montar a lista de marca. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public bool verifDescricao(Marca obj)
        {
            Int32 co;
            bool resultado = false;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT COUNT(DESCRICAO) AS CO FROM MARCA " +
                    "WHERE DESCRICAO='" + ((Marca)obj).Descricao + "' and ID<>" + ((Marca)obj).ID.ToString();
                co = (Int32)command.ExecuteScalar();
                resultado = (co > 0);
            }
            finally
            {
                command.Connection.Close();
            }
            return resultado;
        }
    }
}