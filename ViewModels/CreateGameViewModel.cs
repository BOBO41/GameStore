using System.Collections.Generic;
using GameStore.Models;

namespace GameStore.ViewModels
{
    public class CreateGameViewModel
    {
        public string GameName { get; set; }
        public double Price { get; set; }
        public IEnumerable<Company> Companies { get; set; }
        public IEnumerable<Console> Consoles { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}