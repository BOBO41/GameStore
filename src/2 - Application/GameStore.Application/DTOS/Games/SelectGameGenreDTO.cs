using System;

namespace GameStore.Application.DTOS.Games
{
    public class SelectGameGenreDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
    }
}