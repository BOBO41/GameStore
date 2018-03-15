using System.Collections.Generic;
using System.Threading.Tasks;
using GameStore.Domain.Entities;
using GameStore.Domain.Interfaces.Repositories;
using GameStore.Infra.Data.Context;
using GameStore.Infra.Data.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infra.Data.Repositories
{
    public class PlataformRepository : Repository<Plataform>, IPlataformRepository
    {
        private GameStoreContext _db;
        public PlataformRepository(GameStoreContext db) : base(db)
        {
            _db = db;
        }

        public override async Task<IEnumerable<Plataform>> GetAllAsync() {
            return await  _db.Plataforms
                            .Include(x => x.GamePlataforms)
                            .ThenInclude(x => x.Game)
                            .ToListAsync();
        }
    }
}