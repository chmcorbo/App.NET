namespace CFuelCorboLib.dominio.security
{
    using System;
    using CorboLibUtils.Dominio;

    public class Usuario : ClasseBase
    {
        // propriedades
        public String login { get; set; }
        public String nome { get; set; }
        public String senha { get; set; }
        public Boolean administrador { get; set; }
        // Métodos
        public override bool validarModel()
        {
            bool result = false;

            if ((this.Estado == CorboLibUtils.State.Stateobj.stNovo || this.Estado == CorboLibUtils.State.Stateobj.stEditar))
            {
                if (this.ID == 0)
                    throw new EInvalidObjectClasseBase("ID do usuário não informado");

                if (this.login == String.Empty)
                    throw new EInvalidObjectClasseBase("Login não informado");

                if (this.nome == String.Empty)
                    throw new EInvalidObjectClasseBase("Nome do usuário não informado");

                if (this.senha == String.Empty)
                    throw new EInvalidObjectClasseBase("Senha do usuário não informado");

                result = true;
            }
            else
                result = base.validarModel();
            return result;
        }
    }
}
