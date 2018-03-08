using System.Collections.Generic;
using System.Threading.Tasks;
using GameStore.Domain.Entities;
using GameStore.Domain.Interfaces.Repositories;
using GameStore.Infra.Data.Context;
using GameStore.Infra.Data.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infra.Data.Repositories
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        private GameStoreContext _db;
        public GenreRepository(GameStoreContext db) : base(db)
        {
            _db = db;
        }

        public override async Task<IEnumerable<Genre>> GetAllAsync() {
            return await  _db.Genres
                            .Include(x => x.GameGenres)
                            .ThenInclude(x => x.Game)
                            .ToListAsync();
        }
    }
}