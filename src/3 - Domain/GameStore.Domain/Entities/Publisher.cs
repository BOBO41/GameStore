using GameStore.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Domain.Entities
{
    public class Publisher: BaseEntity
    {
        public string Name { get; private set; }
        public string Country { get; private set; }
        public DateTime FoundedDate { get; private set; }

        public List<Game> PublishedGames { get; private set; }
    }
}
