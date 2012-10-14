namespace CFuelCorboLib.dao
{
    using System;
    using System.Linq;
    using CFuelCorboLib.dominio;
    using CorboUtils.DAO;
    using System.Xml.Linq;
    using System.Collections.Generic;
    using CorboUtils.DataHora;

    public class DAOVeiculoXML : DAOBase
    {
        private XDocument _xmlDoc;
        private String _caminho;
        Boolean _erro = false;

        private void salvarXML()
        {
            _xmlDoc.Save(_caminho);
        }
        public DAOVeiculoXML(String pCaminho)
        {
            _caminho = pCaminho+@"\veiculo.xml";
            _xmlDoc = XDocument.Load(pCaminho);
        }

        public override bool alterar(CorboUtils.Dominio.ClasseBase obj)
        {
            _erro = false;
            try
            {
                var veiculo = _xmlDoc.Descendants("veiculo").Where(x => x.Attribute("id").Value == ((Veiculo)obj).ID.ToString()).FirstOrDefault();

                if (veiculo != null)
                {
                    veiculo.Element("placa").Value = ((Veiculo)obj).placa;
                    veiculo.Element("marca").Value = ((Veiculo)obj).marca;
                    veiculo.Element("modelo").Value = ((Veiculo)obj).modelo;
                    veiculo.Element("cor").Value = ((Veiculo)obj).cor;
                    salvarXML();
                }
            }
            catch (Exception e)
            {
                _erro = true;
                throw new Exception("Erro ao alterar o veículo. " + e.Message);
            }

            return !_erro;

        }

        public override bool buscarID(CorboUtils.Dominio.ClasseBase obj)
        {
            Boolean encontrado = false;
           
            var veiculo = _xmlDoc.Descendants("veiculo").Where(x => x.Attribute("id").Value == obj.ID.ToString()).FirstOrDefault();
           
            if (veiculo != null)
            {
                encontrado = true;
                ((Veiculo)obj).placa=veiculo.Element("placa").Value;
                ((Veiculo)obj).marca = veiculo.Element("marca").Value;
                ((Veiculo)obj).modelo = veiculo.Element("modelo").Value;
                ((Veiculo)obj).cor = veiculo.Element("cor").Value;

            }
            return encontrado;
        }

        public override bool excluir(CorboUtils.Dominio.ClasseBase obj)
        {
            _erro = false;
            try
            {
                var veiculo = _xmlDoc.Descendants("veiculo").Where(x => x.Attribute("id").Value == ((Veiculo)obj).ID.ToString()).FirstOrDefault();
                if (veiculo != null)
                {
                    veiculo.Remove();
                    salvarXML();
                }
            }
            catch (Exception e)
            {
                _erro = true;
                throw new Exception("Erro ao excluir o veículo. " + e.Message);
            }
            return !_erro;
        }

        public override bool inserir(CorboUtils.Dominio.ClasseBase obj)
        {
            _erro = false;
            try
            {
                XElement novo = new XElement("veiculo", new XAttribute("id", DataLib.getID().ToString()),
                     new XElement("placa", ((Veiculo)obj).placa), 
                     new XElement("marca", ((Veiculo)obj).marca),
                     new XElement("modelo", ((Veiculo)obj).modelo), 
                     new XElement("cor", ((Veiculo)obj).cor));
                _xmlDoc.Element("veiculos").Add(novo);
                salvarXML();
            }
            catch (Exception e)
            {
                _erro = true;
                throw new Exception("Erro ao inserir o veículo. " + e.Message);
            }
            return !_erro;
        }
        public List<Veiculo> listar()
        {
            List<Veiculo> lista = new List<Veiculo>();
            Veiculo veiculo;

            var query = _xmlDoc.Descendants("veiculo");

            foreach (XElement xmlVeiculo in query)
            {
                veiculo = new Veiculo();
                veiculo.ID = Int32.Parse(xmlVeiculo.Attribute("id").Value);
                veiculo.placa = xmlVeiculo.Element("placa").Value;
                veiculo.marca = xmlVeiculo.Element("marca").Value;
                veiculo.modelo = xmlVeiculo.Element("modelo").Value;
                veiculo.cor = xmlVeiculo.Element("cor").Value;
                lista.Add(veiculo);
            }

            return lista;
        }

    }
}
