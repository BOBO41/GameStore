using System.Collections.Generic;
using GameStore.Models;
namespace GameStore.Repositories
{
    public interface IGameRepository
    {
         IEnumerable<Game> Games { get; }
         IEnumerable<Game> GamesOfTheWeek { get; }
         Game GetGameById(int gameId);
    }
}