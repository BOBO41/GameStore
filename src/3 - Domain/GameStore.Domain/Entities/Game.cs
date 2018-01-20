using GameStore.Domain.Entities.Common;
using GameStore.Domain.Entities.ReleationshipEntities;
using System;
using System.Collections.Generic;

namespace GameStore.Domain.Entities
{
    public class Game : BaseEntity
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Score { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<GamePlataform> GamePlataforms { get; set; }
        public ICollection<GameGenre> GameGenres { get; set; }
        public ICollection<GameDeveloper> GameDevelopers { get; set; }
        public ICollection<GamePublisher> GamePublishers { get; set; }


        public static Game NewInstance(string name, DateTime releaseDate, int rating, long score, string description, List<GamePlataform> plataforms, List<GameGenre> gameGenres, int developerId, List<GameDeveloper> gamedevelopers, int publisherId, List<GamePublisher> gamepublishers)
        {
            return new Game()
            {
                Name = name,
                ReleaseDate = releaseDate,
                Score = score,
                Description = description,
                GamePlataforms = plataforms,
                GameGenres = gameGenres,
                GameDevelopers = gamedevelopers,
                GamePublishers = gamepublishers,
            };
        }
    }
}
