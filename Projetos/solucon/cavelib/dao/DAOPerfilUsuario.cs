/// <summary>
/// Classe de Persistência de Perfil de Usuário
/// </summary>

namespace Cave.DAO.Seguranca
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using System.Collections.Generic;
    using Cave.Dominio;
    using Cave.Dominio.Seguranca;
    using Sigleton.Conexao;
    using Solucon.Dominio;
    using Solucon.DAO;
    using Solucon.State;


    public class DAOPerfilUsuario : DAOBase
    {
        private SqlCommand command;

        public DAOPerfilUsuario() 
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public override bool inserir(ClasseBase obj)
        {
            return true;
        }
        public override bool alterar(ClasseBase obj)
        {
            return true;
        }
        public override bool excluir(ClasseBase obj)
        {
            return true;
        }
        public override bool buscarID(ClasseBase obj)
        {
            command = new SqlCommand();
            SqlDataReader reader;
            StringBuilder vsql = new StringBuilder();
            bool resultado = false;

            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                vsql.Append("SELECT ID, NOME FROM PERFIL_USUARIO  ");
                vsql.Append("WHERE ID="+((Perfil_Usuario)obj).ID.ToString());
                vsql.Append("ORDER BY NOME ");
                command.CommandText = vsql.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Perfil_Usuario)obj).ID = int.Parse(reader["ID"].ToString());
                    ((Perfil_Usuario)obj).Nome = reader["NOME"].ToString();
                    resultado=true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao montar a lista de perfil de usuário. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return resultado;            
        }
        public List<Perfil_Usuario> listar()
        {
            command = new SqlCommand();
            SqlDataReader reader;
            List<Perfil_Usuario> listaPerfilUsuario = new List<Perfil_Usuario>();
            StringBuilder vsql = new StringBuilder();
            Int32 x = 0;

            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                vsql.Append("SELECT ID, NOME FROM PERFIL_USUARIO  ");
                vsql.Append("ORDER BY NOME ");
                command.CommandText = vsql.ToString();
                reader=command.ExecuteReader();
                while (reader.Read())
                {
                    listaPerfilUsuario.Add(new Perfil_Usuario());
                    listaPerfilUsuario[x].ID=Convert.ToInt32(reader["ID"]);
                    listaPerfilUsuario[x].Nome=reader["NOME"].ToString();
                    x++;
                }
                return listaPerfilUsuario;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao montar a lista de perfil de usuário. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
