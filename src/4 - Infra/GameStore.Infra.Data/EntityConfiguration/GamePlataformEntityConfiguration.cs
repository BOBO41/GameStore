using GameStore.Domain.Entities.ReleationshipEntities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace GameStore.Infra.Data.EntityConfiguration
{
    public class GamePlataformEntityConfiguration: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamePlataform>().HasKey(t => new { t.GameId, t.PlataformId });

            modelBuilder.Entity<GamePlataform>()
            .HasOne(gp => gp.Game)
            .WithMany(g => g.GamePlataforms)
            .HasForeignKey(gp => gp.GameId);

            modelBuilder.Entity<GamePlataform>()
                .HasOne(gp => gp.Plataform)
                .WithMany(g => g.GamePlataforms)
                .HasForeignKey(gp => gp.PlataformId);
        }
    }
}
