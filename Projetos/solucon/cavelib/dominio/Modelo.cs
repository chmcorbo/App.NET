/// <summary>
/// Classe de domínio de Modelo de veículo
/// </summary>
/// 

namespace Cave.Dominio.Veiculo
{
    using System;
    using Cave.Dominio.Veiculo;
    using Solucon.Dominio;

    public class Modelo : ClasseBase
    {
        // Fields
        private Marca _marca;

        //Properties
        public String Descricao { get; set; }
        public Marca Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        // Métodos
        public Modelo()
        {
            _marca = new Marca();
        }
        public override bool validarModel()
        {
            bool result = false;

            if ((this.Estado == Solucon.State.Stateobj.stNovo || this.Estado == Solucon.State.Stateobj.stEditar))
            {
                if (this.Descricao == "")
                    throw new EInvalidObjectClasseBase("Descrição do modelo não informado.");

                result = true;
            }
            else
                result = base.validarModel();
            return result;
        }

    }
}