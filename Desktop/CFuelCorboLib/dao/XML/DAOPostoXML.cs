

namespace CFuelCorboLib.dao
{
    using System;
    using System.Linq;
    using CFuelCorboLib.dominio;
    using CorboUtils.DAO;
    using System.Xml.Linq;
    using System.Collections.Generic;
    using CorboUtils.DataHora;

    public class DAOPosto : DAOBase
    {
        private XDocument _xmlDoc;
        private String _caminho;
        private Boolean _erro = false;
        private List<Posto> _lista; 

        private void salvarXML()
        {
            _xmlDoc.Save(_caminho);
        }

        public DAOPosto(String pCaminho)
        {
            _caminho = pCaminho + @"\posto.xml";
            _xmlDoc = XDocument.Load(pCaminho);
        }

        public override bool alterar(CorboUtils.Dominio.ClasseBase obj)
        {
            _erro = false;
            try
            {
                var posto = _xmlDoc.Descendants("posto").Where(x => x.Attribute("id").Value == ((Veiculo)obj).ID.ToString()).FirstOrDefault();

                if (posto != null)
                {
                    posto.Element("nome").Value = ((Posto)obj).nome;
                    posto.Element("bairro").Value = ((Posto)obj).bairro;
                    posto.Element("cidade").Value = ((Posto)obj).cidade;
                    posto.Element("uf").Value = ((Posto)obj).uf;
                    salvarXML();
                }
            }
            catch (Exception e)
            {
                _erro = true;
                throw new Exception("Erro ao alterar o posto. " + e.Message);
            }

            return !_erro;
        }

        public override bool buscarID(CorboUtils.Dominio.ClasseBase obj)
        {
            Boolean encontrado = false;

            var posto = _xmlDoc.Descendants("posto").Where(x => x.Attribute("id").Value == obj.ID.ToString()).FirstOrDefault();

            if (posto != null)
            {
                encontrado = true;
                ((Posto)obj).nome = posto.Element("nome").Value;
                ((Posto)obj).bairro = posto.Element("bairro").Value;
                ((Posto)obj).cidade = posto.Element("cidade").Value;
                ((Posto)obj).uf = posto.Element("uf").Value;

            }
            return encontrado;
        }

        public override bool excluir(CorboUtils.Dominio.ClasseBase obj)
        {
            _erro = false;
            try
            {
                var posto = _xmlDoc.Descendants("posto").Where(x => x.Attribute("id").Value == ((Veiculo)obj).ID.ToString()).FirstOrDefault();
                if (posto != null)
                {
                    posto.Remove();
                    salvarXML();
                }
            }
            catch (Exception e)
            {
                _erro = true;
                throw new Exception("Erro ao excluir o posto. " + e.Message);
            }
            return !_erro;
        }

        public override bool inserir(CorboUtils.Dominio.ClasseBase obj)
        {
            _erro = false;
            try
            {
                XElement novo = new XElement("posto", new XAttribute("id", DataLib.getID().ToString()),
                     new XElement("nome", ((Posto)obj).nome), new XElement("bairro", ((Posto)obj).bairro),
                     new XElement("cidade", ((Posto)obj).cidade), new XElement("uf", ((Posto)obj).uf));
                _xmlDoc.Element("postos").Add(novo);
                salvarXML();
            }
            catch (Exception e)
            {
                _erro = true;
                throw new Exception("Erro ao inserir o posto. " + e.Message);
            }
            return !_erro;

        }
        private void criarLista()
        {
            if (_lista == null)
                _lista = new List<Posto>();
            else
                _lista.Clear();
        }

        private void carregaLista(IEnumerable<XElement> pXmlLista)
        {
            criarLista();
            Posto posto;
            foreach (XElement xmlPosto in pXmlLista)
            {
                posto = new Posto();
                posto.ID = Int32.Parse(xmlPosto.Attribute("id").Value);
                posto.nome = xmlPosto.Element("nome").Value;
                posto.bairro = xmlPosto.Element("bairro").Value;
                posto.cidade = xmlPosto.Element("cidade").Value;
                posto.uf = xmlPosto.Element("uf").Value;
                _lista.Add(posto);
            }

        }

        public List<Posto> listar()
        {
            var query = _xmlDoc.Descendants("posto").
                OrderBy(x => x.Element("nome").Value);
            if (query.Any())
               carregaLista(query);
            return _lista;
        }
        public List<Posto> listar(String pNome)
        {
            var query = _xmlDoc.Descendants("posto").
                Where(x => x.Element("nome").Value.StartsWith(pNome)).
                OrderBy(x => x.Element("nome").Value);
            if (query.Any())
               carregaLista(query);
            return _lista;
        }

    }
}
