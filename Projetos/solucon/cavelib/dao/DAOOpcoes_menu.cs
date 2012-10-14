/// <summary>
/// Classe de Persistência da classe de opções de menu
/// </summary>

namespace Cave.DAO
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
        public List<Opcoes_menu> ListaMenuPerfil(Usuario obj)
        {
            List<Opcoes_menu> listaOpcoes = new List<Opcoes_menu>();
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            StringBuilder vsql = new StringBuilder();
            try
            {
                cmd.Connection = MsSQL.getConexao();
                cmd.Connection.Open();
                vsql.Append("SELECT A.ID, A.PARENT, A.NOME, A.TOOLTIP, A.URL, A.SEPARATOR, ");
                vsql.Append(" COUNT(B.ID_PERFIL_USUARIO) as CO FROM OPCOES_MENU A ");
                vsql.Append("LEFT OUTER JOIN OPCOES_MENU_PERFIL B ");
                vsql.Append("ON (B.ID_OPCAO_MENU=A.ID AND B.ID_PERFIL_USUARIO="+obj.ID.ToString()+") ");
                vsql.Append("GROUP BY A.ID, A.PARENT, A.NOME, A.TOOLTIP, A.URL, A.SEPARATOR ");
                cmd.CommandText = vsql.ToString();
                dr = cmd.ExecuteReader();
                Int32 x = 0; 
                while (dr.Read())
                {
                    listaOpcoes.Add(new Opcoes_menu());
                    listaOpcoes[x].ID = int.Parse(dr["ID"].ToString());
                    listaOpcoes[x].Nome = dr["NOME"].ToString();
                    if (!dr.IsDBNull(dr.GetOrdinal("PARENT")))
                        listaOpcoes[x].Parent = int.Parse(dr["PARENT"].ToString());
                    else
                        listaOpcoes[x].Parent = null;

                    listaOpcoes[x].Tooltip = dr["TOOLTIP"].ToString();
                    if (int.Parse(dr["CO"].ToString()) == 0)
                        listaOpcoes[x].Url = "semAcesso.aspx";
                    else
                        listaOpcoes[x].Url = dr["URL"].ToString();
                    listaOpcoes[x].Separator = Boolean.Parse(dr["SEPARATOR"].ToString());
                    x++;                
                }
                return listaOpcoes;
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível carregar a lista de opções de menu. " + e.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public DataSet ListaMenuPerfilDS(Usuario obj)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            StringBuilder vsql = new StringBuilder();
            DataRow row;
            try
            {
                cmd.Connection = MsSQL.getConexao();
                cmd.Connection.Open();
                vsql.Append("SELECT A.ID, A.PARENT, A.NOME, A.TOOLTIP, A.URL, A.SEPARATOR, ");
                vsql.Append(" COUNT(B.ID_PERFIL_USUARIO) as CO FROM OPCOES_MENU A ");
                vsql.Append("LEFT OUTER JOIN OPCOES_MENU_PERFIL B ");
                vsql.Append("ON (B.ID_OPCAO_MENU=A.ID AND B.ID_PERFIL_USUARIO=" + obj.perfil.ID.ToString() + ") ");
                vsql.Append("GROUP BY A.ID, A.PARENT, A.NOME, A.TOOLTIP, A.URL, A.SEPARATOR ");
                cmd.CommandText = vsql.ToString();
                dr = cmd.ExecuteReader();

                // da.Fill(ds, "LISTA_OPCOES");
                // Criando o DataSet;
                
                ds.Tables.Add("LISTA_OPCOES");
                ds.Tables[0].Columns.Add("ID");
                ds.Tables[0].Columns.Add("PARENT");
                ds.Tables[0].Columns.Add("NOME");
                ds.Tables[0].Columns.Add("TOOLTIP");
                ds.Tables[0].Columns.Add("URL");
                ds.Tables[0].Columns.Add("SEPARATOR");


                while (dr.Read())
                {
                    row = ds.Tables[0].NewRow();
                    row["ID"]=dr["ID"];
                    row["PARENT"]=dr["PARENT"];;
                    row["NOME"]=dr["NOME"];;
                    row["TOOLTIP"]=dr["TOOLTIP"];;
                    if (dr["PARENT"].ToString()!="" && int.Parse(dr["CO"].ToString()) == 0)
                        row["URL"] = "semAcesso.aspx";
                    else
                        row["URL"] = dr["URL"];
                    row["SEPARATOR"] = dr["SEPARATOR"];
                    ds.Tables[0].Rows.Add(row);
                }
                return ds;
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível carregar a lista de opções de menu. " + e.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

    }
}

/*
        public DataSet ListaMenuPerfil(Usuario obj)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            StringBuilder vsql = new StringBuilder();
            try
            {
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = MsSQL.getConexao();
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
*/