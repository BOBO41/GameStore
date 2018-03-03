using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Application.DTOS.Developers;
using GameStore.Domain.Entities;
using GameStore.Domain.Entities.ReleationshipEntities;

namespace GameStore.Application.ViewModels
{
    public class DeveloperViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundedDate { get; set; }
        public string Country { get; set; }

        private ICollection<GameDeveloper> GameDevelopers { get; set; }

        private IEnumerable<SelectDeveloperGameDTO> _games {get;set;}
        public IEnumerable<SelectDeveloperGameDTO> DevelopedGames { 
            get
            {
                if (GameDevelopers != null)
                    return GameDevelopers.Select(e => new SelectDeveloperGameDTO{
                        Id = e.Game.Id,
                        Name = e.Game.Name,
                    });
                else
                    return _games;
            }
        } 
    }
}