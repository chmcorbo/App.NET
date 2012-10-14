/// <summary>
/// Classe de domínio Cota de Abastecimento
/// </summary>

namespace Cave.Dominio.Abastecimento
{
    using System;
    using Solucon.Dominio;
    using Cave.Dominio.RH;

    public class Cota_mensal : ClasseBase
    {
        // Fields;
        private Funcionario _funcionario;

        // Properties;
        public Int32 Qtde {get; set;}
        public Int32 Mes { get; set; }
        public Int32 Ano { get; set; }
        public Funcionario Funcionario
        {
            get { return _funcionario; }
            set { _funcionario = value; }
        }
        // Métodos;
        public Cota_mensal()
        {
            _funcionario = new Funcionario();
        }
        public override bool validarModel()
        {
            bool result = false;

            if ((this.Estado == Solucon.State.Stateobj.stNovo || this.Estado == Solucon.State.Stateobj.stEditar))
            {

                if (this.Funcionario.ID == 0)
                    throw new EInvalidObjectClasseBase("Funcionário não informado");

                if (this.Mes == 0)
                    throw new EInvalidObjectClasseBase("Mês não informado");

                if (this.Ano == 0)
                    throw new EInvalidObjectClasseBase("Ano não informado");

                if (this.Qtde == 0)
                    throw new EInvalidObjectClasseBase("Quantidade não informada");

                result = true;
            }

            return result;
        }
    }
}