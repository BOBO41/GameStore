using System;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IRepository<TEntity>: IDisposable where TEntity : class
    {
         IEnumerable<TEntity> GetAll();
         TEntity GetById(int id);
         void Add (TEntity obj);
         void Update(TEntity obj);
         void Remove (int id);
         int SaveChanges();
    }
}