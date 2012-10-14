
/// <summary>
/// Classe de domínio para montagem de menu de opçõess
/// </summary>
/// 
namespace Cave.Dominio
{
    using System;
    using Cave.Dominio.Seguranca;
     using Solucon.Dominio;

    public class Opcoes_Menu_Perfil
    {
        // Fiels
        Perfil_Usuario _perfil_usuario;
        Opcoes_menu _opcoes_menu;
        
        // Properties
        public Perfil_Usuario Perfil_usuario
        {
            get { return _perfil_usuario; }
            set { _perfil_usuario = value; }
        }
        public Opcoes_menu Opcoes_menu
        {
            get { return _opcoes_menu; }
            set { _opcoes_menu = value; }
        }

        // Métodos
        public Opcoes_Menu_Perfil()
        {
            _perfil_usuario = new Perfil_Usuario();
            _opcoes_menu = new Opcoes_menu();
        }
    }
}