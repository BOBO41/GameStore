using GameStore.Domain.Entities.Common;
using GameStore.Domain.Entities.ReleationshipEntities;
using System;
using System.Collections.Generic;

namespace GameStore.Domain.Entities
{
    public class Game : BaseEntity
    {
        public string Name { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public int Rating { get; private set; }
        public long Score { get; private set; }
        public string Description { get; private set; }

        public virtual List<GamePlataform> GamePlataforms { get; private set; }

        public virtual List<GameGenre> GameGenres { get; private set; }

        public Guid DeveloperId { get; private set; }
        public virtual Developer Developer { get; private set; }

        public Guid PublisherId { get; private set; }
        public virtual Publisher Publisher { get; private set; }

        public static Game NewInstance(string name, DateTime releaseDate, int rating, long score, string description, List<GamePlataform> plataforms, List<GameGenre> gameGenres, int developerId, Developer developer, int publisherId, Publisher publisher)
        {
            return new Game()
            {
                Name = name,
                ReleaseDate = releaseDate,
                Rating = rating,
                Score = score,
                Description = description,
                GamePlataforms = plataforms,
                GameGenres = gameGenres,
                Developer = developer,
                Publisher = publisher,
            };
        }
    }
}
