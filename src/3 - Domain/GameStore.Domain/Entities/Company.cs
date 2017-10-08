using System;
using System.Collections.Generic;
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

        public List<GameDeveloper> DevelopedGames { get; set; }

        public List<GamePublisher> PublishedGames { get; set; }
    }
}
