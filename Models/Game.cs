using System.Collections.Generic;

namespace GameStore.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public int ConsoleId { get; set; }
        public int CompanyId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
        public IEnumerable<Console> Consoles { get; set; }
        public bool IsGameOfTheWeek { get; set; }
    }
}