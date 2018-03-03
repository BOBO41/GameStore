using System;
using System.Collections.Generic;
using GameStore.Domain.Entities.ReleationshipEntities;

namespace GameStore.Application.DTOS.Games
{
    public class AddOrUpdateGameDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Score { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<GameDeveloper> GameDevelopers { get; set; }
        public ICollection<GamePlataform> GamePlataforms { get; set; }
        public ICollection<GameGenre> GameGenres { get; set; }
        public ICollection<GamePublisher> GamePublishers { get; set; }
    }
}