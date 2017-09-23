using System;
using System.Collections.Generic;

namespace GameStore.Domain.Interfaces
{
    public interface IRepository<T>: IDisposable where T : class
    {
        IEnumerable<T> GetAll();
         T GetById(int id);
         void Add (T obj);
         void Update(T obj);
         void Delete (int id);
    }
}