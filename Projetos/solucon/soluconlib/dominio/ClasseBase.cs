namespace Solucon.Dominio
{
    using Solucon.State;

    /// <summary>
    /// Summary description for Solucar
    /// </summary>
    /// 

    public abstract class ClasseBase
    {
        #region Fields
        private int _id;
        #endregion 
        
        #region Properties

        public Stateobj Estado {get; set;}

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        #endregion

        #region Métodos
        public ClasseBase()
        {
            Estado = Stateobj.stNovo;
        }
     
        public void novo()
        {
            Estado = Stateobj.stNovo;
        }

        public void editar()
        {
            Estado = Stateobj.stEditar;
        }

        public void deletar()
        {
            Estado = Stateobj.stExcluir;
        }

        public virtual bool validarModel()
        {
            return true;
        }

        public bool aplicar(IDAOBase daoObj)
        {
            bool resultado = true;
            if (validarModel())
                resultado = daoObj.aplicar(this);
            return resultado;
        }
        #endregion
    }
    public class EInvalidObjectClasseBase : System.Exception
    {
        public EInvalidObjectClasseBase()
        {
        }
        public EInvalidObjectClasseBase(string message)
            : base(message)
        {
        }
        public EInvalidObjectClasseBase(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}