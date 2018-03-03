using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using GameStore.Domain.Entities;
using GameStore.Domain.Entities.ReleationshipEntities;
using System.Linq;

namespace GameStore.Application.ViewModels
{
    public class GameViewModel
    {
        [Required(ErrorMessage = "Required field")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Score { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }


        [Required(ErrorMessage = "Developer(s) required")]
        private ICollection<GameDeveloper> GameDevelopers { get; set; }
        private ICollection<GamePlataform> GamePlataforms { get; set; }
        private ICollection<GameGenre> GameGenres { get; set; }
        private ICollection<GamePublisher> GamePublishers { get; set; }

        private IEnumerable<Company> _developers { get; set; }
        public IEnumerable<Company> Developers
        {
            get
            {
                if (GameDevelopers != null)
                    return GameDevelopers.Select(e => e.Developer);
                else
                    return _developers;
            }
        }
        private IEnumerable<Genre> _genre { get; set; }
        public IEnumerable<Genre> Genres
        {
            get
            {
                if (GameGenres != null)
                    return GameGenres.Select(e => e.Genre);
                else
                    return _genre;
            }
        }
        private IEnumerable<Company> _publishers;
        public IEnumerable<Company> Publishers
        {
            get
            {
                if (GamePublishers != null)
                    return GamePublishers.Select(e => e.Publisher);
                else
                    return _publishers;
            }

        }
        private IEnumerable<Plataform> _plataforms { get; set; }
        public IEnumerable<Plataform> Plataforms
        {
            get
            {
                if (GamePlataforms != null)
                    return GamePlataforms.Select(e => e.Plataform);
                else
                    return _plataforms;
            }

        }

    }
}