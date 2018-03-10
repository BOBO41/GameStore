using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Application.DTOS.Genres;
using GameStore.Domain.Entities;
using GameStore.Domain.Entities.ReleationshipEntities;

namespace GameStore.Application.ViewModels
{
    public class GenreViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        private ICollection<GameGenre> GameGenres { get; set; }

        public IEnumerable<dynamic> GamesOfThisGenre
        {
            get
            {
                return GameGenres.Select(e => new
                {
                    Id = e.Game.Id,
                    Name = e.Game.Name,
                });
            }
        }
    }
}