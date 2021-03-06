using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Domain.Interface.Repository
{
    public interface IBaseRepository<T, TId> where T : class
    {
        T GetById(TId id);
        IList<T> GetAll();
        T Salvar(T t);
        T Atualizar(T t);
        T Deletar(TId id);
    }
}
