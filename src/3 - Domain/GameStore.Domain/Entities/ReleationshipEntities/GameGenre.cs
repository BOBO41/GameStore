﻿using System;

namespace GameStore.Domain.Entities.ReleationshipEntities
{
    public class GameGenre
    {
        public Guid GameId { get; set; }
        public Game Game { get; set; }

        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
