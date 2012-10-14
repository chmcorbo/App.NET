namespace CFuelCorboLib.dominio.combustivel
{
    using System;
    using CorboLibUtils.Dominio;

    public class Combustivel : ClasseBase
    {
        public String descricao { get; set; }
        public override bool validarModel()
        {
            bool result = false;

            if ((this.Estado == CorboLibUtils.State.Stateobj.stNovo || this.Estado == CorboLibUtils.State.Stateobj.stEditar))
            {
                if (this.ID == 0)
                    throw new EInvalidObjectClasseBase("ID do posto não informado");

                if (this.descricao == String.Empty)
                    throw new EInvalidObjectClasseBase("Nome do posto não informado");

                result = true;
            }
            else
                result = base.validarModel();
            return result;
        }
    }
}
