using GameStore.Domain.Entities.Common;
using System;
using System.Collections.Generic;

namespace GameStore.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Add(T obj);
        void Update(T obj);
        void Remove(T obj);
    }
}