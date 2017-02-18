using Microsoft.AspNetCore.Mvc;
using GameStore.ViewModels;

namespace GameStore.Controllers
{
    public class GamesController : Controller {
        private IUnitOfWork _unit;
        public GamesController(IUnitOfWork unit) {
            _unit = unit;
        }
        public IActionResult Index() {
            return View(_unit.gameRepository.Games);
        }

        public IActionResult Create() {
            CreateGameViewModel viewmodel = new CreateGameViewModel();
            viewmodel.Categories = _unit.categoryRepository.Categories;

            return View();
        }

        public IActionResult Edit (int ID) {
            return View(_unit.gameRepository.GetGameById(ID));
        }



    }
}