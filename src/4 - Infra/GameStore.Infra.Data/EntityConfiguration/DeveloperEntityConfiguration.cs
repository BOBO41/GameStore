using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infra.Data.EntityConfiguration
{
    public class DeveloperEntityConfiguration: DbContext
    {
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Developer>().HasMany(d => d.DevelopedGames).WithOne();
        }
    }
}
