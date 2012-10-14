/// <summary>
/// Persistência da classe de usuário
/// </summary>

namespace Cave.DAO.Seguranca
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Text;
    using Sigleton.Conexao;
    using Cave.Dominio.Seguranca;
    using Solucon.Dominio;
    using Solucon.DAO;
    using Solucon.State;

    public class DAOUsuario : DAOBase
    {

        protected SqlCommand command;
        protected StringBuilder vsql;
        
        private void parser(SqlDataReader reader, ref Usuario obj)
        {
            obj.Login = reader["LOGIN"].ToString();
            obj.Nome = reader["NOME"].ToString();
            obj.Senha = reader["SENHA"].ToString();
            obj.perfil.ID = Convert.ToInt32(reader["ID_PERFIL"]);
            obj.Ativo = reader["ATIVO"].ToString();
            obj.Estado = Stateobj.stLimpo;
        }

        public DAOUsuario()
        {
            command = new SqlCommand();
            vsql = new StringBuilder();
        }
        public override bool inserir(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("INSERT INTO USUARIO ");
                vsql.Append("(LOGIN,NOME,SENHA,ATIVO,ID_PERFIL) ");
                vsql.Append("VALUES ");
                vsql.Append("('" + ((Usuario)obj).Login.ToLower() + "','" + ((Usuario)obj).Nome.ToUpper() +
                    "','" + ((Usuario)obj).Senha + "','" + ((Usuario)obj).Ativo + "'," +
                    ((Usuario)obj).perfil.ID.ToString() + ")");
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir o usuário. " + e.Message);

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
                vsql.Append("UPDATE USUARIO SET LOGIN='" + ((Usuario)obj).Login.ToLower() +
                    "', NOME='" + ((Usuario)obj).Nome.ToUpper() + "', SENHA='" + ((Usuario)obj).Senha+
                    "', ATIVO='" + ((Usuario)obj).Ativo.ToUpper() + "', ID_PERFIL=" + ((Usuario)obj).perfil.ID.ToString() + " " +
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
                vsql.Append("DELETE FROM USUARIO WHERE ID=" + ((Usuario)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir o usuário. " + e.Message);
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
                Usuario usuario;
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT ID,LOGIN,NOME,SENHA,ID_PERFIL,ATIVO FROM USUARIO " +
                    "WHERE ID=" + ((Usuario)obj).ID.ToString();
                reader = command.ExecuteReader();
                usuario = ((Usuario)obj);
                if (reader.Read())
                {
                    parser(reader, ref usuario);
                }
                else
                {
                    erro=false;
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

            if ((obj.Estado == Stateobj.stNovo || obj.Estado == Stateobj.stEditar))
            {
                if (verifLogin((Usuario)obj))
                    throw new EInvalidObjectDAOBase("Login já cadastrado");

                result = true;
            }
            else
                result = base.validarDAO(obj);
            return result;
        }

        public bool buscarLogin(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                SqlDataReader reader;
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT ID,LOGIN,NOME,SENHA,ID_PERFIL,ATIVO FROM USUARIO " +
                    "WHERE LOGIN='" + ((Usuario)obj).Login+"'";
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Usuario)obj).ID = Convert.ToInt32(reader["ID"]);
                    ((Usuario)obj).Nome = reader["NOME"].ToString();
                    ((Usuario)obj).Senha = reader["SENHA"].ToString();
                    ((Usuario)obj).perfil.ID = Convert.ToInt32(reader["ID_PERFIL"]);
                    ((Usuario)obj).Ativo = reader["ATIVO"].ToString();
                    ((Usuario)obj).Estado = Stateobj.stLimpo;
                }
                else
                {
                    erro=false;
                }
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;
        }
        public bool verifLogin(Usuario obj)
        {
            Int32 co;
            bool resultado = false;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT COUNT(LOGIN) AS CO FROM USUARIO " +
                    "WHERE ID<>" + obj.ID.ToString() + " and LOGIN='" + obj.Login+"'";
                co = (Int32)command.ExecuteScalar();
                resultado = (co > 0);
            }
            finally
            {
                command.Connection.Close();
            }
            return resultado;
        }
        public int validarLogin(Usuario obj)
        {
            int erro = 0;
            Usuario usuario = new Usuario();
            usuario.Login=obj.Login;
            usuario.Senha=obj.Senha;

            if (usuario.Login == "")
            { 
                erro = 1; // Login não informado;
            }
            if (usuario.Senha == "")
            {
                erro = 2; // Senha não informada;
            }
            if (buscarLogin(obj))
            {
                if (usuario.Senha != obj.Senha)
                {
                    erro = 3; // Senha incorreta;
                }
                else if (obj.Ativo != "S")
                {
                    erro = 4; // Usuário inativo;
                }

            }
            else
            {
                erro = 5; // Login não encontrado;
            }
            return erro;
        }
        public List<Usuario> listar()
        {
            SqlDataReader reader;
            List<Usuario> listaUsuario = new List<Usuario>();
            Int32 x = 0;

            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                vsql.Append("SELECT A.ID, A.LOGIN, A.NOME FROM USUARIO A ");
                vsql.Append("ORDER BY A.NOME ");
                command.CommandText = vsql.ToString();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listaUsuario.Add(new Usuario());
                    listaUsuario[x].ID = Convert.ToInt32(reader["ID"]);
                    listaUsuario[x].Login = reader["LOGIN"].ToString();
                    listaUsuario[x].Nome = reader["NOME"].ToString();
                    x++;
                }
                return listaUsuario;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao montar a lista de usuários. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}