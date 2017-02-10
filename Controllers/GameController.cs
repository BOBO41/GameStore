using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using GameStore.Repositories;

namespace GameStore.Controllers
{
    public class GameController : Controller {
        
        private readonly IGameRepository _gameRepository;
        private readonly ICategoryRepository _categoryRepository;

        public GameController(IGameRepository gameRepository, ICategoryRepository categoryRepository) {
            _gameRepository = gameRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List() {
            return View(_gameRepository.Games);
        }

        // public Task<IActionResult> Index() {
        //     return View();
        // }

    }
}