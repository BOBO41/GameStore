using System;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using GameStore.Application.Interfaces;
using GameStore.Application.ViewModels;
using GameStore.Domain.Interfaces.Repositories;
using System.Threading.Tasks;
using GameStore.Domain.Entities;
using GameStore.Application.DTOS.Genres;

namespace GameStore.Application.Services
{
    public class GenreServices : IGenreServices
    {
        private IUnitOfWork _unit;
        private IMapper _mapper;
        public GenreServices(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GenreViewModel>> GetAllGenres()
        {
            return _mapper.Map<IEnumerable<GenreViewModel>>(await _unit.Genres.GetAllAsync());
        }

        public async Task<GenreViewModel> GetGenreById(Guid genreId)
        {
            return _mapper.Map<GenreViewModel>(await _unit.Games.GetByIdAsync(genreId));
        }
        public void InsertGenre(AddOrUpdateGenreDTO genrevm)
        {
            _unit.Genres.Add(_mapper.Map<Genre>(genrevm));
        }
        public void UpdateGenre(AddOrUpdateGenreDTO genrevm)
        {
            _unit.Genres.Update(_mapper.Map<Genre>(genrevm));
        }
        public void DeleteGenre(Guid id)
        {
            _unit.Genres.Remove(id);
        }
    }
}