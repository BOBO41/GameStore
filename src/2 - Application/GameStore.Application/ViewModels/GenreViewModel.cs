using System.Collections.Generic;
using GameStore.Domain.Entities;

namespace GameStore.Application.ViewModels
{
    public class GenreViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Game> GamesOfThisGenre { get; set; }
    }
}