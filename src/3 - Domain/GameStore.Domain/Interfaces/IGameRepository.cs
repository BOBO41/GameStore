using GameStore.Domain.Entities;
using System.Collections.Generic;

namespace GameStore.Domain.Interfaces
{
    public interface IGameRepository: IRepository<Game>
    {
        IEnumerable<Game> SearchByName(string search);
    }
}
