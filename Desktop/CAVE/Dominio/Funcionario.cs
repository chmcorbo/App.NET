/// <summary>
/// Classe de domínio de funcionário;
/// </summary>
/// 

namespace cave.dominio.RH
{
    using System;
    using solucon.dominio;

    public class Funcionario
    {
        // Fields
        private Funcao _funcao;

        // Properties
        public String Matricula { get; set; }
        public String Nome { get; set; }
        public DateTime Data_admissao { get; set; }
        public DateTime Data_demissao { get; set; }
        public String Num_CNH { get; set; }
        public String Classe_CNH { get; set; }
        public DateTime Vencto_CNH { get; set; }
        public Funcao Funcao
        {
            get { return _funcao; }
            set { _funcao = value; }
        }
        
        // Métodos
        public Funcionario()
        {
            _funcao = new Funcao();
        }
    }
}