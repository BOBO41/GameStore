using GameStore.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GameStore.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class GameController: Controller
    {
        [HttpGet]
        public IActionResult Get () {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IActionResult Get (int id) {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Post ([FromBody]GameViewModel game) {
            throw new NotImplementedException();
        }
    }
}