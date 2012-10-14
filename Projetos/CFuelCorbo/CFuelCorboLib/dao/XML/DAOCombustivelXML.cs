
namespace CFuelCorboLib.dao.xml
{
    using System;
    using CFuelCorboLib.dominio.combustivel;
    using CorboLibUtils.DAO;
    using System.Linq;
    using System.Xml;
    using System.Collections.Generic;
    public class DAOCombustivelXML : DAOBase
    {

        public override bool alterar(CorboLibUtils.Dominio.ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override bool buscarID(CorboLibUtils.Dominio.ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override bool excluir(CorboLibUtils.Dominio.ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override bool inserir(CorboLibUtils.Dominio.ClasseBase obj)
        {
            throw new NotImplementedException();
        }
        public List<Combustivel> listar()
        {
            List<Combustivel> lista = new List<Combustivel>();
            Combustivel combustivel;

            combustivel = new Combustivel();
            combustivel.ID = 1;
            combustivel.descricao = "Gasolina";
            lista.Add(combustivel);
            
            combustivel = new Combustivel();
            combustivel.ID = 2;
            combustivel.descricao = "Álcool";
            lista.Add(combustivel);
            
            combustivel = new Combustivel();
            combustivel.ID = 3;
            combustivel.descricao = "Diesel";
            lista.Add(combustivel);

            combustivel = new Combustivel();
            combustivel.ID = 4;
            combustivel.descricao = "GN";
            lista.Add(combustivel);
            return lista;
        }
    }
}
