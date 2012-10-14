namespace CFuelCorboLib.dominio
{
    using System;
    using CorboUtils.Dominio;

    public class Abastecimento : ClasseBase
    {
        #region Fields
        private Veiculo _veiculo;
        private Posto _posto;
        private Combustivel _combustivel;
        #endregion 
        
        #region Properties
        public Veiculo veiculo
        {
            get { return _veiculo; }
            set { _veiculo = value; }
        }

        public DateTime data_abastec { get; set; }
        public DateTime hora_abastec { get; set; }

        public Combustivel combustivel 
        {
            get { return _combustivel; }
            set { _combustivel = value; }
        }

        public Int32 km { get; set; }
        public Double litragem { get; set; }
        public Double km_litro { get; set; }
        public Double valor_unit { get; set; }
        public Double valor_total { get; set; }
        public Posto posto
        {
            get { return _posto; }
            set { _posto = value; }
        }
        public String observacao { get; set; }
        #endregion

        #region Métodos
        public Abastecimento()
        {
            _veiculo = new Veiculo();
            _posto = new Posto();
            _combustivel = new Combustivel();
        }
        public override bool validarModel()
        {
            bool result = false;

            if ((this.Estado == CorboUtils.State.Stateobj.stNovo || this.Estado == CorboUtils.State.Stateobj.stEditar))
            {
                if (CorboUtils.DataHora.DataLib.Empty(this.data_abastec))
                    throw new EInvalidObjectClasseBase("Data de abastecimento não informada");

                if (this.combustivel.ID == 0)
                    throw new EInvalidObjectClasseBase("Tipo de combustível não informado");

                if (this.km == 0)
                    throw new EInvalidObjectClasseBase("Quilometragem não informada");

                if (this.litragem == 0)
                    throw new EInvalidObjectClasseBase("Litragem não informada");

                if (this.valor_unit == 0)
                    throw new EInvalidObjectClasseBase("Valor unitário não informado");

                if (this.valor_total == 0)
                    throw new EInvalidObjectClasseBase("Valor total não informado");

                if (this.posto.ID == 0)
                    throw new EInvalidObjectClasseBase("Posto não informado");

                result = true;
            }
            else
                result = base.validarModel();
            return result;
        }
        public void calcularValorTotal()
        {
            valor_total = valor_unit * litragem;
        }
        public void calcularKmLitro()
        {
            if (km != 0 && litragem != 0)
            {
                km_litro = km / litragem;
            }
        }
        #endregion
    }
}
