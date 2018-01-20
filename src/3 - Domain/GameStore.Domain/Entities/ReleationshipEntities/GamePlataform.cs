using System;

namespace GameStore.Domain.Entities.ReleationshipEntities
{
    public class GamePlataform
    {
        public Guid GameId { get; set; }
        public Game Game { get; set; }

        public Guid PlataformId { get; set; }
        public Plataform Plataform { get; set; }
    }
}
