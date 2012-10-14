/// <summary>
/// Classe domínio de cota de extra de abastecimento
/// </summary>
/// 

namespace Cave.Dominio.Abastecimento
{
    using System;
    using Solucon.Dominio;
    using Cave.Dominio.RH;
    using Cave.Dominio.Veiculo;

    public class Cota_extra : ClasseBase
    {
        // Fields;
        private Funcionario _funcionario;
        private Veiculo _veiculo;

        // Properties;
        public DateTime Dt_autoriz { get; set; }
        public Double Quantidade { get; set; }
        public String Justificativa { get; set; }
        public Funcionario Funcionario
        {
            get { return _funcionario; }
            set { _funcionario = value; }
        }
        public Veiculo Veiculo
        {
            get { return _veiculo; }
            set { _veiculo = value; }
        }

        // Métodos
        public Cota_extra()
        {
            _funcionario = new Funcionario();
            _veiculo = new Veiculo();
        }
    }
}