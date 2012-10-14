/// <summary>
/// Classe de domínio Funcao
/// </summary>
/// 

namespace Cave.Dominio.RH
{
    using System;
    using Solucon.Dominio;

    public class Funcao : ClasseBase
    {
        // Properties
        public String Nome { get; set; }
        // Métodos
        public Funcao()
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
                if (this.Nome == "")
                    throw new EInvalidObjectClasseBase("Nome da função não informado");
            }
            result = base.validarModel();
            return result;
        }
    }

}