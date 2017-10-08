using GameStore.Domain.Entities;
using GameStore.Domain.Interfaces.Repositories;
using GameStore.Infra.Data.Context;
using GameStore.Infra.Data.Repositories.Common;

namespace GameStore.Infra.Data.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(GameStoreContext db) : base(db)
        {
        }
    }
}