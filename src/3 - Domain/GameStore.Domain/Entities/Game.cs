using GameStore.Domain.Entities.Common;
using System;
using System.Collections.Generic;

namespace GameStore.Domain.Entities
{
    public class Game : BaseEntity
    {
        public string Name { get; private set; }
        public DateTime ReleaseDate{ get; private set; }
        public int Rating { get; private set; }
        public long Score { get; private set; }
        public string Description { get; set; }
        public virtual IEnumerable<Plataform> Plataforms { get; private set; }
        public virtual IEnumerable<Genre> Genres { get; private set; }
        public virtual int DeveloperId { get; set; }
        public virtual Developer Developer { get; private set; }
        public virtual int PublisherId { get; set; }
        public virtual Publisher Publisher { get; private set; }
    }
}
