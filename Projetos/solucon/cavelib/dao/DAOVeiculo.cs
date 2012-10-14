/// <summary>
/// Persistência de veículo
/// </summary>

namespace Cave.DAO.Veiculo
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using System.Collections.Generic;
    using Cave.Dominio;
    using Cave.Dominio.Veiculo;
    using Sigleton.Conexao;
    using Solucon.Dominio;
    using Solucon.DAO;
    using Solucon.State;

    public class DAOVeiculo : DAOBase
    {
        private SqlCommand command;
        private StringBuilder vsql;

        public DAOVeiculo()
        {
            //
            // TODO: Add constructor logic here
            //
            command = new SqlCommand();
            vsql = new StringBuilder();
        }
        private void parserReaderObj(SqlDataReader reader, Veiculo obj) 
        {
            obj.ID = Convert.ToInt32(reader["ID"].ToString());
            obj.Placa = reader["PLACA"].ToString();
            obj.Num_chassi = reader["NUM_CHASSI"].ToString();
            obj.Cor = reader["COR"].ToString();
            obj.Num_portas = Convert.ToInt16(reader["NUM_PORTAS"]);
            obj.Cod_renavam = reader["COD_RENAVAM"].ToString();
            obj.Ano_fab = Convert.ToInt16(reader["ANO_FAB"]);
            obj.Ano_mod = Convert.ToInt16(reader["ANO_MOD"]);
            obj.Cidade = reader["CIDADE"].ToString();
            obj.UF = reader["UF"].ToString();
            obj.Litros_tanque = Convert.ToInt16(reader["LITROS_TANQUE"]);
            obj.Modelo.ID = Convert.ToInt32(reader["ID_MODELO"]);
        }
        private void SelectPadrao(StringBuilder vsql, ref SqlCommand command)
        {
            vsql.Remove(0, vsql.Length);
            vsql.Append("SELECT ID");
            vsql.Append(",PLACA");
            vsql.Append(",NUM_CHASSI");
            vsql.Append(",COR");
            vsql.Append(",NUM_PORTAS");
            vsql.Append(",COD_RENAVAM");
            vsql.Append(",ANO_FAB");
            vsql.Append(",ANO_MOD");
            vsql.Append(",CIDADE");
            vsql.Append(",UF");
            vsql.Append(",LITROS_TANQUE");
            vsql.Append(",ID_MODELO ");
            vsql.Append("FROM VEICULO ");
            command.CommandText = vsql.ToString();
        }

        public override bool inserir(ClasseBase obj)
        {
            bool erro = true;
            try
            {
                vsql.Append("INSERT INTO VEICULO ");
                vsql.Append("(PLACA,");
                vsql.Append("NUM_CHASSI,");
                vsql.Append("COR,");
                vsql.Append("NUM_PORTAS,");
                vsql.Append("COD_RENAVAM,");
                vsql.Append("ANO_FAB,");
                vsql.Append("ANO_MOD,");
                vsql.Append("CIDADE,");
                vsql.Append("UF,");
                vsql.Append("LITROS_TANQUE,");
                vsql.Append("ID_MODELO)");
                vsql.Append("VALUES ");
                vsql.Append("('" +((Veiculo)obj).Placa + "',");
                vsql.Append("'" +((Veiculo)obj).Num_chassi + "',");
                vsql.Append("'" +((Veiculo)obj).Cor + "',");
                vsql.Append(((Veiculo)obj).Num_portas + ",");
                vsql.Append("'" +((Veiculo)obj).Cod_renavam + "',");
                vsql.Append(((Veiculo)obj).Ano_fab + ",");
                vsql.Append(((Veiculo)obj).Ano_mod + ",");
                vsql.Append("'" +((Veiculo)obj).Cidade + "',");
                vsql.Append("'" +((Veiculo)obj).UF + "',");
                vsql.Append(((Veiculo)obj).Litros_tanque + ",");
                vsql.Append(((Veiculo)obj).Modelo.ID.ToString() + ")");
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao inserir o veículo. " + e.Message);

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
                vsql.Append("UPDATE VEICULO ");
                vsql.Append("SET PLACA = '"+((Veiculo)obj).Placa+"'");
                vsql.Append(",NUM_CHASSI = '"+((Veiculo)obj).Num_chassi+"'");
                vsql.Append(",COR = '"+((Veiculo)obj).Cor+"'");
                vsql.Append(",NUM_PORTAS = '"+((Veiculo)obj).Num_portas+"'");
                vsql.Append(",COD_RENAVAM = '"+((Veiculo)obj).Cod_renavam+"'");
                vsql.Append(",ANO_FAB = "+((Veiculo)obj).Ano_fab);
                vsql.Append(",ANO_MOD = "+((Veiculo)obj).Ano_mod);
                vsql.Append(",CIDADE = '"+((Veiculo)obj).Cidade+"'");
                vsql.Append(",UF = '"+((Veiculo)obj).UF+"'");
                vsql.Append(",LITROS_TANQUE = '"+((Veiculo)obj).Litros_tanque+"'");
                vsql.Append(",ID_MODELO = "+((Veiculo)obj).Modelo.ID.ToString());
                vsql.Append("WHERE ID=" + ((Veiculo)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao alterar o veículo. " + e.Message);
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
                vsql.Append("DELETE FROM VEICULO WHERE ID=" + ((Veiculo)obj).ID);
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = vsql.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                erro = false;
                throw new Exception("Erro ao excluir o veículo. " + e.Message);
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
            Veiculo veiculo;
            bool erro = true;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                SelectPadrao(vsql, ref command);
                vsql.Append("WHERE ID="+((Veiculo)obj).ID.ToString());
                command.CommandText = vsql.ToString();
                reader = command.ExecuteReader();
                veiculo = ((Veiculo)obj);
                if (reader.Read())
                {
                    parserReaderObj(reader, veiculo);
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
        public bool buscarPlaca(ClasseBase obj)
        {
            SqlDataReader reader;
            Veiculo veiculo;
            bool erro = true;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                SelectPadrao(vsql, ref command);
                vsql.Append("WHERE PLACA='" + ((Veiculo)obj).Placa+"'");
                command.CommandText = "";
                command.CommandText = command.CommandText + vsql.ToString();
                reader = command.ExecuteReader();
                veiculo = ((Veiculo)obj);
                if (reader.Read())
                {
                    parserReaderObj(reader, veiculo);
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

        public bool verifPlaca(Veiculo obj)
        {
            Int32 co;
            bool resultado = false;
            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                command.CommandText = "SELECT COUNT(ID) AS CO FROM VEICULO " +
                    "WHERE PLACA='" + obj.Placa + "' AND ID<>" + obj.ID;
                co = (int)command.ExecuteScalar();
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
            bool result = false;

            if ((obj.Estado == Stateobj.stNovo || obj.Estado == Stateobj.stEditar))
            {
                if (verifPlaca((Veiculo)obj))
                    throw new EInvalidObjectDAOBase("Placa já cadastrada");

                result = true;
            }
            else
                result = base.validarDAO(obj);
            return result;
        }

        public List<Veiculo> listar(Veiculo obj)
        {
            SqlDataReader reader;
            List<Veiculo> lista = new List<Veiculo>();
            Veiculo veiculo;
            Int32 x = 0;

            try
            {
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                SelectPadrao(vsql, ref command);
                vsql.Append(" order by placa");
                command.CommandText = command.CommandText+vsql.ToString();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Veiculo());
                    veiculo = lista[x];
                    parserReaderObj(reader, veiculo);
                    x++;
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao montar a lista de veículos. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}