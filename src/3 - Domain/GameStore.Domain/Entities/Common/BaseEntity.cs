﻿using System;

namespace GameStore.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; private set; }
        public DateTime CreatedDate{ get; private set; }
        public DateTime LastUpdated { get; private set; }
        public bool Active { get; private set; }
    }
}
