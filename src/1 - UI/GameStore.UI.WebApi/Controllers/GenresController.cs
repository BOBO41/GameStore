using GameStore.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using GameStore.Application.Interfaces;
using System.Collections.Generic;
using GameStore.UI.WebApi.Filters;
using GameStore.Application.DTOS.Genres;

namespace GameStore.UI.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class GenresController : Controller
    {
        private IGenreServices _services;
        public GenresController(IGenreServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IEnumerable<GenreViewModel>> Get()
        {
            return await _services.GetAllGenres();
        }

        [HttpGet("{id}")]
        public async Task<GenreViewModel> Get(Guid id)
        {
            return await _services.GetGenreById(id);
        }

        [HttpPost]
        public void Post([FromBody]AddOrUpdateGenreDTO genre)
        {
            _services.InsertGenre(genre);
        }
        [HttpPut]
        public void Update([FromBody]AddOrUpdateGenreDTO genre)
        {
            _services.UpdateGenre(genre);
        }
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _services.DeleteGenre(id);
        }
    }
}