namespace cave.DAO
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using System.Collections.Generic;
    using cave.dominio;
    using Sigleton.Conexao;
    using solucon.dominio;
    using solucon.DAO;
    using solucon.state;

    /// <summary>
    /// Classe de Persistência de Perfil de Usuário
    /// </summary>


    public class DAOPerfilUsuario : DAOBase
    {

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
            return true;
        }
        public List<Perfil_Usuario> ListarTudo()
        {
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            List<Perfil_Usuario> listaPerfilUsuario = new List<Perfil_Usuario>();
            StringBuilder vsql = new StringBuilder();
            Int32 x = 0;

            try
            {
                command.Connection = SigletonCnxSQL.getConexao();
                command.Connection.Open();
                vsql.Append("SELECT ID, NOME FROM TB_PERFIL_USUARIO  ");
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
