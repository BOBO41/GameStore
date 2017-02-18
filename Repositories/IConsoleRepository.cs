using System.Collections.Generic;
using GameStore.Models;

namespace GameStore.Repositories
{
    public interface IConsoleRepository
    {
        IEnumerable<Console> Consoles { get; }
        IEnumerable<Console> ConsolesFromCompany(string producer);
    }
}