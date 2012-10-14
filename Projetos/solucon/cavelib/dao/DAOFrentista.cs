/// <summary>
/// Persistência de Frentista
/// </summary>


namespace Cave.DAO.Financeiro
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using System.Collections.Generic;
    using Cave.Dominio.Financeiro;
    using Cave.Dominio.Seguranca;
    using Cave.DAO.Seguranca;
    using Sigleton.Conexao;
    using Solucon.Dominio;
    using Solucon.DAO;
    using Solucon.State;


    public class DAOFrentista : DAOUsuario
    {
        public DAOFrentista()
        {

        }
        private void parser(SqlDataReader reader, ref Frentista obj)
        {
            obj.Login = reader["LOGIN"].ToString();
            obj.Nome = reader["NOME"].ToString();
            obj.Senha = reader["SENHA"].ToString();
            obj.perfil.ID = Convert.ToInt32(reader["ID_PERFIL"]);
            obj.Ativo = reader["ATIVO"].ToString();
            if (reader["ID_FORNECEDOR"].ToString() != "")
                obj.Fornecedor.ID = Int32.Parse(reader["ID_FORNECEDOR"].ToString());
            else
                obj.Fornecedor.ID = 0;
            obj.Estado = Stateobj.stLimpo;
        }

        public override bool alterar(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("UPDATE USUARIO SET ID_FORNECEDOR=" + ((Frentista)obj).Fornecedor.ID.ToString() +
                    "WHERE ID=" + ((Usuario)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar o usuário. " + e.Message);
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
                vsql.Append("UPDATE USUARIO SET ID_FORNECEDOR=null " +
                    "WHERE ID=" + ((Usuario)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar o usuário. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;
        }

        public override bool inserir(ClasseBase obj)
        {
            return alterar(obj);
        }
        public override bool buscarID(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                SqlDataReader reader;
                Frentista frentista;
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT ID,LOGIN,NOME,SENHA,ID_PERFIL,ATIVO,ID_FORNECEDOR FROM USUARIO " +
                    "WHERE ID=" + ((Usuario)obj).ID.ToString();
                reader = command.ExecuteReader();
                frentista = ((Frentista)obj);
                if (reader.Read())
                {
                    parser(reader, ref frentista);
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

        public bool buscarFrentista(Frentista obj)
        {
            bool erro = true;
            try
            {
                SqlDataReader reader;
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT ID,LOGIN,NOME,SENHA,ID_PERFIL,ATIVO,ID_FORNECEDOR FROM USUARIO " +
                    "WHERE LOGIN='" + obj.Login + "'";
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    parser(reader, ref obj);
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
        public bool validaFornecedor(ClasseBase obj)
        {
            SqlCommand command = new SqlCommand();
            Int32 co;
            bool resultado = false;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT COUNT(ID_FORNECEDOR) AS CO FROM USUARIO " +
                    "WHERE ID='" + ((Frentista)obj).ID + "' and ID_FORNECEDOR NOT IS NULL";
                co = (Int32)command.ExecuteScalar();
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
            DAOFornecedor daoFornecedor = new DAOFornecedor();
            Frentista frentista = new Frentista();
            frentista.Login = ((Usuario)obj).Login;
            bool result = false;

            if ((obj.Estado == Stateobj.stNovo || obj.Estado == Stateobj.stEditar))
            {
                if (((Frentista)obj).Login!="" && !base.buscarLogin(frentista))
                    throw new EInvalidObjectDAOBase("Usuário informado não foi encontrado");

                if (((Frentista)obj).Fornecedor.ID != 0 && !daoFornecedor.buscarID(((Frentista)obj).Fornecedor))
                    throw new EInvalidObjectDAOBase("Fornecedor/Posto informado não foi encontrado");

                result = true;
            }
            else
                result = base.validarDAO(obj);
            return result;
        }

    }
}