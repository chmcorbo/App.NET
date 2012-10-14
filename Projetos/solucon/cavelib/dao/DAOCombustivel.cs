namespace Cave.DAO.Veiculo
{
    using System;
    using System.Data.SqlClient;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Cave.Dominio.Veiculo;
    using Sigleton.Conexao;
    using Solucon.DAO;
    using Solucon.Dominio;

    public class DAOCombustivel : DAOBase
    {
        private SqlCommand command;
        private StringBuilder vsql;

        public DAOCombustivel()
        {
            command = new SqlCommand();
            vsql = new StringBuilder();
        }

        public override bool inserir(ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override bool alterar(ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override bool excluir(ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override bool buscarID(ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public List<Combustivel> listar()
        {
            List<Combustivel> lista = new List<Combustivel>();
            System.Data.DataSet ds = new System.Data.DataSet();
            Int32 x = 0;

            try
            {
                SqlDataReader reader;
                command.Connection = MsSQL.getConexao();
                command.Connection.Open();
                vsql.Append("SELECT ID, DESCRICAO FROM COMBUSTIVEL ");
                vsql.Append("ORDER BY DESCRICAO ");
                command.CommandText = vsql.ToString();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Combustivel());
                    lista[x].ID = Convert.ToInt32(reader["ID"]);
                    lista[x].Descricao = reader["DESCRICAO"].ToString();
                    x++;
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao montar a lista de Tipo de combustível. " + e.Message);
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
