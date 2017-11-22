using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameStore.Application.ViewModels;

namespace GameStore.Application.Interfaces
{
    public interface IGameServices
    {
        Task<IEnumerable<GameViewModel>> GetAllGames();
        Task<IEnumerable<dynamic>> GetAllGamesWithDevelopersAsync();
        Task<GameViewModel> GetGameById(Guid game);
        void InsertGame(GameViewModel game);
        void UpdateGame(GameViewModel game);
        void DeleteGame(GameViewModel game);
    }
}