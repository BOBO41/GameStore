using GameStore.Repositories;
using System;

namespace GameStore
{
    public interface IUnitOfWork : IDisposable
    {
        IGameRepository gameRepository { get; }
        ICategoryRepository categoryRepository { get; }
        IConsoleRepository consoleRepository { get; }
        ICompanyRepository companyRepository { get; }
    }
}
