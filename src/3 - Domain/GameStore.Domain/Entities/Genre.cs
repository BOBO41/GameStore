using GameStore.Domain.Entities.Common;
using GameStore.Domain.Entities.ReleationshipEntities;
using System.Collections.Generic;

namespace GameStore.Domain.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<GameGenre> GameGenres { get; set; }
    }
}
