using System;
using GameStore.Context;
using GameStore.Repositories;
using GameStore.Persistence.Repositories;

namespace GameStore.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;
        private readonly StoreContext _db;
        private IGameRepository _gameRepository;
        private IConsoleRepository _consoleRepository;
        private ICompanyRepository _companyRepository;
        private ICategoryRepository _categoryRepository;
 
        public UnitOfWork(StoreContext db)
        {
            _db = db;
        }

        public IGameRepository gameRepository
        {
            get
            {
                if (_gameRepository ==null)
                {
                    _gameRepository = new GameRepository(_db);
                }
                return _gameRepository;
            }
        }

        public IConsoleRepository consoleRepository
        {
            get
            {
                if (_consoleRepository ==null)
                {
                    _consoleRepository = new ConsoleRepository(_db);
                }
                return _consoleRepository;
            }
        }
        public ICompanyRepository companyRepository 
        {
            get
            {
                if (_companyRepository ==null)
                {
                    _companyRepository = new CompanyRepository(_db);
                }
                return _companyRepository;
            }
        }
        public ICategoryRepository categoryRepository 
        {
            get
            {
                if (_categoryRepository ==null)
                {
                    _categoryRepository = new CategoryRepository(_db);
                }
                return _categoryRepository;
            }
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
