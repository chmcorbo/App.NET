
/// <summary>
/// Classe domínio de Abastecimento
/// </summary>

namespace Cave.Dominio.Abastecimento
{
    using System;
    using Solucon.Dominio;
    using Cave.Dominio.RH;
    using Cave.Dominio.Veiculo;
    using Cave.Dominio.Financeiro;

    public class Abastecimento : ClasseBase
    {
        // Fields;
        private Veiculo _veiculo;
        private Fornecedor _fornecedor;
        private Funcionario _funcionario;
        private Combustivel _combustivel;

        // Properties;
        public Fornecedor Fornecedor
        {
            get { return _fornecedor; }
            set { _fornecedor = value; }
        }
        public Veiculo Veiculo
        {
            get { return _veiculo; }
            set { _veiculo = value; }
        }
        public Funcionario Funcionario
        {
            get { return _funcionario; }
            set { _funcionario = value; }
        }
        public Combustivel Tipo_Combustivel
        {
            get { return _combustivel; }
            set { _combustivel = value; }
        }

        public DateTime Dt_abastec { get; set; }
        public Int32 Km { get; set; }
        public Double Quantidade { get; set; }
        public Double Preco { get; set; }

        // Métodos;
        public Abastecimento()
        {
            _veiculo = new Veiculo();
            _fornecedor = new Fornecedor();
            _funcionario = new Funcionario();
            _combustivel = new Combustivel();
        }
        public override bool validarModel()
        {
            bool result = false;

            if ((this.Estado == Solucon.State.Stateobj.stNovo || this.Estado == Solucon.State.Stateobj.stEditar))
            {
                if (this.Veiculo.ID == 0)
                    throw new EInvalidObjectClasseBase("Veículo não informado.");
                
                if (this.Fornecedor.ID == 0)
                    throw new EInvalidObjectClasseBase("Fornecedor / Posto não informado.");

                if (this.Funcionario.ID == 0)
                    throw new EInvalidObjectClasseBase("Funcionário não informado.");

                if (Solucon.DataHora.DataLib.Empty(this.Dt_abastec))
                    throw new EInvalidObjectClasseBase("Data de abastecimento não informado.");

                if (this.Km==0)
                    throw new EInvalidObjectClasseBase("Hodômetro (KM) não informado não informado.");

                if (this.Quantidade == 0)
                    throw new EInvalidObjectClasseBase("Quantidade de litros não informado.");

                if (this.Preco == 0)
                    throw new EInvalidObjectClasseBase("Preço unitário não informado.");

                if (this.Preco == 0)
                    throw new EInvalidObjectClasseBase("Preço unitário não informado.");


                result = true;
            }
            else
                result = base.validarModel();
            return result;
        }

    }
}