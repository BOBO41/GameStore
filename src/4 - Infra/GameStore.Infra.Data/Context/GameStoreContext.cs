using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infra.Data.Context
{
    public class GameStoreContext: DbContext
    {
        public DbSet<Game> Games { get; set; }

    }
}