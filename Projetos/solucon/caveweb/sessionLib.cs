using System;
using System.Web.UI;
using System.Web.SessionState;
using Solucon.Dominio;

namespace Solucon.web
{
    public static class Secao
    {
        public static ClasseBase carregar(HttpSessionState SecaoEstado, String nome)
        {
            Object obj = SecaoEstado[nome];
            return obj as ClasseBase;
        }

    }
}
