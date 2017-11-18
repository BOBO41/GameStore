using GameStore.Domain.Entities;
using GameStore.Domain.Entities.ReleationshipEntities;
using GameStore.Domain.Interfaces.Repositories;
using GameStore.Infra.Data.Context;
using GameStore.Infra.Data.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Infra.Data.Repositories
{
    public class GameRepository : Repository<Game>, IGameRepository
    {
        private GameStoreContext _db;
        public GameRepository(GameStoreContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Game> SearchByName(string search)
        {
            return _db.Games.Where(p => p.Name.Contains(search));
        }

        public override async Task<IEnumerable<Game>> GetAllAsync()
        {
            return await _db.Games.Include(x => x.GameDevelopers)
                .Include(x => x.GameGenres)
                .Include(x => x.GamePlataforms)
                .Include(x => x.GamePublishers)
                .ToListAsync();
        }
    }
}