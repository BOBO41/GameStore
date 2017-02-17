using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using GameStore.Repositories;

namespace GameStore.Controllers
{
    public class GamesController : Controller {
        
        private readonly IGameRepository _gameRepository;
        private readonly ICategoryRepository _categoryRepository;

        public GamesController(IGameRepository gameRepository, ICategoryRepository categoryRepository) {
            _gameRepository = gameRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index() {
            return View(_gameRepository.Games);
        }

        public IActionResult Edit (int ID) {
            return View(_gameRepository.GetGameById(ID));
        }

    }
}