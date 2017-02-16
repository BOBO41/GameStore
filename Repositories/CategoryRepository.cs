using System.Collections.Generic;
using GameStore.Context;
using GameStore.Models;

namespace GameStore.Repositories
{
    class CategoryRepository : ICategoryRepository
    {
        private readonly StoreContext _storeContext;

        public CategoryRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public IEnumerable<Category> Categories  => _storeContext.Categories;
    }
}