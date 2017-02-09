using System.Collections.Generic;
using GameStore.Models;
namespace GameStore.Repositories
{
    public interface IGameRepository
    {
         IEnumerable<Console> Games { get; set; }
         IEnumerable<Console> GamesOfTheWeek { get; set; }

         Game GetGameById(int gameId);
    }
}