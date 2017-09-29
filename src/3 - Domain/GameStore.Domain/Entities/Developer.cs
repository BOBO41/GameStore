using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Domain.Entities.Common;

namespace GameStore.Domain.Entities
{
    public class Developer: BaseEntity
    {
        public string Name { get; private set; }
        public DateTime FoundedDate { get; private set; }
        public string Country { get; private set; }

        public List<Game> DevelopedGames { get; private set; }
    }
}
