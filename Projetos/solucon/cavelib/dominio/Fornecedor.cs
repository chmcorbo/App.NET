/// <summary>
/// Classes de Domínio do Financeiro
/// 

namespace Cave.Dominio.Financeiro
{
    using System;
    using Solucon.Dominio;

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
        public override bool validarModel()
        {
            bool result = false;

            if (this.Estado == Solucon.State.Stateobj.stNovo || this.Estado == Solucon.State.Stateobj.stEditar)
            {
                if (this.Razao_social == "")
                    throw new EInvalidObjectClasseBase("Razão Social do fornecedor não informado");
                if (this.Cnpj == "")
                    throw new EInvalidObjectClasseBase("CNPJ do fornecedor não informado");
                if (!Solucon.CNPJ.validaCNPJ(this.Cnpj))
                    throw new EInvalidObjectClasseBase("CNPJ informado não é válido");
            }
            result = base.validarModel();
            return result;
        }
    }
}