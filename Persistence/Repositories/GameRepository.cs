using System.Collections.Generic;
using System.Linq;
using GameStore.Context;
using GameStore.Models;
using GameStore.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Persistence.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly StoreContext _storeContext;

        public GameRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;   
        }

        public IEnumerable<Game> Games {
            get {
                return _storeContext.Games.Include(_ => _.Category);
            }
        }

        public IEnumerable<Game> GamesOfTheWeek {
            get {
                return _storeContext.Games.Include(_ => _.Category).Where(a => a.IsGameOfTheWeek);
            }
        }

        public Game GetGameById(int gameId)
        {
            return _storeContext.Games.FirstOrDefault(_ => _.ID == gameId);
        }


    }
}