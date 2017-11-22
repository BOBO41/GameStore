﻿using GameStore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.Domain.Interfaces.Repositories
{
    public interface IGameRepository: IRepository<Game>
    {
        IEnumerable<Game> SearchByName(string search);
        Task<IEnumerable<dynamic>> GetAllGamesWithDevelopersAsync();
    }
}
