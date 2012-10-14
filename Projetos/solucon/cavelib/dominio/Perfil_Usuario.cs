/// <summary>
/// Classe de domínio Perfil de usuário
/// </summary>
///


namespace Cave.Dominio.Seguranca
{

    using System;
    using System.Collections.Generic;
    using Solucon.Dominio;

    /// <summary>
    /// Perfil_Usuario
    /// </summary>
    public class Perfil_Usuario : ClasseBase
    {
        // Fields
        private String fnome;
        private List<Usuario> _listaUsuarios;

        // Properties;
        public String Nome
        {
            get { return (fnome); }
            set { fnome = value; }
        }
        public List<Usuario> ListaUsuarios
        {
            get { return _listaUsuarios; }
            set { _listaUsuarios = value; }
        }

        // Métodos;
        public Perfil_Usuario()
        {
            _listaUsuarios = new List<Usuario>();
        }
        public void CarregaListaUsuarios()
        {
            Usuario usuario = new Usuario();
            usuario.ID=1;
            usuario.Login="chmeireles";
            usuario.Nome="CARLOS HENRIQUE MEIRELES";
            ListaUsuarios.Add(usuario);
            
            usuario.ID = 2;
            usuario.Login = "tiagonm";
            usuario.Nome = "TIAGO DO NASCIMENTO";
            ListaUsuarios.Add(usuario);
            
            usuario.ID = 3;
            usuario.Login = "rbvieira";
            usuario.Nome = "RAPHAEL BRUNO VIEIRA";
            ListaUsuarios.Add(usuario);
        }
    }
}
