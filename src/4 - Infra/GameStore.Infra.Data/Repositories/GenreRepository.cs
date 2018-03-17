using System;
using System.Collections.Generic;
using System.Linq;
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

        public override async Task<Genre> GetByIdAsync(Guid id)
        {
            return await _db.Genres
                      .Include(_ => _.GameGenres)
                      .ThenInclude(_ => _.Game)
                      .Where(_ => _.Id == id)
                      .FirstOrDefaultAsync();
        }
    }
}