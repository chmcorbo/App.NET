/// <summary>
/// Classe de domínio de segurança
/// </summary>
///

namespace Cave.Dominio.Seguranca
{
    using System;
    using Solucon.Dominio;

    public class Usuario : ClasseBase
    {
        //fields;
        private String _login;
        private String _nome;
        private String _senha;
        private Perfil_Usuario _perfil;
        
        //Properties;
        public String Login
        {
            get { return _login; }
            set { _login = value; }
        }
        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public String Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
        public Perfil_Usuario perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }

        public String Ativo { get; set; }

        //Métodos;
        public Usuario()
	    {
            _perfil = new Perfil_Usuario();
	    	//
	    	// TODO: Add constructor logic here
		    //
	    }

        public override bool validarModel()
        {
            bool result = false;

            if ((this.Estado == Solucon.State.Stateobj.stNovo || this.Estado == Solucon.State.Stateobj.stEditar))
            {
                if (this.Senha == "" || this.Senha == null)
                   this.Senha = "0000";

                if (this.Login == "")
                    throw new EInvalidObjectClasseBase("Login não informado");

                if (this.Nome == "")
                    throw new EInvalidObjectClasseBase("Nome do usuário não informado");

                if (this.Ativo == "")
                    throw new EInvalidObjectClasseBase("Situação do usuário não informada");

                if (this.perfil.ID == 0)
                    throw new EInvalidObjectClasseBase("Perfil de usuário não informado");

                result = true;
            }
            else
                result = base.validarModel();
            return result;
        }
    }
}




