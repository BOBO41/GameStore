using System;
using System.Linq;
using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infra.Data.EntityConfiguration
{
    public class GameEntityConfiguration: DbContext
    {
        public override int SaveChanges() {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedDate").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified )
                {
                    entry.Property("CreatedDate").IsModified = false;
                }
            }
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("LastUpdated") != null))
            {
                entry.Property("LastUpdated").CurrentValue = DateTime.Now;
            }
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Active") != null))
            {
                if (entry.State == EntityState.Added )
                {
                    entry.Property("Active").CurrentValue = 1;
                }
            }
            return base.SaveChanges();
        }
    }
}
