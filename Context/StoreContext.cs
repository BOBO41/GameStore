using GameStore.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Context
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
        { 
            this.Database.EnsureCreated();
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}