using GameStore.Domain.Entities.ReleationshipEntities;
using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace GameStore.Infra.Data.EntityConfiguration
{
    public class GamePublisherEntityConfiguration : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamePublisher>().HasKey(t => new { t.GameId, t.PublisherId });

            modelBuilder.Entity<GamePublisher>()
            .HasOne(gg => gg.Game)
            .WithMany(g => g.GamePublishers)
            .HasForeignKey(gg => gg.GameId);

            modelBuilder.Entity<GamePublisher>()
                .HasOne(gg => gg.Publisher)
                .WithMany(g => g.PublishedGames)
                .HasForeignKey(gg => gg.PublisherId);
        }
    }
}
