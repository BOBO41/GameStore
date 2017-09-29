using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Infra.Data.EntityConfiguration
{
    class PublisherEntityConfiguration: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publisher>().HasMany(p => p.PublishedGames).WithOne();
        }
    }
}
