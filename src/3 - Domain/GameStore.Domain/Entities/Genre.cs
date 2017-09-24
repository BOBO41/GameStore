using GameStore.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Domain.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Game> Games { get; set; }
    }
}
