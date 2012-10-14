/// <summary>
/// Persistência de marca de veículo
/// </summary>


namespace Cave.DAO.Veiculo
{
    using System;
    using System.Data.SqlClient;
    using System.Text;
    using System.Collections.Generic;
    using Cave.Dominio.Veiculo;
    using Sigleton.Conexao;
    using Solucon.Dominio;
    using Solucon.DAO;

    public class DAOModelo : DAOBase
    {
        private SqlCommand command;
        private StringBuilder vsql;

        public DAOModelo()
        {
            command = new SqlCommand();
            vsql = new StringBuilder();
        }

        public override bool inserir(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("INSERT INTO MODELO ");
                vsql.Append("(DESCRICAO,ID_MARCA) ");
                vsql.Append("VALUES ");
                vsql.Append("('" + ((Modelo)obj).Descricao.ToUpper() + "',"+
                    ((Modelo)obj).Marca.ID.ToString() + ")");
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir o modelo. " + e.Message);

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
                vsql.Append("UPDATE MODELO SET DESCRICAO='" + 
                    ((Modelo)obj).Descricao.ToUpper() + "', "+
                    "ID_MARCA=" +((Modelo)obj).Marca.ID.ToString()+
                    "WHERE ID=" + ((Modelo)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar o modelo. " + e.Message);
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
                vsql.Append("DELETE FROM MODELO WHERE ID=" + ((Modelo)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir modelo. " + e.Message);
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
                command.CommandText = "SELECT ID,DESCRICAO,ID_MARCA FROM MODELO " +
                    "WHERE ID=" + ((Modelo)obj).ID.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Modelo)obj).Descricao = reader["DESCRICAO"].ToString();
                    ((Modelo)obj).Marca.ID = Convert.ToInt32(reader["ID_MARCA"]);
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
                if (verifDescricao((Modelo)obj))
                    throw new EInvalidObjectDAOBase("Modelo já cadastrado");

                result = true;
            }
            else
                result = base.validarDAO(obj);
            return result;
        }

        public List<Modelo> listar(Marca obj)
        {
            SqlDataReader reader;
            List<Modelo> lista = new List<Modelo>();
            Int32 x = 0;

            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                vsql.Append("SELECT ID, DESCRICAO, ID_MARCA FROM MODELO ");
                vsql.Append("WHERE ID_MARCA=" + obj.ID);
                vsql.Append("ORDER BY DESCRICAO ");
                command.CommandText = vsql.ToString();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Modelo());
                    lista[x].ID = Convert.ToInt32(reader["ID"]);
                    lista[x].Descricao = reader["DESCRICAO"].ToString();
                    lista[x].Marca.ID = Convert.ToInt32(reader["ID_MARCA"]);
                    x++;
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao montar a lista de modelo. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public bool verifDescricao(Modelo obj)
        {
            Int32 co;
            bool resultado = false;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT COUNT(DESCRICAO) AS CO FROM MODELO " +
                    "WHERE DESCRICAO='" + obj.Descricao + "' and ID<>" + obj.ID.ToString();
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



