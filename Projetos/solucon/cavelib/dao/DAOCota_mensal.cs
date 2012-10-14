/// <summary>
/// Persistência de Cota Mensal
/// </summary>

namespace Cave.DAO.Abastecimento
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Text;
    using System.Linq;
    using System.Web;
    using Sigleton.Conexao;
    using Solucon.Dominio;
    using Solucon.State;
    using Solucon.DAO;
    using Cave.Dominio.Abastecimento;
    using Cave.Dominio.RH;

    public class DAOCota_mensal : DAOBase
    {
        // fields;
        private SqlCommand command;
        private StringBuilder vsql;
        // Métodos
        public DAOCota_mensal()
        {
            command = new SqlCommand();
            vsql = new StringBuilder();
        }


        public override bool alterar(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Remove(0, vsql.Length);
                vsql.Append("UPDATE COTA_MENSAL ");
                vsql.Append("SET ID_FUNCIONARIO = " + ((Cota_mensal)obj).Funcionario.ID.ToString());
                vsql.Append(",MES = " + ((Cota_mensal)obj).Mes.ToString());
                vsql.Append(",ANO = " + ((Cota_mensal)obj).Ano.ToString());
                vsql.Append(",QUANTIDADE = " + ((Cota_mensal)obj).Qtde.ToString());
                vsql.Append("WHERE ID=" + ((Cota_mensal)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar a cota mensal do funcionário. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;

        }

        public override bool buscarID(ClasseBase obj)
        {
            SqlDataReader reader;
            bool erro = true;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                vsql.Append("SELECT ID,ID_FUNCIONARIO,MES,ANO,QUANTIDADE FROM COTA_MENSAL");
                vsql.Append(" WHERE ID=" + ((Cota_mensal)obj).ID.ToString());
                command.CommandText = command.CommandText + vsql.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Cota_mensal)obj).Funcionario.ID = Convert.ToInt32(reader["ID_FUNCIONARIO"]);
                    ((Cota_mensal)obj).Mes = Convert.ToInt32(reader["MES"]);
                    ((Cota_mensal)obj).Ano = Convert.ToInt32(reader["ANO"]);
                    ((Cota_mensal)obj).Qtde = Convert.ToInt32(reader["QUANTIDADE"]);
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

        public override bool excluir(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("DELETE FROM COTA_MENSAL WHERE ID=" + ((Cota_mensal)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir a cota mensal desse funcionário. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;
            
        }

        public override bool inserir(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Remove(0, vsql.Length);
                vsql.Append("INSERT INTO COTA_MENSAL ");
                vsql.Append("(ID_FUNCIONARIO,");
                vsql.Append("MES,");
                vsql.Append("ANO,");
                vsql.Append("QUANTIDADE)");
                vsql.Append("VALUES ");
                vsql.Append("("+((Cota_mensal)obj).Funcionario.ID.ToString() + ",");
                vsql.Append(((Cota_mensal)obj).Mes.ToString() + ",");
                vsql.Append(((Cota_mensal)obj).Ano.ToString() + ",");
                vsql.Append(((Cota_mensal)obj).Qtde.ToString() + ")");
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir a cota mensal do funcionário. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
            return erro;

        }
        public Int32 verifCota(Int32 pID_funcionario, Int32 pMes, Int32 pAno)
        {
            SqlDataReader reader;
            Int32 resultado;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT SUM(QUANTIDADE) AS QUANTIDADE FROM COTA_MENSAL " +
                    "WHERE ID_FUNCIONARIO=" + pID_funcionario.ToString() + 
                    " AND MES="+pMes.ToString()+
                    " AND ANO="+pAno.ToString();

                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["QUANTIDADE"].ToString()=="")
                        resultado = 0;
                    else
                        resultado= Convert.ToInt32(reader["QUANTIDADE"]);
                }
                else
                {
                    resultado = 0;
                }
            }
            finally
            {
                command.Connection.Close();
            }
            return resultado;
        }
        public override bool validarDAO(ClasseBase obj)
        {
            bool result = false;

            if ((obj.Estado == Stateobj.stNovo || obj.Estado == Stateobj.stEditar))
            {
                if (verifCota(((Cota_mensal)obj).Funcionario.ID, ((Cota_mensal)obj).Mes,((Cota_mensal)obj).Ano) > 0)
                    throw new EInvalidObjectDAOBase("Já existe uma cota mensal definida para esse funcionário.");

                result = true;
            }
            else if (obj.Estado == Stateobj.stExcluir)
            {
                DAOAbastecimento daoAbastecimento = new DAOAbastecimento();
                Double saldo = daoAbastecimento.verifSaldo(((Cota_mensal)obj).Funcionario, ((Cota_mensal)obj).Mes, ((Cota_mensal)obj).Ano);
                if ((saldo-((Cota_mensal)obj).Qtde)<0) 
                {
                    throw new EInvalidObjectDAOBase("Eliminação dessa cota mensal provocará saldo negativo.");
                }
                result = true;
            }

            return result;
        }
        public List<Funcionario> listFuncCota(Funcionario obj, Int16 pMes, Int16 pAno)
        {
            SqlDataReader reader;
            List<Funcionario> listaFuncCota = new List<Funcionario>();
            Int32 x = 0;
            String conteudo;

            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                vsql.Append("SELECT A.ID,A.MATRICULA,A.NOME,A.ID_FUNCAO,B.NOME as NOME_FUNCAO FROM FUNCIONARIO A  ");
                vsql.Append("LEFT OUTER JOIN FUNCAO B ON (B.ID=A.ID_FUNCAO) ");
                vsql.Append("WHERE A.ID NOT IN (SELECT C.ID_FUNCIONARIO FROM COTA_MENSAL C ");
                vsql.Append("WHERE C.ID_FUNCIONARIO=A.ID AND C.MES=" + pMes.ToString() + " AND C.ANO=" + pAno.ToString() + ") ");
                vsql.Append(" and A.DATA_DEMISSAO IS NULL ");
                if (obj.Matricula != "")
                {
                    conteudo = obj.Matricula.ToUpper();
                    vsql.Append(" and (A.MATRICULA = '" + conteudo + "')");
                }

                if (obj.Nome != "")
                {
                    conteudo = "%" + obj.Nome.ToUpper() + "%";
                    vsql.Append(" and (A.NOME LIKE '" + conteudo + "')");
                }
                if (obj.ID != 0)
                {
                    conteudo = obj.ID.ToString();
                    vsql.Append(" and (B.ID = " + conteudo + ")");
                }
                vsql.Append("ORDER BY A.NOME");
                command.CommandText = vsql.ToString();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listaFuncCota.Add(new Funcionario());
                    listaFuncCota[x].ID = Convert.ToInt32(reader["ID"]);
                    listaFuncCota[x].Matricula = reader["MATRICULA"].ToString();
                    listaFuncCota[x].Nome = reader["NOME"].ToString();
                    listaFuncCota[x].Funcao.ID = Convert.ToInt32(reader["ID_FUNCAO"].ToString());
                    listaFuncCota[x].Funcao.Nome = reader["NOME_FUNCAO"].ToString();
                    x++;
                }
                return listaFuncCota;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao montar a lista de cota de combustível. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}