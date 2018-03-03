using System;
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
        private ICollection<GamePlataform> GamePlataforms { get; } = new List<GamePlataform>();
        [NotMapped]
        public IEnumerable<Game> GamesOfThisPlataform => GamePlataforms.Select(e => e.Game);
    }
}
