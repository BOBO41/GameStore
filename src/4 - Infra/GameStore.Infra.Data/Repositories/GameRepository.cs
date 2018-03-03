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

        public async Task<IEnumerable<dynamic>> GetAllGamesWithDevelopersAsync()
        {
            var query = from game in _db.Games
                        select new { game };

            return await query.ToListAsync();
        }

        public override async Task<IEnumerable<Game>> GetAllAsync()
        {
            var list = await _db.Games
                      .Include(g => g.GameDevelopers)
                      .ThenInclude(g => g.Developer)
                      .Include(g => g.GameGenres)
                      .ThenInclude(g => g.Genre)
                      .Include(g => g.GamePlataforms)
                      .ThenInclude(g => g.Plataform)
                      .Include(g => g.GamePublishers)
                      .ThenInclude(g => g.Publisher)
                      .ToListAsync();

            return list;
        }
    }
}