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

        public ICollection<GameDeveloper> GameDevelopers { get; set;}
        public ICollection<GamePublisher> GamePublishers { get; set; }
    }
}
