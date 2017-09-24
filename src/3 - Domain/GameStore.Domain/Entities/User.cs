using GameStore.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Domain.Entities
{
    public class User: BaseEntity
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public IEnumerable<Genre> GenreInterests{ get; private set; }
        public IEnumerable<Game> WishsList { get; private set; }

        public bool IsVipMember()
        {
            return DateTime.Now.Year - this.CreatedDate.Year >= 5;
        }
    }
}
