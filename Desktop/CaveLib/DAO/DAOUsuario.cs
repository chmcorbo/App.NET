namespace cave.DAO
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using cave.dominio;
    using Sigleton.Conexao;
    using solucon.dominio;
    using solucon.DAO;
    using solucon.state;

    /// <summary>
    /// Classe de Persistência da classe de usuário
    /// </summary>

    public class DAOUsuario : DAOBase
    {
        public DAOUsuario()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public override bool inserir(ClasseBase obj)
        {
            SqlCommand command = new SqlCommand();
            StringBuilder vsql = new StringBuilder();
            bool erro = true;
            try
            {
                vsql.Append("INSERT INTO USUARIO ");
                vsql.Append("(LOGIN,NOME,SENHA,ATIVO,ID_PERFIL) ");
                vsql.Append("VALUES ");
                vsql.Append("('" + ((Usuario)obj).Login + "','" + ((Usuario)obj).Nome +
                    "','" + ((Usuario)obj).Senha + "','" + ((Usuario)obj).Ativo + "'," +
                    ((Usuario)obj).perfil.ID.ToString() + ")");
                command.Connection = SigletonCnxSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir registro do usuário. " + e.Message);

            }
            finally 
            {
                command.Connection.Close();
            }
            return erro;
        }
        public override bool alterar(ClasseBase obj)
        {
            SqlCommand command = new SqlCommand();
            StringBuilder vsql = new StringBuilder();
            bool erro = true;
            try
            {
                vsql.Append("UPDATE USUARIO SET LOGIN='" + ((Usuario)obj).Login +
                    "', NOME='" + ((Usuario)obj).Nome + "', SENHA='" + ((Usuario)obj).Senha+
                    "', ATIVO='" + ((Usuario)obj).Ativo + "', ID_PERFIL=" + ((Usuario)obj).perfil.ID.ToString()+" "+
                    "WHERE ID=" + ((Usuario)obj).ID);
                command.Connection = SigletonCnxSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar registro do usuário. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;
        }
        public override bool excluir(ClasseBase obj)
        {
            SqlCommand command = new SqlCommand();
            StringBuilder vsql = new StringBuilder();
            bool erro = true;
            try
            {
                vsql.Append("DELETE FROM USUARIO WHERE ID=" + ((Usuario)obj).ID);
                command.Connection = SigletonCnxSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir registro do usuário. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;
        }
        public override bool buscarID(ClasseBase obj)
        {
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            bool erro = true;
            try
            {
                command.Connection = SigletonCnxSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT ID,LOGIN,NOME,SENHA,ID_PERFIL,ATIVO FROM USUARIO " +
                    "WHERE ID=" + ((Usuario)obj).ID.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Usuario)obj).Login = reader["LOGIN"].ToString();
                    ((Usuario)obj).Nome = reader["NOME"].ToString();
                    ((Usuario)obj).Senha = reader["SENHA"].ToString();
                    ((Usuario)obj).perfil.ID = Convert.ToInt32(reader["ID"]);
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
        public bool buscarLogin(ClasseBase obj)
        {
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            bool erro = true;
            try
            {
                command.Connection = SigletonCnxSQL.getConexao();
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
        public int validarLogin(ClasseBase obj)
        {
            int erro = 0;
            Usuario usuario = new Usuario();
            usuario.Login=((Usuario)obj).Login;
            usuario.Senha=((Usuario)obj).Senha;

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
                if (usuario.Senha != ((Usuario)obj).Senha)
                {
                    erro = 3; // Senha incorreta;
                }
                else if (((Usuario)obj).Ativo != "S")
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
    }
}