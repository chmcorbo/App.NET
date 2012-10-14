/// <summary>
/// Persistência de abastecimento
/// </summary>

namespace Cave.DAO.Abastecimento
{
    using System;
    using System.Data.SqlClient;
    using System.Text;
    using Cave.DAO.Financeiro;
    using Cave.DAO.RH;
    using Cave.DAO.Veiculo;
    using Cave.Dominio.Abastecimento;
    using Cave.Dominio.RH;
    using Sigleton.Conexao;
    using Solucon.DAO;
    using Solucon.Dominio;
    using Solucon.State;

    public class DAOAbastecimento : DAOBase
    {
        private SqlCommand command;
        private StringBuilder vsql;

        public DAOAbastecimento()
        {
            command = new SqlCommand();
            vsql = new StringBuilder();
        }

        public override bool inserir(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("INSERT INTO ABASTECIMENTO ");
                vsql.Append("(ID_VEICULO,");
                vsql.Append("ID_FORNECEDOR,");
                vsql.Append("ID_FUNCIONARIO,");
                vsql.Append("DATA_ABASTEC,");
                vsql.Append("KM,");
                vsql.Append("QUANTIDADE,");
                vsql.Append("PRECO,");
                vsql.Append("ID_COMBUSTIVEL)");
                vsql.Append("VALUES ( ");
                vsql.Append(((Abastecimento)obj).Veiculo.ID.ToString() + ",");
                vsql.Append(((Abastecimento)obj).Fornecedor.ID.ToString() + ",");
                vsql.Append(((Abastecimento)obj).Funcionario.ID.ToString() + ",");
                vsql.Append("'"+((Abastecimento)obj).Dt_abastec.ToString("MM/dd/yyyy") + "',");
                vsql.Append(((Abastecimento)obj).Km.ToString() + ",");
                vsql.Append(((Abastecimento)obj).Quantidade.ToString() + ",");
                vsql.Append(((Abastecimento)obj).Preco.ToString().Replace(',', '.') + ",");
                vsql.Append(((Abastecimento)obj).Tipo_Combustivel.ID.ToString() + ")");
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir o lançamento de abastecimento. " + e.Message);
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
                vsql.Append("UPDATE ABASTECIMENTO ");
                vsql.Append("SET ID_VEICULO = " + ((Abastecimento)obj).Funcionario.ID.ToString());
                vsql.Append(",ID_FORNECEDOR = " + ((Abastecimento)obj).Fornecedor.ID.ToString());
                vsql.Append(",ID_FUNCIONARIO = " + ((Abastecimento)obj).Funcionario.ID.ToString());
                vsql.Append(",DATA_ABASTEC = '" + ((Abastecimento)obj).Dt_abastec.ToString());
                vsql.Append("',KM = " + ((Abastecimento)obj).Km.ToString());
                vsql.Append(",QUANTIDADE = " + ((Abastecimento)obj).Quantidade.ToString());
                vsql.Append(",PRECO = " + ((Abastecimento)obj).Preco.ToString().Replace(',', '.'));
                vsql.Append(",ID_COMBUSTIVEL = " + ((Abastecimento)obj).Tipo_Combustivel.ID.ToString());
                vsql.Append(" WHERE ID=" + ((Abastecimento)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar o lançamento do abastecimento. " + e.Message);
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
                vsql.Append("DELETE FROM ABASTECIMENTO WHERE ID=" + ((Abastecimento)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir a lançamento de abastecimento. " + e.Message);
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
                vsql.Append("SELECT ID,ID_VEICULO,ID_FORNECEDOR,ID_FUNCIONARIO,DATA_ABASTEC,KM,QUANTIDADE,PRECO FROM ABASTECIMENTO ");
                vsql.Append("WHERE ID=" + ((Abastecimento)obj).ID.ToString());
                command.CommandText = command.CommandText + vsql.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ((Abastecimento)obj).Veiculo.ID = Convert.ToInt32(reader["ID_VEICULO"]);
                    ((Abastecimento)obj).Fornecedor.ID = Convert.ToInt32(reader["ID_FORNECEDOR"]);                    
                    ((Abastecimento)obj).Funcionario.ID = Convert.ToInt32(reader["ID_FUNCIONARIO"]);
                    ((Abastecimento)obj).Dt_abastec = Convert.ToDateTime(reader["DATA_ABASTEC"]);
                    ((Abastecimento)obj).Km = Convert.ToInt32(reader["KM"]);
                    ((Abastecimento)obj).Quantidade = Convert.ToDouble(reader["QUANTIDADE"]);
                    ((Abastecimento)obj).Quantidade = Convert.ToDouble(reader["PRECO"]);
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
        public Double verifAbastecido(Funcionario obj, Int32 pmes, Int32 pano)
        {
            SqlDataReader reader;
            Double qtde_abastecido;

            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                vsql.Append("SELECT SUM(QUANTIDADE) as QUANTIDADE FROM ABASTECIMENTO ");
                vsql.Append("WHERE ID_FUNCIONARIO= "+obj.ID.ToString());
                vsql.Append(" AND MONTH(DATA_ABASTEC)=" + pmes.ToString());
                vsql.Append(" AND YEAR(DATA_ABASTEC)=" + pano.ToString());
                command.CommandText = command.CommandText + vsql.ToString();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    qtde_abastecido = Convert.ToInt32(((reader["QUANTIDADE"].ToString()=="")?0:reader["QUANTIDADE"]));
                }
                else
                {
                    qtde_abastecido = 0;
                }
            }
            finally
            {
                command.Connection.Close();
            }
            return qtde_abastecido;
        }

        public Double verifSaldo(Funcionario obj, Int32 pMes, Int32 pAno)
        {
            DAOCota_mensal daoCota_mensal = new DAOCota_mensal();
            DAOCota_extra daoCota_extra = new DAOCota_extra();
            Int32 vcota_mensal;
            Int32 vcota_extra;
            Double vqtde_abastecido;
            Int32 vresultado;
 
            vcota_mensal = daoCota_mensal.verifCota(obj.ID,pMes,pAno);
            vcota_extra = daoCota_extra.verifCotaextra(obj,pMes,pAno);
            vqtde_abastecido = verifAbastecido(obj, pMes, pAno);
            vresultado=((vcota_mensal+vcota_extra)-Convert.ToInt32(vqtde_abastecido));

            return vresultado;
        }

        public override bool validarDAO(ClasseBase obj)
        {
            DAOVeiculo daoVeiculo = new DAOVeiculo();
            DAOFuncionario daoFuncionario = new DAOFuncionario();
            DAOFornecedor daoFornecedor = new DAOFornecedor();

            bool result = false;

            if ((obj.Estado == Stateobj.stNovo || obj.Estado == Stateobj.stEditar))
            {
                if (((Abastecimento)obj).Veiculo.Placa != "" && !daoVeiculo.buscarPlaca(((Abastecimento)obj).Veiculo))
                    throw new EInvalidObjectDAOBase("Veículo informado não é válido");
                
                if (((Abastecimento)obj).Funcionario.Matricula != "" && !daoFuncionario.buscarMatricula(((Abastecimento)obj).Funcionario))
                    throw new EInvalidObjectDAOBase("Funcionário informado não é válido");
                
                if (((Abastecimento)obj).Fornecedor.Razao_social != "" && !daoFornecedor.buscarID(((Abastecimento)obj).Fornecedor))
                    throw new EInvalidObjectDAOBase("Fornecedor / Posto informado não é válido");
                
                /* 
                 * A validação ficará por conta da interface.
                if (verifSaldo(((Abastecimento)obj).Funcionario,
                   ((Abastecimento)obj).Dt_abastec.Month, ((Abastecimento)obj).Dt_abastec.Year) < ((Abastecimento)obj).Quantidade)
                    throw new EInvalidObjectDAOBase("Saldo do funcionário não é suficiente para fazer esse abastecimento");
                */

                result = true;
            }
            else
                result = base.validarDAO(obj);
            return result;
        }

    }
}
