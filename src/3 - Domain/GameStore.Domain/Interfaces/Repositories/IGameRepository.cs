using GameStore.Domain.Entities;
using System.Collections.Generic;

namespace GameStore.Domain.Interfaces.Repositories
{
    public interface IGameRepository: IRepository<Game>
    {
        IEnumerable<Game> SearchByName(string search);
    }
}
