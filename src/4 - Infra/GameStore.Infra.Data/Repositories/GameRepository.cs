using GameStore.Domain.Entities;
using GameStore.Domain.Interfaces;
using GameStore.Infra.Data.Context;
using GameStore.Infra.Data.Repositories.Common;

namespace GameStore.Infra.Data.Repositories
{
    public class GameRepository : Repository<Game>, IGameRepository
    {
        public GameRepository(GameStoreContext db) : base(db)
        {
        }
    }
}