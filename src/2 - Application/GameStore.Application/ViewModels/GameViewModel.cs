using System;

namespace GameStore.Application.ViewModels
{
    public class GameViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int[] ConsolesIds { get; set; }
        public int[] CategoriesIds { get; set; }
        public int  CompanyId { get; set; }

    }
}