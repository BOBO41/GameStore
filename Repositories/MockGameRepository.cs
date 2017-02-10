using System.Collections.Generic;
using GameStore.Models;

namespace GameStore.Repositories
{
    public class MockGameRepository : IGameRepository
    {
        private readonly ICategoryRepository _ICategoryRepository = new MockCategoryRepositories();

        public IEnumerable<Game> Games {
            get {
                return new List<Game> {
                    new Game() { 
                        ID = 1, 
                        Name = "Final Fantasy XV", 
                        CategoryId = 3,  
                        Company = new Company() {ID = 1, Name = "Square Enix"},
                        Category = new Category() { ID = 3, Name = "RPG" },
                        Consoles = new List<Console>{
                                new Console{ ID = 1, Name = "Playstation 4" },
                                new Console{ ID = 2, Name = "Xbox One" }
                         }
                    },
                    new Game() { 
                        ID = 2, 
                        Name = "Wicher 3", 
                        CategoryId = 1,  
                        Company = new Company() {ID = 2, Name = "CD Projekt RED"},
                        Category = new Category() { ID = 1, Name = "Action" },
                        Consoles = new List<Console>{
                                new Console{ ID = 1, Name = "Playstation 4" },
                                new Console{ ID = 2, Name = "Xbox One" }
                         }
                    },
                    new Game() { 
                        ID = 3, 
                        Name = "Battlefield 1", 
                        CategoryId = 2,  
                        Company = new Company() {ID = 1, Name = "Electronic Arts"},
                        Category = new Category() { ID = 2, Name = "Shooter" },
                        Consoles = new List<Console>{
                                new Console{ ID = 1, Name = "Playstation 4" },
                                new Console{ ID = 2, Name = "Xbox One" },
                                new Console{ ID = 3, Name = "PC" }
                         }
                    }
                };
            }
        }

        public IEnumerable<Game> GamesOfTheWeek { get; set; }

        public Game GetGameById(int gameId) {
            throw new System.NotImplementedException();
        }
    }
}