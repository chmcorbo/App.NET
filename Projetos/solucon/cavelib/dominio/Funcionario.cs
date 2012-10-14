/// <summary>
/// Classe de domínio de funcionário;
/// </summary>
/// 

namespace Cave.Dominio.RH
{
    using System;
    using Solucon.Dominio;

    public class Funcionario : ClasseBase
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
        public override bool validarModel()
        {
            bool result = false;

            if (this.Estado == Solucon.State.Stateobj.stNovo || this.Estado == Solucon.State.Stateobj.stEditar)
            {
                if (this.Nome == "")
                    throw new EInvalidObjectClasseBase("Matrícula do funcionário não informado");
                if (this.Nome == "")
                    throw new EInvalidObjectClasseBase("Nome do funcionário não informado");
                if (this.Funcao.ID == 0)
                    throw new EInvalidObjectClasseBase("Função não associado ao funcionário");
                if (!Solucon.DataHora.DataLib.Empty(this.Data_demissao) && this.Data_admissao>this.Data_demissao)
                    throw new EInvalidObjectClasseBase("A data de admissão não pode ser superior a data de demissão");

            }
            result = base.validarModel();
            return result;
        }
    }
}