using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using GameStore.Domain.Entities.Common;
using GameStore.Domain.Entities.ReleationshipEntities;

namespace GameStore.Domain.Entities
{
    public class Company: BaseEntity
    {
        public string Name { get; set; }
        public DateTime Foundingdate { get; set; }
        public string Country { get; set; }

        private ICollection<GameDeveloper> GameDevelopers { get; } = new List<GameDeveloper>();
        private ICollection<GamePublisher> GamePublishers { get; } = new List<GamePublisher>();
        [NotMapped]
        public IEnumerable<Game> DevelopedGames => GameDevelopers.Select(e => e.Game);
        [NotMapped]
        public IEnumerable<Game> PublishedGames => GamePublishers.Select(e => e.Game);
    }
}
