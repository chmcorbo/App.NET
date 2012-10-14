namespace cave.dominio
{
    /// <summary>
    /// Summary description for Solucar
    /// </summary>
    ///

    using System;
    using solucon.dominio;
    using solucon.state;

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
    }
}




