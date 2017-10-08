using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Domain.Entities.Common;
using GameStore.Domain.Entities.ReleationshipEntities;

namespace GameStore.Domain.Entities
{
    public class Plataform: BaseEntity
    {
        public string Name { get; set; }
        public virtual List<GamePlataform> GamePlataforms { get; set; }
    }
}
