/// <summary>
/// Classe de domínio Frentista
/// </summary>
///


namespace Cave.Dominio.Financeiro
{

    using System;
    using Solucon.Dominio;
    using Cave.Dominio.Seguranca;
    using Cave.Dominio.Financeiro;

    public class Frentista : Usuario
    {
        // Fields
        private Fornecedor fornecedor;
        // Propriedades
        public Fornecedor Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value; }
        }

        // Métodos 
        public Frentista()
        {
            fornecedor = new Fornecedor();
        }
        public override bool validarModel()
        {
            bool result = false;

            if ((this.Estado == Solucon.State.Stateobj.stNovo || this.Estado == Solucon.State.Stateobj.stEditar))
            {
                if (this.Login == "")
                    throw new EInvalidObjectClasseBase("Usuário não informado");

                if (this.fornecedor.ID == 0)
                    throw new EInvalidObjectClasseBase("Fornecedor/Posto não informado");

                result = true;
            }
            else
                result = base.validarModel();
            return result;
        }

    }
}