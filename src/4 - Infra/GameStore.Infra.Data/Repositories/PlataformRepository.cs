using GameStore.Domain.Entities;
using GameStore.Domain.Interfaces.Repositories;
using GameStore.Infra.Data.Context;
using GameStore.Infra.Data.Repositories.Common;

namespace GameStore.Infra.Data.Repositories
{
    public class PlataformRepository : Repository<Plataform>, IPlataformRepository
    {
        public PlataformRepository(GameStoreContext db) : base(db)
        {
        }
    }
}