
namespace CFuelCorboLib.dao
{
    using System;
    using CFuelCorboLib.dominio;
    using CorboUtils.DAO;
    using System.Linq;
    using System.Xml;
    using System.Collections.Generic;
    public class DAOCombustivelXML : DAOBase
    {

        public override bool alterar(CorboUtils.Dominio.ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override bool buscarID(CorboUtils.Dominio.ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override bool excluir(CorboUtils.Dominio.ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override bool inserir(CorboUtils.Dominio.ClasseBase obj)
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
