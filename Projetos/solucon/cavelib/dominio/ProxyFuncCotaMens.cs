using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Solucon.Dominio;

namespace Cave.Dominio.RH
{
    public class ProxyFuncCota : ClasseBase
    {
        // Properties
        public String Matricula { get; set; }
        public String Nome { get; set; }
        public Int32 ID_funcao { get; set; }
        public String Nome_funcao { get; set; }
        // Métodos
        public ProxyFuncCota()
        {

        }
    }
}
