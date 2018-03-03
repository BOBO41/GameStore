using System;

namespace GameStore.Application.DTOS.Games
{
    public class SelectGameDeveloperPublisherViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Foundingdate { get; set; }
        public string Country { get; set; }
    }
}