﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using GameStore.Domain.Entities.Common;
using GameStore.Domain.Entities.ReleationshipEntities;

namespace GameStore.Domain.Entities
{
    public class Plataform: BaseEntity
    {
        public string Name { get; set; }
        public ICollection<GamePlataform> GamePlataforms { get; set; }

    }
}
