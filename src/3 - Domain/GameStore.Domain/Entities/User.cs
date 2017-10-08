using GameStore.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Domain.Entities
{
    public class User: BaseEntity
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public IEnumerable<Genre> GenreInterests{ get; set; }
        public IEnumerable<Game> WishsList { get; set; }

        public bool IsVipMember()
        {
            return DateTime.Now.Year - this.CreatedDate.Year >= 5;
        }
    }
}
