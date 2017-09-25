using GameStore.Domain.Entities;
using GameStore.Infra.Data.Context;
using GameStore.Infra.Data.Repositories.Common;

namespace GameStore.Infra.Data.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(GameStoreContext db) : base(db)
        {
        }
    }
}