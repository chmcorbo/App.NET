namespace CFuelCorboLib.dominio
{
    using System;
    using CorboUtils.Dominio;

    public class Combustivel : ClasseBase
    {
        public String descricao { get; set; }
        public override bool validarModel()
        {
            bool result = false;

            if ((this.Estado == CorboUtils.State.Stateobj.stNovo || this.Estado == CorboUtils.State.Stateobj.stEditar))
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
