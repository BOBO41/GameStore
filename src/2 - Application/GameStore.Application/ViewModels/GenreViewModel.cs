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

        private IEnumerable<SelectGenreGameDTO> _games {get;set;}
        public IEnumerable<SelectGenreGameDTO> DevelopedGames { 
            get
            {
                if (GameGenres != null)
                    return GameGenres.Select(e => new SelectGenreGameDTO{
                        Id = e.Game.Id,
                        Name = e.Game.Name,
                    });
                else
                    return _games;
            }
        } 
    }
}