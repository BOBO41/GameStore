using System.Collections.Generic;
using GameStore.Domain.Entities;

namespace GameStore.Domain.Interfaces.Repositories
{
    public interface IUserRepository: IRepository<User>
    {
        //IEnumerable<User> SearchByName(string search);
    }
}