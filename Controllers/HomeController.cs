using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class HomeController :Controller {
        public IActionResult Index () {
            return View();
        }
    }
}