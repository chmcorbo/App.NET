using System;
using simples;

namespace WsSinapse.dominio
{
    public class Equipe : ClasseBase
    {
        public String Cod_Equipe { get; set; }
        public String Nome { get; set; }
        public Perfil_Equipe Perfil { get; set; }
        public Equipe()
        {
            Perfil = new Perfil_Equipe();
        }
    }
}
