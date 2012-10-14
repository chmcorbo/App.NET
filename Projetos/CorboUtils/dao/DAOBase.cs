namespace CorboLibUtils.DAO
{
    using Dominio;
    using System;
    using CorboLibUtils.State;

    /// <summary>
    /// Classe base para persistência de objetos;
    /// </summary>

    public abstract class DAOBase : IDAOBase
    {
        #region Fields 
        
        #endregion 

        #region Properties
        
        #endregion

        #region Métodos

        #endregion

        public DAOBase()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public abstract bool inserir(ClasseBase obj);
        public abstract bool alterar(ClasseBase obj);
        public abstract bool excluir(ClasseBase obj);
        public abstract bool buscarID(ClasseBase obj);
        public bool aplicar(ClasseBase obj)
        {
            bool resultado = true;
            if (validarDAO(obj))
            {
                switch (obj.Estado)
                {
                    case Stateobj.stNovo:
                        resultado = this.inserir(obj);
                        break;
                    case Stateobj.stEditar:
                        resultado = this.alterar(obj);
                        break;
                    case Stateobj.stExcluir:
                        resultado = this.excluir(obj);
                        break;
                }
            }
            else
                resultado = false;
            return resultado;
        }

        public virtual bool validarDAO(ClasseBase obj)
        {
            return true;
        }

    }
    public class EInvalidObjectDAOBase : System.Exception
    {
        public EInvalidObjectDAOBase()
        {
        }
        public EInvalidObjectDAOBase(string message)
            : base(message)
        {
        }
        public EInvalidObjectDAOBase(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }

}