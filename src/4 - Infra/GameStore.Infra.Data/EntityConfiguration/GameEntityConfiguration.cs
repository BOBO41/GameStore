using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infra.Data.EntityConfiguration
{
    public class GameEntityConfiguration: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasOne(g => g.Developer).WithMany(d => d.DevelopedGames).HasForeignKey(g=> g.DeveloperId);

            modelBuilder.Entity<Game>().HasOne(g => g.Publisher).WithMany(p => p.PublishedGames).HasForeignKey(g => g.PublisherId);
        }
    }
}
