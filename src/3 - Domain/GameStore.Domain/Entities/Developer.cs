using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Domain.Entities.Common;

namespace GameStore.Domain.Entities
{
    public class Developer: BaseEntity
    {
        public string Name { get; set; }
        public DateTime FoundedDate { get; set; }
        public string Country { get; set; }
    }
}
