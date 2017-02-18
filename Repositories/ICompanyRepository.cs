using System.Collections.Generic;
using GameStore.Models;

namespace GameStore.Repositories
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> Companies { get; }
    }
}