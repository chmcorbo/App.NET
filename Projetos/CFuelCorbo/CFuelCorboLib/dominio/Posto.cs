namespace CFuelCorboLib.dominio.abastecimento
{
    using System;
    using CorboLibUtils.Dominio;

    public class Posto : ClasseBase
    {
        // Properties
        public String nome { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }
        public String uf { get; set; }
        // Métodos
        public override bool validarModel()
        {
            bool result = false;

            if ((this.Estado == CorboLibUtils.State.Stateobj.stNovo || this.Estado == CorboLibUtils.State.Stateobj.stEditar))
            {
                if (this.ID == 0)
                    throw new EInvalidObjectClasseBase("ID do posto não informado");

                if (this.nome == String.Empty)
                    throw new EInvalidObjectClasseBase("Nome do posto não informado");

                result = true;
            }
            else
                result = base.validarModel();
            return result;
        }
    }
}
