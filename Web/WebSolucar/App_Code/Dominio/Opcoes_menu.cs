/// <summary>
/// Summary description for Class1
/// </summary>

namespace cave.dominio
{
    using System;
    using solucon.dominio;

    public class Opcoes_menu : ClasseBase
    {
        // properties 
        public int Parent { get; set; }
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
