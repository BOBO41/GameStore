using System;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using GameStore.Application.Interfaces;
using GameStore.Application.ViewModels;
using GameStore.Domain.Interfaces.Repositories;
using System.Threading.Tasks;
using GameStore.Domain.Entities;

namespace GameStore.Application.Services
{
    public class GameServices : IGameServices
    {
        private IUnitOfWork _unit;
        private IMapper _mapper;
        public GameServices(IUnitOfWork unit)
        {
            _unit = unit;
        }
        public async Task<IEnumerable<GameViewModel>> GetAllGames()
        {
            return _mapper.Map<IEnumerable<GameViewModel>>(await _unit.Games.GetAllAsync());
        }

        public async Task<GameViewModel> GetGameById(Guid gameId)
        {
            return _mapper.Map<GameViewModel>(await _unit.Games.GetByIdAsync(gameId));
        }
        public void InsertGame(GameViewModel gamevm)
        {
            _unit.Games.Add(_mapper.Map<Game>(gamevm));
        }
        public void UpdateGame(GameViewModel gamevm)
        {
            _unit.Games.Update(_mapper.Map<Game>(gamevm));
        }
        public void DeleteGame(GameViewModel gamevm)
        {
            _unit.Games.Remove(_mapper.Map<Game>(gamevm));
        }
    }
}