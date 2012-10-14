using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


namespace ConfigAppXML
{
    public class ConfigXML
    {
        private String _filename;
        private XDocument _xmlDoc;
        Boolean _erro = false;

        public ConfigXML(String pFileName)
        {
            _xmlDoc = XDocument.Load(pFileName);
        }

    }
}
