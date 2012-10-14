/// <summary>
/// Classes de Domínio do Financeiro
/// 

namespace cave.dominio.financeiro
{
    using System;
    using solucon.dominio;

    public class Fornecedor : ClasseBase
    {
        // Properties
        public String Razao_social { get; set; }
        public String Cnpj { get; set; }
        public String Insc_estadual { get; set; }
        public String Insc_municipal { get; set; }
        // Métodos
        public Fornecedor()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}