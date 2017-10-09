using System;

namespace GameStore.Domain.Entities.ReleationshipEntities
{
    public class GamePublisher
    {
        public int GamePublisherId { get; set; }

        public Guid GameId { get; set; }
        public Game Game { get; set; }

        public Guid PublisherId { get; set; }
        public Company Publisher { get; set; }
    }
}
