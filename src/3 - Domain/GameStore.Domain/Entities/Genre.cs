using GameStore.Domain.Entities.Common;
using GameStore.Domain.Entities.ReleationshipEntities;
using System.Collections.Generic;

namespace GameStore.Domain.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public virtual List<GameGenre> GameGenres { get; private set; }
    }
}
