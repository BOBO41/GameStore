using System.Collections.Generic;
using GameStore.Models;

namespace GameStore.ViewModels
{
    public class CreateGameViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public int ConsoleId { get; set; }
        public int CompanyId { get; set; }
        public IEnumerable<Company> Companies { get; set; }
        public IEnumerable<Console> Consoles { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}