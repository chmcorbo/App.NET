namespace CFuelCorboLib.dao
{
    using System;
    using System.Linq;
    using CFuelCorboLib.dominio;
    using CorboUtils.DAO;
    using System.Xml.Linq;
    using System.Collections.Generic;
    using CorboUtils.DataHora;

    public class DAOAbastecimentoXML : DAOBase
    {
        private XDocument _xmlDoc;
        private String _caminho;
        private Boolean _erro = false;
        private List<Abastecimento> _lista;

        private void salvarXML()
        {
            _xmlDoc.Save(_caminho);
        }

        public DAOAbastecimentoXML(String pCaminho)
        {
            _caminho = pCaminho + @"\veiculo.xml";
            _xmlDoc = XDocument.Load(pCaminho);
        }
        
        public override bool inserir(CorboUtils.Dominio.ClasseBase obj)
        {
            _erro = false;
            try
            {
                XElement novo = new XElement("abastecimento", new XAttribute("id", DataLib.getID().ToString()),
                     new XElement("data_abastec", ((Abastecimento)obj).data_abastec.ToString("dd/MM/yyyy")),
                     new XElement("hora_abastec", ((Abastecimento)obj).hora_abastec.ToString("hh:mm")),
                     new XElement("id_tipo_combustivel", ((Abastecimento)obj).combustivel.ID.ToString()),
                     new XElement("km", ((Abastecimento)obj).km.ToString()),
                     new XElement("litragem", ((Abastecimento)obj).litragem.ToString()),
                     new XElement("km_litro", ((Abastecimento)obj).km_litro.ToString()),
                     new XElement("valor_unit", ((Abastecimento)obj).valor_unit.ToString()),
                     new XElement("valor_total", ((Abastecimento)obj).valor_total.ToString()),
                     new XElement("id_posto", ((Abastecimento)obj).posto.ID.ToString()),
                     new XElement("id_veiculo", ((Abastecimento)obj).veiculo.ID.ToString()),
                     new XElement("sincronizado", "N"));


                _xmlDoc.Element("abastecimentos").Add(novo);
                salvarXML();
            }
            catch (Exception e)
            {
                _erro = true;
                throw new Exception("Erro ao inserir o abastecimento. " + e.Message);
            }
            return !_erro;

        }

        public override bool alterar(CorboUtils.Dominio.ClasseBase obj)
        {

            _erro = false;
            try
            {
                var xmlAbastec = _xmlDoc.Descendants("abastecimento").Where(x => x.Attribute("id").Value == ((Abastecimento)obj).ID.ToString()).FirstOrDefault();

                if (xmlAbastec != null)
                {

                    xmlAbastec.Element("data_abaste").Value=((Abastecimento)obj).data_abastec.ToString("dd/MM/yyyy");
                    xmlAbastec.Element("hora_abastec").Value=((Abastecimento)obj).hora_abastec.ToString("hh:mm");
                    xmlAbastec.Element("id_tipo_combustivel").Value=((Abastecimento)obj).combustivel.ID.ToString();
                    xmlAbastec.Element("km").Value=((Abastecimento)obj).km.ToString();
                    xmlAbastec.Element("litragem").Value=((Abastecimento)obj).litragem.ToString();
                    xmlAbastec.Element("km_litro").Value=((Abastecimento)obj).km_litro.ToString();
                    xmlAbastec.Element("valor_unit").Value=((Abastecimento)obj).valor_unit.ToString();
                    xmlAbastec.Element("valor_total").Value=((Abastecimento)obj).valor_total.ToString();
                    xmlAbastec.Element("id_posto").Value = ((Abastecimento)obj).posto.ID.ToString();
                    xmlAbastec.Element("id_veiculo").Value=((Abastecimento)obj).veiculo.ID.ToString();
                    xmlAbastec.Element("sincronizado").Value="N";
                    salvarXML();
                }
            }
            catch (Exception e)
            {
                _erro = true;
                throw new Exception("Erro ao alterar o abastecimento. " + e.Message);
            }

            return !_erro;
        }

        public override bool excluir(CorboUtils.Dominio.ClasseBase obj)
        {
            _erro = false;
            try
            {
                var xmlAbastec = _xmlDoc.Descendants("abastecimento").Where(x => x.Attribute("id").Value == ((Abastecimento)obj).ID.ToString()).FirstOrDefault();
                if (xmlAbastec != null)
                {
                    xmlAbastec.Remove();
                    salvarXML();
                }
            }
            catch (Exception e)
            {
                _erro = true;
                throw new Exception("Erro ao excluir o abastecimento. " + e.Message);
            }
            return !_erro;
        }


        public override bool buscarID(CorboUtils.Dominio.ClasseBase obj)
        {
            _erro = false;
            try
            {
                var xmlAbastec = _xmlDoc.Descendants("veiculo").Where(x => x.Attribute("id").Value == obj.ID.ToString()).FirstOrDefault();

                ((Abastecimento)obj).ID = Int32.Parse(xmlAbastec.Element("id").Value);
                ((Abastecimento)obj).data_abastec = DateTime.Parse(xmlAbastec.Element("data_abastec").Value);
                ((Abastecimento)obj).hora_abastec = DateTime.Parse(xmlAbastec.Element("hora_abastec").Value);
                ((Abastecimento)obj).combustivel.ID = Int32.Parse(xmlAbastec.Element("id_tipo_combustivel").Value);
                ((Abastecimento)obj).km = Int32.Parse(xmlAbastec.Element("km").Value);
                ((Abastecimento)obj).litragem = Double.Parse(xmlAbastec.Element("litragem").Value);
                ((Abastecimento)obj).km_litro = Double.Parse(xmlAbastec.Element("km_litro").Value);
                ((Abastecimento)obj).valor_unit = Double.Parse(xmlAbastec.Element("valor_unit").Value);
                ((Abastecimento)obj).valor_total = Double.Parse(xmlAbastec.Element("valor_total").Value);
                ((Abastecimento)obj).posto.ID = Int32.Parse(xmlAbastec.Element("id_posto").Value);
                ((Abastecimento)obj).observacao = xmlAbastec.Element("observacao").Value;
                 
            }
            catch (Exception e)
            {
                _erro = true;
                throw new Exception("Erro ao consultar o lançamento de abastecimento. " + e.Message);
            }
            finally
            {
                _erro = false;
            }

            return !_erro;
        }

        private void criarLista()
        {
            if (_lista == null)
                _lista = new List<Abastecimento>();
            else
                _lista.Clear();
        }

        private void carregaListaAbastecimento(IEnumerable<XElement> pXmlLista)
        {
            Abastecimento abastecimento;
            foreach (XElement xmlAbastec in pXmlLista)
            {
                abastecimento = new Abastecimento();

                abastecimento.ID = Int32.Parse(xmlAbastec.Element("id").Value);
                abastecimento.data_abastec = DateTime.Parse(xmlAbastec.Element("data_abastec").Value);
                abastecimento.hora_abastec = DateTime.Parse(xmlAbastec.Element("hora_abastec").Value);
                abastecimento.combustivel.ID = Int32.Parse(xmlAbastec.Element("id_tipo_combustivel").Value);
                abastecimento.km = Int32.Parse(xmlAbastec.Element("km").Value);
                abastecimento.litragem = Double.Parse(xmlAbastec.Element("litragem").Value);
                abastecimento.km_litro = Double.Parse(xmlAbastec.Element("km_litro").Value);
                abastecimento.valor_unit = Double.Parse(xmlAbastec.Element("valor_unit").Value);
                abastecimento.valor_total = Double.Parse(xmlAbastec.Element("valor_total").Value);
                abastecimento.posto.ID = Int32.Parse(xmlAbastec.Element("id_posto").Value);
                abastecimento.observacao = xmlAbastec.Element("observacao").Value;
                _lista.Add(abastecimento);
            }
        }

        public List<Abastecimento> listar(Veiculo pVeiculo)
        {
            criarLista();
            var xmlLista = _xmlDoc.Descendants("abastecimento").
                Where(x => x.Element("id_veiculo").Value == pVeiculo.ID.ToString());
            carregaListaAbastecimento(xmlLista);
            return _lista;
        }

        public List<Abastecimento> listar(Posto pPosto)
        {
            criarLista();
            var xmlLista = _xmlDoc.Descendants("abastecimento").
                Where(x => x.Element("id_posto").Value == pPosto.ID.ToString());
            carregaListaAbastecimento(xmlLista);
            return _lista;
        }

        public List<Abastecimento> listar(DateTime pData_Inicial, DateTime pData_Final)
        {
            criarLista();
            var xmlLista = _xmlDoc.Descendants("abastecimento").
                Where(x => DateTime.Parse(x.Element("data_abastec").Value) >= DateTime.Parse(pData_Inicial.ToString()) &&
                DateTime.Parse(x.Element("data_abastec").Value) <= DateTime.Parse(pData_Final.ToString()));
            carregaListaAbastecimento(xmlLista);
            return _lista;
        }

    }
}
