using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using GameStore.Domain.Entities;
using GameStore.Domain.Entities.ReleationshipEntities;

namespace GameStore.Application.ViewModels
{
    public class GameViewModel
    {
        [Required(ErrorMessage = "Required field")]
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Score { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }

        public virtual List<GamePlataform> GamePlataforms { get; set; }

        public virtual List<GameGenre> GameGenres { get; set; }
        public virtual List<GameDeveloper> GameDevelopers { get; set; }
        public virtual List<GamePublisher> GamePublishers { get; set; }

    }
}