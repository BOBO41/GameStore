using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class GameController: Controller
    {
        [HttpGet]
        public IActionResult Get () {

        }

        [HttpGet("{id}")]
        public IActionResult Get (int id) {

        }

        [HttpPost]
        public IActionResult Post ([FromBody]GameViewModel game) {

        }
    }
}