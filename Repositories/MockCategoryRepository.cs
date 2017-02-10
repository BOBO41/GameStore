using System.Collections.Generic;
using GameStore.Models;

namespace GameStore.Repositories
{
    public class MockCategoryRepositories : ICategoryRepository
    {
        public IEnumerable<Category> Categories {
            get {
                return new List<Category> {
                    new Category() { ID = 1, Name = "Action" },
                    new Category() { ID = 2, Name = "Shooter" },
                    new Category() { ID = 3, Name = "RPG" }
                };
            }
        }
    }  
}