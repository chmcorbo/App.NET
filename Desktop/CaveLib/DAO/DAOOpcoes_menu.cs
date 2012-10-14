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

    /// <summary>
    /// Classe de Persistência da classe de opções de menu
    /// </summary>

    public class DAOOpcoes_menu_perfil : DAOBase
    {

        public DAOOpcoes_menu_perfil()
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
        public DataSet ListaMenuPerfil(Usuario obj)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            StringBuilder vsql = new StringBuilder();
            try
            {
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = SigletonCnxSQL.getConexao();
                da.SelectCommand.Connection.Open();
                vsql.Append("SELECT A.OM_CP_OPCAO_MENU, A.OM_CP_PARENT, A.OM_NOME, A.OM_TOOL_TIP, ");
                vsql.Append("A.OM_URL, A.OM_SEPARATOR FROM OPCOES_MENU A ");
                vsql.Append("Inner Join OPCOES_MENU_PERFIS B ");
                vsql.Append("On (B.OM_CP_OPCAO_MENU=A.OM_CP_OPCAO_MENU) ");
                vsql.Append("Where B.PU_CP_PERFIL_USUARIO=" + obj.perfil.ID);
                vsql.Append("Order By A.OM_CP_OPCAO_MENU");
                da.SelectCommand.CommandText = vsql.ToString();
                da.Fill(ds, "OPCOES_MENU");
                return ds;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir registro do usuário. " + e.Message);
            }
            finally
            {
                da.SelectCommand.Connection.Close();
            }
        }
    }
}