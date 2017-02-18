using System.Collections.Generic;
using GameStore.Context;
using GameStore.Models;
using GameStore.Repositories;

namespace GameStore.Persistence.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly StoreContext _storeContext;

        public CompanyRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }
        public IEnumerable<Company> Companies => _storeContext.Companies;
    }
}