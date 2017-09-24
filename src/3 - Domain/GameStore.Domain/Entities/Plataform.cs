using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Domain.Entities
{
    public class Plataform
    {
        public string Name { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public virtual Developer Developer { get; private set; }
        public virtual IEnumerable<Game> Games { get; private set; }
    }
}
