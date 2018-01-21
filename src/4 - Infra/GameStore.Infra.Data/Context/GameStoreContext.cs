using System;
using System.Linq;
using GameStore.Domain.Entities;
using GameStore.Domain.Entities.ReleationshipEntities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infra.Data.Context
{
    public class GameStoreContext : DbContext
    {

        public GameStoreContext(DbContextOptions<GameStoreContext> options)
        : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Plataform> Plataforms { get; set; }
        public DbSet<User> Users { get; set; }

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

            modelBuilder.Entity<GameGenre>().HasKey(t => new { t.GameId, t.GenreId });

            modelBuilder.Entity<GameGenre>()
            .HasOne(gg => gg.Game)
            .WithMany(g => g.GameGenres)
            .HasForeignKey(gg => gg.GameId);

            modelBuilder.Entity<GameGenre>()
                .HasOne(gg => gg.Genre)
                .WithMany(g => g.GameGenres)
                .HasForeignKey(gg => gg.GenreId);

                modelBuilder.Entity<GamePlataform>().HasKey(t => new { t.GameId, t.PlataformId });

            modelBuilder.Entity<GamePlataform>()
            .HasOne(gp => gp.Game)
            .WithMany(g => g.GamePlataforms)
            .HasForeignKey(gp => gp.GameId);

            modelBuilder.Entity<GamePlataform>()
                .HasOne(gp => gp.Plataform)
                .WithMany(g => g.GamePlataforms)
                .HasForeignKey(gp => gp.PlataformId);

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

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedDate").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreatedDate").IsModified = false;
                }
            }
            // foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Id") != null))
            // {
            //     if (entry.State == EntityState.Added)
            //     {
            //         var b = entry.Property("Id").CurrentValue;
            //         entry.Property("Id").CurrentValue = new Guid();
            //         var a = entry.Property("Id").CurrentValue;
            //     }
            // }
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("LastUpdated") != null))
            {
                entry.Property("LastUpdated").CurrentValue = DateTime.Now;
            }
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Active") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Active").CurrentValue = true;
                }
            }
            return base.SaveChanges();
        }

    }
}