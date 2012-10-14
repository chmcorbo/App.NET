
/// <summary>
/// Summary description for Abastecimento
/// </summary>

namespace cave.dominio.abastecimento
{
    using System;
    using solucon.dominio;
    using cave.dominio.RH;
    using cave.dominio.veiculo;
    using cave.dominio.financeiro;

    public class Abastecimento : ClasseBase
    {
        // Fields;
        private Fornecedor _fornecedor;
        private Veiculo _veiculo;
        private Funcionario _funcionario;

        // Properties;
        public DateTime Dt_abastec { get; set; }
        public Int32 Km { get; set; }
        public Double Qtde { get; set; }
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

        // Métodos;
        public Abastecimento()
        {
            _fornecedor = new Fornecedor();
            _veiculo = new Veiculo();
            _funcionario = new Funcionario();
        }
    }
}