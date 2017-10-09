﻿using System; 

namespace GameStore.Domain.Entities.ReleationshipEntities
{
    public class GameDeveloper
    {
        public int GameDeveloperId { get; set; }

        public Guid GameId { get; set; }
        public Game Game { get; set; }

        public Guid DeveloperId { get; set; }
        public Company Developer { get; set; }
    }
}
