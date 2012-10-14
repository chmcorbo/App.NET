namespace CorboLibUtils.Dominio
{
    using System;
    public interface IDAOBase
    {
        bool inserir(ClasseBase obj);
        bool excluir(ClasseBase obj);
        bool alterar(ClasseBase obj);
        bool buscarID(ClasseBase obj);
        bool validarDAO(ClasseBase obj);
        bool aplicar(ClasseBase obj);
    }
}
