/// <summary>
/// Classe de domínio da Marca
/// </summary>
/// 

namespace Cave.Dominio.Veiculo
{
    using System;
    using Cave.Dominio.Veiculo;
    using Solucon.Dominio;

    public class Marca : ClasseBase
    {
        //Properties
        public String Descricao { get; set; }
        // Métodos
        public Marca()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public override bool validarModel()
        {
            bool result = false;

            if ((this.Estado == Solucon.State.Stateobj.stNovo || this.Estado == Solucon.State.Stateobj.stEditar))
            {
                if (this.Descricao == "")
                    throw new EInvalidObjectClasseBase("Descrição da marca não informada");

                result = true;
            }
            else
                result = base.validarModel();
            return result;
        }

    }        
}