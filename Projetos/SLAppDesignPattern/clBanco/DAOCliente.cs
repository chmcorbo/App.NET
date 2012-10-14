using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace clBanco
{
    public class DAOCliente
    {
        public void Inserir() 
        {           
            IDbCommand command = DBControlsAbstractFactory.GetDBFactory(TipoBD.MySQL).GetCommand();

            command.CommandText = "Teste";
            command.ExecuteNonQuery();
        }
    }
}
