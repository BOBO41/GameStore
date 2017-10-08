using System;

namespace GameStore.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate{ get; set; }
        public DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
    }
}
