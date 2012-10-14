namespace CFuelCorboLib.dao.BD.security
{
    using System;
    using MySql.Data.MySqlClient;
    using System.Text;
    using System.Collections.Generic;
    using CorboLibUtils.Conexao.BD.MySQL;
    using CFuelCorboLib.dominio.security;
    using CFuelCorboLib.dao;
    using CorboLibUtils.State;
    using CorboLibUtils.Dominio;
    using CorboLibUtils.DAO;

    enum CampoBusca
    {
        ID,
        Login,
    }


    class DAOUsuario : DAOBase
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

        public DAOUsuario()
        {
            MySQL.carregaStrcnx();
            conexao = MySQL.getNewConexao();
            CriarObjetosPadrao();
        }

        public DAOUsuario(MySqlConnection pConexao)
        {
            conexao = pConexao;
            CriarObjetosPadrao();
        }

        private void bind(MySqlDataReader reader, Usuario obj)
        {
            obj.ID = Convert.ToInt32(reader["ID"].ToString());
            obj.login = reader["LOGIN"].ToString();
            obj.nome = reader["NOME"].ToString();
            obj.senha = reader["SENHA"].ToString();
            obj.administrador = reader["ADMINISTRADOR"].ToString()=="S";
        }

        private void SelectPadrao()
        {
            vsql.Remove(0, vsql.Length);
            vsql.Append("SELECT ID");
            vsql.Append(",LOGIN");
            vsql.Append(",NOME");
            vsql.Append(",SENHA");
            vsql.Append(",ADMINISTRADOR");
            vsql.Append("FROM TB_USUARIO ");
            command.CommandText = vsql.ToString();
        }

        public override bool inserir(CorboLibUtils.Dominio.ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("INSERT INTO TB_USUARIO ");
                vsql.Append("(LOGIN,");
                vsql.Append("NOME,");
                vsql.Append("SENHA,");
                vsql.Append("ADMINISTRADOR,");
                vsql.Append("VALUES ");
                vsql.Append("('");
                vsql.Append(((Usuario)obj).login + "','");
                vsql.Append(((Usuario)obj).nome + "','");
                vsql.Append(((Usuario)obj).senha + "','");
                vsql.Append(((Usuario)obj).administrador + "')");

                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir o usuario. " + e.Message);
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
                vsql.Append("UPDATE TB_USUARIO ");
                vsql.Append("SET LOGIN = '" + ((Usuario)obj).login + "'");
                vsql.Append(",NOME = '" + ((Usuario)obj).nome + "'");
                vsql.Append(",SENHA = '" + ((Usuario)obj).senha + "'");
                vsql.Append(",ADMINISTRADOR = '" + ((Usuario)obj).administrador + "'");
                vsql.Append("WHERE ID=" + ((Usuario)obj).ID);
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

        public override bool excluir(CorboLibUtils.Dominio.ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("DELETE FROM TB_USUARIO WHERE ID=" + ((Usuario)obj).ID);
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

        private bool buscar(Usuario pUsuario, CampoBusca pCampoBusca)
        {
            MySqlDataReader reader;
            Usuario usuario;
            bool erro = true;
            try
            {
                command.Connection.Open();
                SelectPadrao();

                if (pCampoBusca==CampoBusca.ID)
                    vsql.Append("WHERE ID=" + pUsuario.ID.ToString());
                else if (pCampoBusca == CampoBusca.Login)
                   vsql.Append("WHERE LOGIN='" + pUsuario.login.ToString());
                
                command.CommandText = vsql.ToString();
                
                reader = command.ExecuteReader();
                
                usuario = pUsuario;
                
                if (reader.Read())
                {
                    bind(reader, usuario);
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
            return buscar((Usuario)obj, CampoBusca.ID);
        }

        public bool buscarLogin(CorboLibUtils.Dominio.ClasseBase obj)
        {
            return buscar((Usuario)obj, CampoBusca.Login);
        }

        public bool verifLogin(Usuario obj)
        {
            Int32 co;
            bool resultado = false;
            try
            {
                command.Connection.Open();
                command.CommandText = "SELECT COUNT(LOGIN) AS CO FROM TB_USUARIO " +
                    "WHERE ID<>" + obj.ID.ToString() + " and LOGIN='" + obj.login + "'";
                co = (Int32)command.ExecuteScalar();
                resultado = (co > 0);
            }
            finally
            {
                command.Connection.Close();
            }
            return resultado;
        }

        public int validarLogin(Usuario pUsuario)
        {
            int erro = 0;
            Usuario usuario = new Usuario();
            usuario.login = pUsuario.login;
            usuario.senha = pUsuario.senha;

            if (usuario.login == "")
            {
                erro = 1; // Login não informado;
            }
            if (usuario.senha == "")
            {
                erro = 2; // Senha não informada;
            }
            if (buscarLogin(pUsuario))
            {
                if (usuario.senha != pUsuario.senha)
                {
                    erro = 3; // Senha incorreta;
                }
            }
            else
            {
                erro = 4; // Login não encontrado;
            }
            return erro;
        }

        public List<Usuario> listar()
        {
            MySqlDataReader reader;
            List<Usuario> listaUsuario = new List<Usuario>();
            Usuario usuario;

            try
            {
                command.Connection.Open();
                vsql.Append("SELECT ID,LOGIN,NOME,SENHA,ADMINISTRADOR FROM TB_USUARIO ");
                vsql.Append("ORDER BY NOME ");
                command.CommandText = vsql.ToString();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.ID = Convert.ToInt32(reader["ID"]);
                    usuario.login = reader["LOGIN"].ToString();
                    usuario.nome = reader["NOME"].ToString();
                    usuario.senha = reader["SENHA"].ToString();
                    usuario.administrador = reader["ADMINISTRADOR"].ToString() == "S";
                    listaUsuario.Add(usuario);
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


    }
}
