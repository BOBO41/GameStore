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
                        Price = 199.00, 
                        CategoryId = 3,  
                        Company = new Company() {ID = 1, Name = "Square Enix"},
                        Description = "A open world RPG",
                        Category = new Category() { ID = 3, Name = "RPG" },
                        Consoles = new List<Console>{
                                new Console{ ID = 1, Name = "Playstation 4" },
                                new Console{ ID = 2, Name = "Xbox One" }
                         }
                    },
                    new Game() { 
                        ID = 2, 
                        Name = "Wicher 3", 
                        Price = 99.00,
                        CategoryId = 1,  
                        Company = new Company() {ID = 2, Name = "CD Projekt RED"},
                        Description = "Magic and Violence",
                        Category = new Category() { ID = 1, Name = "Action" },
                        Consoles = new List<Console>{
                                new Console{ ID = 1, Name = "Playstation 4" },
                                new Console{ ID = 2, Name = "Xbox One" }
                         }
                    },
                    new Game() { 
                        ID = 3, 
                        Name = "Battlefield 1", 
                        Price = 129.99,
                        CategoryId = 2,  
                        Company = new Company() {ID = 1, Name = "Electronic Arts"},
                        Description = "A masterpiece of shooter games",
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