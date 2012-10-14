/// <summary>
/// Classe de domínio de Veículo
/// </summary>
/// 
namespace cave.dominio.veiculo
{
    using System;
    using solucon.dominio;
    using cave.dominio.RH;

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
        public Int16 ano_mod { get; set; }
        public String Cidade { get; set; }
        public String UF { get; set; }
        public Int16 Qtde_tanque { get; set; }
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
    }
}