using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infra.Data.Context
{
    public class GameStoreContext: DbContext
    {
        public DbSet<Developer> Developer { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Plataform> Plataform { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<User> User { get; set; }
    }
}