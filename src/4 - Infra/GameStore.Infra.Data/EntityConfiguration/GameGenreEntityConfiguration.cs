using GameStore.Domain.Entities.ReleationshipEntities;
using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace GameStore.Infra.Data.EntityConfiguration
{
    public class GameGenreEntityConfiguration : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameGenre>().HasKey(t => new { t.GameId, t.GenreId });

            modelBuilder.Entity<GameGenre>()
            .HasOne(gg => gg.Game)
            .WithMany(g => g.GameGenres)
            .HasForeignKey(gg => gg.GameId);

            modelBuilder.Entity<GameGenre>()
                .HasOne(gg => gg.Genre)
                .WithMany(g => g.GameGenres)
                .HasForeignKey(gg => gg.GenreId);
        }
    }
}
