using GameStore.Domain.Interfaces.Repositories;
using GameStore.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDeveloperRepository _developerRepository;
        private IGameRepository _gameRepository;
        private IGenreRepository _genreRepository;
        private IPlataformRepository _plataformRepository;
        private IPublisherRepository _publisherRepository;
        private IUserRepository _userRepository;

        private readonly GameStoreContext _db;
        public UnitOfWork(GameStoreContext db) { _db = db; }

        public IDeveloperRepository Developers
        {
            get
            {
                if (_developerRepository == null)
                {
                    _developerRepository = new DeveloperRepository(_db);
                }
                return _developerRepository;
            }
        }
        public IGameRepository Games
        {
            get
            {
                if (_gameRepository == null)
                {
                    _gameRepository = new GameRepository(_db);
                }
                return _gameRepository;
            }
        }

        public IGenreRepository Genres
        {
            get
            {
                if (_genreRepository == null)
                {
                    _genreRepository = new GenreRepository(_db);
                }
                return _genreRepository;
            }
        }

        public IPlataformRepository Plataforms
        {
            get
            {
                if (_plataformRepository == null)
                {
                    _plataformRepository = new PlataformRepository(_db);
                }
                return _plataformRepository;
            }
        }

        public IPublisherRepository Publishers
        {
            get
            {
                if (_publisherRepository == null)
                {
                    _publisherRepository = new PublisherRepository(_db);
                }
                return _publisherRepository;
            }
        }

        public IUserRepository Users
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_db);
                }
                return _userRepository;
            }
        }

        public void Commit()
        {
            _db.SaveChanges();
        }
        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
