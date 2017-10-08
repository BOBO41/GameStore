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

            var games = new Game[]
            {
                new Game() { Id = new Guid(), Name = "Final Fantasy XV",
                ShortDescription = @"an open world action role-playing video game developed 
                and published by Square Enix", Score = 9.8,
                Description = @"Final Fantasy XV takes place on the fictional world of Eos. 
                All the world's countries,bar the kingdom of Lucis, are under the dominion of 
                the empire of Niflheim. Noctis Lucis Caelum, heir to the Lucian throne, goes on
                a quest to retake his homeland and its magical Crystal ",
                ReleaseDate = new DateTime(2016,11,9), ImageUrl = Configuration["BaseUrl"] + "Images/finalfantasyxv.jpg",
                GameDevelopers = new List<GameDeveloper>() { new GameDeveloper() {
                    DeveloperId = new Guid("{3a332845-6a75-48f9-b7bf-5427570f8d9a}") } },
                GamePublishers = new List<GamePublisher>() { new GamePublisher() {
                    PublisherId = new Guid("{3a332845-6a75-48f9-b7bf-5427570f8d9a}") }},
                GameGenres = new List<GameGenre>() { new GameGenre() {
                    GenreId = new Guid("{93e7acd0-747c-4468-8ff8-f3172f5ace06}") }},
                GamePlataforms = new List<GamePlataform>() { new GamePlataform() {
                    PlataformId = new Guid("{d64c2f9d-7a4e-423d-bc1c-28f50387b3ad}") }},
                },
                new Game() { Id = new Guid(), Name = "Grand Theft Auto V",
                ShortDescription = @"the single-player story follows three criminals and their efforts to commit 
                heists while under pressure from a government agency.", Score = 10,
                Description = @"The game is played from either a third-person or first-person 
                perspective and its world is navigated on foot or by vehicle. Players control the 
                three lead protagonists throughout single-player and switch between them both during
                and outside missions.",
                ReleaseDate = new DateTime(2013,9,17), ImageUrl = Configuration["BaseUrl"] + "Images/gtav.jpg",
                GameDevelopers = new List<GameDeveloper>() { new GameDeveloper() {
                    DeveloperId = new Guid("{0a2a7f09-6ddd-4bfe-8e90-77078722336e}") } },
                GamePublishers = new List<GamePublisher>() { new GamePublisher() {
                    PublisherId = new Guid("{0a2a7f09-6ddd-4bfe-8e90-77078722336e}") }},
                GameGenres = new List<GameGenre>() { new GameGenre() {
                    GenreId = new Guid("{8a2593d7-7ae1-4a0a-89e4-a9aaeaba8074}") }},
                GamePlataforms = new List<GamePlataform>() { new GamePlataform() {
                    PlataformId = new Guid("{173f056c-0ddf-4581-a32d-f84109fd8145}") }}
                },
                new Game() { Id = new Guid(), Name = "Child of light",
                ShortDescription = @"Aurora, a young girl from 1895 Austria, 
                awakens on the lost fairytale", Score = 8.5,
                Description = @"The game's story takes place in the fictional land of Lemuria.
                Aurora, a child who wakes up in Lemuria after freezing to death, 
                must bring back the sun, the moon and the stars held captive 
                by the Queen of the Night in order to return.",
                ReleaseDate = new DateTime(2014,4,29), ImageUrl = Configuration["BaseUrl"] + "Images/childoflight.jpg",
                GameDevelopers = new List<GameDeveloper>() { new GameDeveloper() {
                    DeveloperId = new Guid("{4cb6f093-ad07-461c-a06e-2397c085da24}") } },
                GamePublishers = new List<GamePublisher>() { new GamePublisher() {
                    PublisherId = new Guid("{4cb6f093-ad07-461c-a06e-2397c085da24}") }},
                GameGenres = new List<GameGenre>() { new GameGenre() {
                    GenreId = new Guid("{93e7acd0-747c-4468-8ff8-f3172f5ace06}") }},
                GamePlataforms = new List<GamePlataform>() { new GamePlataform() {
                    PlataformId = new Guid("{16df4c17-7f30-4fff-a90e-b379eb720f3f}") }}
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