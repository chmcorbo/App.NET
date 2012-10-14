
/// <summary>
/// Classe de domínio para montagem de menu de opçõess
/// </summary>
/// 

namespace Cave.Dominio
{
    using System;
    using Solucon.Dominio;

    public class Opcoes_menu : ClasseBase
    {
        // properties 
        public int? Parent { get; set; }
        public String Nome { get; set; }
        public String Tooltip { get; set; }
        public String Url { get; set; }
        public bool Separator { get; set; }
        // Métodos
 
        public Opcoes_menu()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}
