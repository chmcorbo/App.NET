using simples;

namespace simples
{

  /// <summary>
  /// Classe de persistência simples;
  /// </summary>

    public abstract class DAOBase
    {
        public abstract void inserir(ClasseBase obj);
        public abstract void excluir(ClasseBase obj);
        public abstract void alterar(ClasseBase obj);
        public abstract bool buscarID(ClasseBase obj);
        public virtual bool aplicar(ClasseBase obj)
        {
            bool resultado = true;
            switch (obj.State)
            {
                case StateObj.stNovo:
                    this.inserir(obj);
                    break;
                case StateObj.stEditar:
                    this.alterar(obj);
                    break;
                case StateObj.stExcluir:
                    this.excluir(obj);
                    break;
            }
            return resultado;
        }
        //public abstract vector pesquisa(ClasseBase obj);    
        public DAOBase()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}
