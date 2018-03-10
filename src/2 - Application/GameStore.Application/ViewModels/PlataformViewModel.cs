using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Application.DTOS.Genres;
using GameStore.Domain.Entities;
using GameStore.Domain.Entities.ReleationshipEntities;

namespace GameStore.Application.ViewModels
{
    public class PlataformViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        private ICollection<GamePlataform> GamePlataforms { get; set; }

        public IEnumerable<dynamic> GamesOfThisPlataform
        {
            get
            {
                return GamePlataforms.Select(e => new
                {
                    Id = e.Game.Id,
                    Name = e.Game.Name,
                });
            }
        }
    }
}