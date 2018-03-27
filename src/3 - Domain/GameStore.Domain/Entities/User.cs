using GameStore.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GameStore.Domain.Entities
{
    public class User: BaseEntity
    {
        [Key]
        public string UserId { get; set; }
        public string Name { get; set; }
        public string AccessKey { get; set; }
        public DateTime BirthDate { get; set; }
        public IEnumerable<Genre> GenreInterests{ get; set; }
        public IEnumerable<Game> WishsList { get; set; }

        public bool IsVipMember()
        {
            return DateTime.Now.Year - this.CreatedDate.Year >= 5;
        }
    }
}
