using System;
using System.Collections.Generic;
using GameStore.Domain.Entities;

namespace GameStore.Application.ViewModels
{
    public class DeveloperViewModel
    {
        public string Name { get; set; }
        public DateTime FoundedDate { get; set; }
        public string Country { get; set; }
        public IEnumerable<Game> DevelopedGames { get; set; } 
    }
}