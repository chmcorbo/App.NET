using System;

/// <summary>
/// Summary description for Solucar
/// </summary>
/// 

namespace simples
{
    enum StateObj
    {
        stNovo,
        stEditar,
        stExcluir,
        stLimpo
    }

    public abstract class ClasseBase
    {
        // fields
        private StateObj state;

        internal StateObj State
        {
            get { return state; }
        }
        // Properties
        // Métodos
        /** Creates a new instance of ClasseBase */
        public ClasseBase()
        {
            state = StateObj.stLimpo;
        }

        public void novo()
        {
            state = StateObj.stNovo;
        }

        public void editar()
        {
            state = StateObj.stEditar;
        }

        public void deletar()
        {
            state = StateObj.stExcluir;
        }
    }
}