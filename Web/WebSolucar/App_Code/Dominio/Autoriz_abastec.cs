
/// <summary>
/// Summary description for Autoriz_abastec
/// </summary>
namespace cave.dominio.abastecimento
{
    using System;
    using solucon.dominio;
    using cave.dominio.RH;
    using cave.dominio.veiculo;

    public class Autoriz_abastec : ClasseBase
    {
        // Fields;
        private Funcionario _funcionario;
        private Veiculo _veiculo;

        // Properties;
        public DateTime Dt_autoriz { get; set; }
        public Int32 Quantidade { get; set; }
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
        public Autoriz_abastec()
        {
            _funcionario = new Funcionario();
            _veiculo = new Veiculo();
        }
    }
}