using GameStore.Domain.Entities.ReleationshipEntities;
using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace GameStore.Infra.Data.EntityConfiguration
{
    public class GameDeveloperEntityConfiguration : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameDeveloper>().HasKey(t => new { t.GameId, t.DeveloperId });

            modelBuilder.Entity<GameDeveloper>()
            .HasOne(gg => gg.Game)
            .WithMany(g => g.GameDevelopers)
            .HasForeignKey(gg => gg.GameId);

            modelBuilder.Entity<GameDeveloper>()
                .HasOne(gg => gg.Developer)
                .WithMany(g => g.DevelopedGames)
                .HasForeignKey(gg => gg.DeveloperId);
        }
    }
}
