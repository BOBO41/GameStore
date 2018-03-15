using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameStore.Domain.Entities;
using GameStore.Domain.Entities.ReleationshipEntities;
using GameStore.Domain.Interfaces.Repositories;
using GameStore.Infra.Data.Context;
using GameStore.Infra.Data.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infra.Data.Repositories
{
    public class ComapanyRepository : Repository<Company>, ICompanyRepository
    {
        private GameStoreContext _db;
        public ComapanyRepository(GameStoreContext db) : base(db)
        {
            _db = db;
        }

        public override async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await _db.Companies
                      .Include(_ => _.GameDevelopers)
                      .ThenInclude(_ => _.Game)
                      .Include(_ => _.GamePublishers)
                      .ThenInclude(_ => _.Game)
                      .ToListAsync();
        }

        public override async Task<Company> GetByIdAsync(Guid id)
        {
            return await _db.Companies
                      .Include(_ => _.GameDevelopers)
                      .ThenInclude(_ => _.Game)
                      .Where(_ => _.Id == id)
                      .FirstOrDefaultAsync();
        }
    }
}