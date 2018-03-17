using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameStore.Application.DTOS.Genres;
using GameStore.Application.ViewModels;

namespace GameStore.Application.Interfaces
{
    public interface IGenreServices
    {
        Task<IEnumerable<GenreViewModel>> GetAllGenres();
        Task<GenreViewModel> GetGenreById(Guid game);
        void InsertGenre(AddOrUpdateGenreDTO game);
        void UpdateGenre(AddOrUpdateGenreDTO game);
        void DeleteGenre(Guid id);
    }
}