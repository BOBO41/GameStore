using System.Collections.Generic;
using GameStore.Models;

namespace GameStore.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}