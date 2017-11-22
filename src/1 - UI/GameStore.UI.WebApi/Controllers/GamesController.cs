using GameStore.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using GameStore.Application.Interfaces;
using System.Collections.Generic;

namespace GameStore.UI.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class GamesController : Controller
    {
        private IGameServices _services;
        public GamesController(IGameServices services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<IEnumerable<dynamic>> Get()
        {
            return await _services.GetAllGamesWithDevelopersAsync();
        }

        [HttpGet("{id}")]
        public async Task<GameViewModel> GetAsync(Guid id)
        {
            return await _services.GetGameById(id);
        }

        [HttpPost]
        public void Post([FromBody]GameViewModel game)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("","Invalid Parameters!");
            }
            _services.InsertGame(game);
        }
        [HttpPut]
        public void Update([FromBody]GameViewModel game)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("","Invalid Parameters!");
            }
            _services.UpdateGame(game);
        }
        [HttpDelete]
        public void Delete([FromBody]GameViewModel game)
        {
            _services.DeleteGame(game);
        }
    }
}