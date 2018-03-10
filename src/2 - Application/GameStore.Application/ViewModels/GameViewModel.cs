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

        public IEnumerable<dynamic> Developers
        {
            get
            {
                return GameDevelopers.Select(e => new
                {
                    Id = e.Developer.Id,
                    Name = e.Developer.Name,
                    Foundingdate = e.Developer.Foundingdate,
                    Country = e.Developer.Country
                });
            }
        }
        public IEnumerable<dynamic> Genres
        {
            get
            {
                return GameGenres.Select(e => new
                {
                    Id = e.Genre.Id,
                    Name = e.Genre.Name,
                    Description = e.Genre.Description
                });
            }
        }
        public IEnumerable<dynamic> Publishers
        {
            get
            {
                return GamePublishers.Select(e => new
                {
                    Id = e.Publisher.Id,
                    Name = e.Publisher.Name,
                    Foundingdate = e.Publisher.Foundingdate,
                    Country = e.Publisher.Country
                });
            }
        }
        public IEnumerable<dynamic> Plataforms
        {
            get
            {
                return GamePlataforms.Select(e => new
                {
                    Id = e.Plataform.Id,
                    Name = e.Plataform.Name
                });
            }
        }
    }
}