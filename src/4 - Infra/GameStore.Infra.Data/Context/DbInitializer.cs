using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Domain.Entities;
using GameStore.Domain.Entities.ReleationshipEntities;
using Microsoft.Extensions.Configuration;

namespace GameStore.Infra.Data.Context
{
    public static class DbInitializer
    {
        public static IConfigurationRoot Configuration { get; set; }

        public static void Initialize(GameStoreContext context)
        {
            // context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            // Look for any games.
            if (context.Games.Any())
            {
                return;   // DB has been seeded
            }

            var developers = new Company[]
            {
                new Company() { Id = new Guid("{3a332845-6a75-48f9-b7bf-5427570f8d9a}"),
                Name = "Square Enix", Country = "Japan", Foundingdate = new DateTime(1975,9,22) },
                new Company() { Id = new Guid("{0a2a7f09-6ddd-4bfe-8e90-77078722336e}"),
                Name = "Rockstar Games", Country = "EUA", Foundingdate = new DateTime(1998,12,1) },
                new Company() { Id = new Guid("{4cb6f093-ad07-461c-a06e-2397c085da24}"),
                Name = "Ubisoft", Country = "France", Foundingdate = new DateTime(1986,3,1) }
            };
            foreach (Company s in developers)
            {
                context.Companies.Add(s);
            }

            var plataforms = new Plataform[]
            {
                new Plataform() { Id = new Guid("{d64c2f9d-7a4e-423d-bc1c-28f50387b3ad}"),
                Name = "Playstation 4"},
                new Plataform() { Id = new Guid("{173f056c-0ddf-4581-a32d-f84109fd8145}"),
                Name = "Xbox One"},
                new Plataform() { Id = new Guid("{16df4c17-7f30-4fff-a90e-b379eb720f3f}"),
                Name = "PC"},
                new Plataform() { Id = new Guid("{2f2e3bfc-ac34-4248-a2ed-6da69648ef97}"),
                Name = "Nintendo Switch"}
            };
            foreach (Plataform s in plataforms)
            {
                context.Plataforms.Add(s);
            }

            var genres = new Genre[]
            {
                new Genre() { Id = new Guid("{93e7acd0-747c-4468-8ff8-f3172f5ace06}"),
                Name = "RPG"},
                new Genre() { Id = new Guid("{8a2593d7-7ae1-4a0a-89e4-a9aaeaba8074}"),
                Name = "Action"},
                new Genre() { Id = new Guid("{089345b7-8ee8-4290-b840-5d0e20aba317}"),
                Name = "Shooter"},
                new Genre() { Id = new Guid("{2e58aa56-b10a-4452-9058-b90aa1fba50f}"),
                Name = "Strategy"}
            };
            foreach (Genre s in genres)
            {
                context.Genres.Add(s);
            }

            //Mounting Lists -- Temporary resolvers object reference problems

            //FF
            List<GameDeveloper> _gameDevelopersFF = new List<GameDeveloper>();
            _gameDevelopersFF.Add(new GameDeveloper() {
                DeveloperId = new Guid("{3a332845-6a75-48f9-b7bf-5427570f8d9a}") });
            List<GamePublisher> _gamesPublishedFF = new List<GamePublisher>();
            _gamesPublishedFF.Add(new GamePublisher() {
                PublisherId = new Guid("{3a332845-6a75-48f9-b7bf-5427570f8d9a}") });
            List<GameGenre> _gameGenresFF = new List<GameGenre>();
            _gameGenresFF.Add(new GameGenre() { GenreId = new Guid("{93e7acd0-747c-4468-8ff8-f3172f5ace06}") });
            List<GamePlataform> _gamePlataformsFF = new List<GamePlataform>();
            _gamePlataformsFF.Add(new GamePlataform() { PlataformId = new Guid("{d64c2f9d-7a4e-423d-bc1c-28f50387b3ad}") });


            //GTA
            List<GameDeveloper> _gameDevelopersGta = new List<GameDeveloper>();
            _gameDevelopersGta.Add(new GameDeveloper()
            { DeveloperId = new Guid("{0a2a7f09-6ddd-4bfe-8e90-77078722336e}") });
            List<GamePublisher> _gamesPublishedGta = new List<GamePublisher>();
            _gamesPublishedGta.Add(new GamePublisher()
            { PublisherId = new Guid("{0a2a7f09-6ddd-4bfe-8e90-77078722336e}") });
            List<GameGenre> _gameGenresGta = new List<GameGenre>();
            _gameGenresGta.Add(new GameGenre() { GenreId = new Guid("{8a2593d7-7ae1-4a0a-89e4-a9aaeaba8074}") });
            List<GamePlataform> _gamePlataformsGta = new List<GamePlataform>();
            _gamePlataformsGta.Add(new GamePlataform() { PlataformId = new Guid("{173f056c-0ddf-4581-a32d-f84109fd8145}") });


            //CoL
            List<GameDeveloper> _gameDevelopersCoL = new List<GameDeveloper>();
            _gameDevelopersCoL.Add(new GameDeveloper()
            { DeveloperId = new Guid("{4cb6f093-ad07-461c-a06e-2397c085da24}") });
            List<GamePublisher> _gamesPublishedCoL = new List<GamePublisher>();
            _gamesPublishedCoL.Add(new GamePublisher()
            { PublisherId = new Guid("{4cb6f093-ad07-461c-a06e-2397c085da24}") });
            List<GameGenre> _gameGenresCoL = new List<GameGenre>();
            _gameGenresCoL.Add(new GameGenre() { GenreId = new Guid("{93e7acd0-747c-4468-8ff8-f3172f5ace06}") });
            List<GamePlataform> _gamePlataformsCoL = new List<GamePlataform>();
            _gamePlataformsCoL.Add(new GamePlataform() { PlataformId = new Guid("{16df4c17-7f30-4fff-a90e-b379eb720f3f}") });


            var games = new Game[]
            {
                new Game() { Id = new Guid(), Name = "Final Fantasy XV",
                ShortDescription = "an open world action role-playing video game developed "
                +"and published by Square Enix", Score = 9.8, Price = 89.99,
                Description = "Final Fantasy XV takes place on the fictional world of Eos. "
                +"All the world's countries,bar the kingdom of Lucis, are under the dominion of"
                +"the empire of Niflheim. Noctis Lucis Caelum, heir to the Lucian throne, goes on"
                +"a quest to retake his homeland and its magical Crystal ",
                ReleaseDate = new DateTime(2016,11,9), ImageUrl = @"http://localhost/gamestore/images/ffxv.jpg",
                GameDevelopers = _gameDevelopersFF,
                GamePublishers = _gamesPublishedFF,
                GameGenres = _gameGenresFF,
                GamePlataforms = _gamePlataformsFF
                },
                new Game() { Id = new Guid(), Name = "Grand Theft Auto V",
                ShortDescription = "the single-player story follows three criminals and their efforts to commit "
                +"heists while under pressure from a government agency.", Score = 10, Price = 59.99,
                Description = "The game is played from either a third-person or first-person" 
                +"perspective and its world is navigated on foot or by vehicle. Players control the "
                +"three lead protagonists throughout single-player and switch between them both during "
                +"and outside missions.",
                ReleaseDate = new DateTime(2013,9,17), ImageUrl =  @"http://localhost/gamestore/images/gtav.jpg",
                GameDevelopers = _gameDevelopersGta,
                GamePublishers = _gamesPublishedGta,
                GameGenres = _gameGenresGta,
                GamePlataforms = _gamePlataformsGta
                },
                new Game() { Id = new Guid(), Name = "Child of light",
                ShortDescription = "Aurora, a young girl from 1895 Austria, "
                +"awakens on the lost fairytale", Score = 8.5, Price = 69.99,
                Description = "The game's story takes place in the fictional land of Lemuria. "
                +"Aurora, a child who wakes up in Lemuria after freezing to death, " 
                +"must bring back the sun, the moon and the stars held captive "
                +"by the Queen of the Night in order to return.",
                ReleaseDate = new DateTime(2014,4,29), ImageUrl =  @"http://localhost/gamestore/images/childoflight.jpg",
                GameDevelopers = _gameDevelopersCoL,
                GamePublishers = _gamesPublishedCoL,
                GameGenres = _gameGenresCoL,
                GamePlataforms = _gamePlataformsCoL
                }
            };
            foreach (Game s in games)
            {
                context.Games.Add(s);
            }

            context.SaveChanges();
        }
    }
}