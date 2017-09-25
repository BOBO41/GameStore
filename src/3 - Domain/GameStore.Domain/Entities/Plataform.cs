using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Domain.Entities.Common;

namespace GameStore.Domain.Entities
{
    public class Plataform: BaseEntity
    {
        public string Name { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public virtual Developer Developer { get; private set; }
        public virtual IEnumerable<Game> Games { get; private set; }
    }
}
