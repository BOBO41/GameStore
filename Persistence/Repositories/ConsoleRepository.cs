using System.Collections.Generic;
using System.Linq;
using GameStore.Context;
using GameStore.Models;
using GameStore.Repositories;

namespace GameStore.Persistence.Repositories
{
    public class ConsoleRepository : IConsoleRepository
    {
        private readonly StoreContext _storeContext;

        public ConsoleRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public IEnumerable<Console> Consoles => _storeContext.Consoles;

        public IEnumerable<Console> ConsolesFromCompany(string producer)
        {
            return _storeContext.Consoles.Where(_ => _.Producer == producer);
        }
    }
}