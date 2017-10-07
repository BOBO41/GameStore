using GameStore.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        T GetById(Guid id);
        Task<T> GetByIdAsync(Guid id);
        void Add(T obj);
        void Update(T obj);
        void Remove(T obj);
    }
}