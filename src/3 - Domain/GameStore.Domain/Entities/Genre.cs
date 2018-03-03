using GameStore.Domain.Entities.Common;
using GameStore.Domain.Entities.ReleationshipEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace GameStore.Domain.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private ICollection<GameGenre> GameGenres { get; } = new List<GameGenre>();
        [NotMapped]
        public IEnumerable<Game> GamesOfThisGenre => GameGenres.Select(e => e.Game);
    }
}
