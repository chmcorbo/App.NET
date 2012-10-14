/// <summary>
/// Classe de domínio Cota de Abastecimento
/// </summary>

namespace cave.dominio.abastecimento
{
    using System;
    using solucon.dominio;
    using cave.dominio.RH;

    public class Cota_abastec : ClasseBase
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
        public Cota_abastec()
        {
            _funcionario = new Funcionario();
        }
    }
}