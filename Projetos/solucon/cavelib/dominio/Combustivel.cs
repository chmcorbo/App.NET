namespace Cave.Dominio.Veiculo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Solucon.Dominio;

    public class Combustivel : ClasseBase
    {
        public String Descricao { get; set; }
        public Combustivel()
        {
            Descricao = "";
        }
        public override bool validarModel()
        {
            bool result = false;

            if (this.Estado == Solucon.State.Stateobj.stNovo || this.Estado == Solucon.State.Stateobj.stEditar)
            {
                if (this.Descricao == "")
                    throw new EInvalidObjectClasseBase("Descrição do tipo de combustível não informado");
            }
            result = base.validarModel();
            return result;
        }
    }
}
