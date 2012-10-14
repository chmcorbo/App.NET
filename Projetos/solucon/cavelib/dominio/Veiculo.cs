/// <summary>
/// Classe de domínio de Veículo
/// </summary>
/// 
namespace Cave.Dominio.Veiculo
{
    using System;
    using Solucon.Dominio;
    using Cave.Dominio.RH;

    public class Veiculo : ClasseBase
    {
        //Fields;
        private Modelo _modelo;
        private Funcionario _funcionario;

        // Properties
        public String Placa { get; set; }
        public String Num_chassi { get; set; }
        public String Cor { get; set; }
        public Int16 Num_portas { get; set; }
        public String Cod_renavam { get; set; }
        public Int16 Ano_fab { get; set; }
        public Int16 Ano_mod { get; set; }
        public String Cidade { get; set; }
        public String UF { get; set; }
        public Int16 Litros_tanque { get; set; }
        public Modelo Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public Funcionario Funcionario
        {
            get { return _funcionario; }
            set { _funcionario = value; }
        }

        // Métodos
        public Veiculo()
        {
            _modelo = new Modelo();
            _funcionario = new Funcionario();
        }
        public override bool validarModel()
        {
            bool result = false;

            if ((this.Estado == Solucon.State.Stateobj.stNovo || this.Estado == Solucon.State.Stateobj.stEditar))
            {
                if (this.Placa=="")
                    throw new EInvalidObjectClasseBase("Placa não informada");

                if (this.Modelo.Marca.ID == 0)
                    throw new EInvalidObjectClasseBase("Marca não informada");

                if (this.Modelo.ID == 0)
                    throw new EInvalidObjectClasseBase("Modelo não informado");

                if (this.Litros_tanque == 0)
                    throw new EInvalidObjectClasseBase("Capacidade do tanque não informado");

                result = true;
            }
            else
                result = base.validarModel();
            return result;
        }
    }
}