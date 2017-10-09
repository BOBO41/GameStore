using System;

namespace GameStore.Domain.Entities.ReleationshipEntities
{
    public class GamePlataform
    {
        public int GamePlataformId { get; set; }

        public Guid GameId { get; set; }
        public Game Game { get; set; }

        public Guid PlataformId { get; set; }
        public Plataform Plataform { get; set; }
    }
}
