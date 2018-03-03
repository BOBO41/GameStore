using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using GameStore.Domain.Entities;
using GameStore.Domain.Entities.ReleationshipEntities;
using System.Linq;
using System.Runtime.Serialization;
using GameStore.Application.DTOS.Games;

namespace GameStore.Application.ViewModels
{
    public class GameViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Score { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }

        private ICollection<GameDeveloper> GameDevelopers { get; set; }
        private ICollection<GamePlataform> GamePlataforms { get; set; }
        private ICollection<GameGenre> GameGenres { get; set; }
        private ICollection<GamePublisher> GamePublishers { get; set; }

        private IEnumerable<SelectGameDeveloperPublisherViewModel> _developers { get; set; }
        public IEnumerable<SelectGameDeveloperPublisherViewModel> Developers
        {
            get
            {
                if (GameDevelopers != null)
                    return GameDevelopers.Select(e => new SelectGameDeveloperPublisherViewModel{
                        Id = e.Developer.Id,
                        Name = e.Developer.Name,
                        Foundingdate = e.Developer.Foundingdate,
                        Country = e.Developer.Country   
                    });
                else
                    return _developers;
            }
        }
        private IEnumerable<SelectGameGenreViewModel> _genre { get; set; }
        public IEnumerable<SelectGameGenreViewModel> Genres
        {
            get
            {
                if (GameGenres != null)
                    return GameGenres.Select(e => new SelectGameGenreViewModel {
                        Id = e.Genre.Id,
                        Name = e.Genre.Name,
                        Description = e.Genre.Description
                    });
                else
                    return _genre;
            }
        }
        private IEnumerable<SelectGameDeveloperPublisherViewModel> _publishers;
        public IEnumerable<SelectGameDeveloperPublisherViewModel> Publishers
        {
            get
            {
                if (GamePublishers != null)
                    return GamePublishers.Select(e => new SelectGameDeveloperPublisherViewModel{
                        Id = e.Publisher.Id,
                        Name = e.Publisher.Name,
                        Foundingdate = e.Publisher.Foundingdate,
                        Country = e.Publisher.Country
                    });
                else
                    return _publishers;
            }

        }
        private IEnumerable<SelectGamePlataformViewModel> _plataforms { get; set; }
        public IEnumerable<SelectGamePlataformViewModel> Plataforms
        {
            get
            {
                if (GamePlataforms != null)
                    return GamePlataforms.Select(e => new SelectGamePlataformViewModel {
                        Id = e.Plataform.Id,
                        Name = e.Plataform.Name
                    });
                else
                    return _plataforms;
            }
        }
    }
}